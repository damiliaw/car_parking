using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using CarParkManagementSystem;

namespace park_management
{
    public partial class adminTransaction : Form
    {
        SqlConnection con = new SqlConnection(
            @"Data Source=(LocalDB)\MSSQLLocalDB;
            AttachDbFilename=|DataDirectory|\CarParkDB.mdf;
            Integrated Security=True");

        public adminTransaction()
        {
            InitializeComponent();
        }

        private void adminTransaction_Load(object sender, EventArgs e)
        {
            LoadTransactions();
            LoadSummary();
        }

        private void LoadTransactions()
        {
            try
            {
                // Memaparkan semua transaksi terkini dari database
                string query = "SELECT * FROM Parking_Transaction ORDER BY Transaction_ID DESC";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvTransactions.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading transactions: " + ex.Message);
            }
        }

        // =================================================================
        // PEMBETULAN METRIK RINGKASAN DATA (METRIC BOXES)
        // =================================================================
        private void LoadSummary()
        {
            try
            {
                if (con.State != ConnectionState.Open) con.Open();

                // 1. Total Sessions (Jumlah semua rekod transaksi)
                SqlCommand cmd1 = new SqlCommand("SELECT COUNT(*) FROM Parking_Transaction", con);
                lblTotalSessions.Text = cmd1.ExecuteScalar().ToString();

                // 2. Active Sessions (Kenderaan yang belum keluar / Exit_Timestamp adalah NULL)
                SqlCommand cmd2 = new SqlCommand("SELECT COUNT(*) FROM Parking_Transaction WHERE Exit_Timestamp IS NULL", con);
                // DIBETULKAN: Nilai dimasukkan terus ke dalam label lblActive
                lblActive.Text = cmd2.ExecuteScalar().ToString();

                // 3. Completed Sessions (Kenderaan yang telah keluar)
                SqlCommand cmd3 = new SqlCommand("SELECT COUNT(*) FROM Parking_Transaction WHERE Exit_Timestamp IS NOT NULL", con);
                lblCompleted.Text = cmd3.ExecuteScalar().ToString();

                // 4. Total Revenue (Jumlah kutipan kasar dari transaksi selesai)
                SqlCommand cmd4 = new SqlCommand("SELECT SUM(Total_Fee) FROM Parking_Transaction WHERE Total_Fee IS NOT NULL", con);
                object revObj = cmd4.ExecuteScalar();
                decimal revenue = (revObj != DBNull.Value && revObj != null) ? Convert.ToDecimal(revObj) : 0.00m;
                lblRevenue.Text = "RM " + revenue.ToString("0.00");

                con.Close();
            }
            catch (Exception ex)
            {
                if (con.State == ConnectionState.Open) con.Close();
                System.Diagnostics.Debug.WriteLine("Summary Error: " + ex.Message);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadTransactions();
            LoadSummary();
            txtSearch.Clear();
        }

        // =================================================================
        // DIUBAH SUAI: LOGIK RECORD EXIT MENGGUNAKAN NOMBOR PLAT KENDERAAN
        // =================================================================
        private void btnRecordExit_Click(object sender, EventArgs e)
        {
            string licensePlate = txtSearch.Text.Trim();

            if (string.IsNullOrEmpty(licensePlate))
            {
                MessageBox.Show("Please enter a valid License Plate to search (e.g., WKL 2213).");
                return;
            }

            try
            {
                // Menggunakan INNER JOIN untuk mencari rekod transaksi aktif berdasarkan Nombor Plat Kenderaan
                // Serta memastikan kita hanya mengambil transaksi yang BELUM keluar (Exit_Timestamp IS NULL)
                string getQuery = @"
                    SELECT t.* FROM Parking_Transaction t
                    INNER JOIN Vehicle v ON t.Vehicle_ID = v.Vehicle_ID
                    WHERE v.License_Plate = @plate AND t.Exit_Timestamp IS NULL";

                SqlCommand getCmd = new SqlCommand(getQuery, con);
                getCmd.Parameters.AddWithValue("@plate", licensePlate);

                if (con.State != ConnectionState.Open) con.Open();
                SqlDataReader dr = getCmd.ExecuteReader();

                string transactionID = "";
                DateTime entryTime = DateTime.Now;
                string rateID = "";
                string slotID = "";
                bool hasRecord = false;

                if (dr.Read())
                {
                    hasRecord = true;
                    transactionID = dr["Transaction_ID"].ToString();
                    entryTime = Convert.ToDateTime(dr["Entry_Timestamp"]);
                    rateID = dr["Rate_ID"].ToString();
                    slotID = dr["Slot_ID"].ToString();
                }

                dr.Close();

                // Jika tiada transaksi aktif ditemui untuk nombor plat tersebut
                if (!hasRecord)
                {
                    MessageBox.Show("No active parking transaction found for this License Plate, or the vehicle has already left.");
                    con.Close();
                    return;
                }

                // Mengira beza jam antara masuk dan sekarang
                double hours = (DateTime.Now - entryTime).TotalHours;
                if (hours < 1) hours = 1; // Minimum caj dikira sebagai 1 jam
                int roundedHours = (int)Math.Ceiling(hours);

                decimal baseFee = 0;
                decimal hourlyRate = 0;

                // Ambil struktur kadar harga semasa kenderaan dari jadual Rate
                SqlCommand rateCmd = new SqlCommand("SELECT Base_Fee, Hourly_Rate FROM Rate WHERE Rate_ID=@id", con);
                rateCmd.Parameters.AddWithValue("@id", rateID);

                SqlDataReader rateReader = rateCmd.ExecuteReader();
                if (rateReader.Read())
                {
                    baseFee = Convert.ToDecimal(rateReader["Base_Fee"]);
                    hourlyRate = Convert.ToDecimal(rateReader["Hourly_Rate"]);
                }
                rateReader.Close();

                // Formula pengiraan: Base Fee + (Kadar Sejam * Bundaran Jam)
                decimal totalFee = baseFee + ((decimal)roundedHours * hourlyRate);

                // 1. Kemas kini status Parking_Transaction (Set Exit_Timestamp dan Total_Fee) menggunakan Transaction_ID yang dicari tadi
                SqlCommand updateTransaction = new SqlCommand(
                    @"UPDATE Parking_Transaction  
                      SET Exit_Timestamp=@exit, Total_Fee=@fee  
                      WHERE Transaction_ID=@id", con);

                updateTransaction.Parameters.AddWithValue("@exit", DateTime.Now);
                updateTransaction.Parameters.AddWithValue("@fee", totalFee);
                updateTransaction.Parameters.AddWithValue("@id", transactionID);
                updateTransaction.ExecuteNonQuery();

                // 2. Kemas kini status petak parking kembali menjadi 'Available'
                SqlCommand updateSlot = new SqlCommand(
                    @"UPDATE Parking_Slot  
                      SET Status='Available'  
                      WHERE Slot_ID=@slot", con);

                updateSlot.Parameters.AddWithValue("@slot", slotID);
                updateSlot.ExecuteNonQuery();

                con.Close();

                MessageBox.Show($"Exit Recorded Successfully for {licensePlate}!\nDuration: {roundedHours} Hour(s)\nTotal Fee Charged: RM {totalFee.ToString("0.00")}");

                // Muat semula paparan borang skrin
                LoadTransactions();
                LoadSummary();
                txtSearch.Clear();
            }
            catch (Exception ex)
            {
                if (con.State == ConnectionState.Open) con.Close();
                MessageBox.Show("Error recording exit: " + ex.Message);
            }
        }

        // Pengekalan Fungsi Navigasi & Event Handlers
        private void dgvTransactions_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Apabila row diklik, kita biarkan admin melihat Transaction ID atau jika anda mahu menukarnya 
            // kepada paparan Plat Kenderaan dalam DataGridView (pastikan kolum plat wujud dalam dgv)
            if (e.RowIndex >= 0 && e.RowIndex < dgvTransactions.Rows.Count)
            {
                var val = dgvTransactions.Rows[e.RowIndex].Cells["Transaction_ID"].Value;
                if (val != null) txtSearch.Text = val.ToString();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e) { }
        private void lblRevenue_Click(object sender, EventArgs e) { }
        private void lblCompleted_Click(object sender, EventArgs e) { }
        private void lblTotalSessions_Click(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }
        private void gpboxTotalSessions_Enter(object sender, EventArgs e) { }
        private void gpboxActive_Enter(object sender, EventArgs e) { }
        private void gpboxCompleted_Enter(object sender, EventArgs e) { }

        private void linkLogOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }

        private void parkSlotbttn_Click(object sender, EventArgs e)
        {
            adminParkSlot frm = new adminParkSlot();
            frm.Show();
            this.Hide();
        }

        private void TranscBttn_Click(object sender, EventArgs e) { }

        private void EntryBttn_Click(object sender, EventArgs e)
        {
            adminEntry frm = new adminEntry();
            frm.Show();
            this.Hide();
        }

        private void RateBttn_Click(object sender, EventArgs e)
        {
            AdminRate frm = new AdminRate();
            frm.Show();
            this.Hide();
        }

        private void vehicleBttn_Click(object sender, EventArgs e)
        {
            adminDashboard frm = new adminDashboard();
            frm.Show();
            this.Hide();
        }

        private void dashboardBttn_Click(object sender, EventArgs e)
        {
            adminDashBooard frm = new adminDashBooard();
            frm.Show();
            this.Hide();
        }
    }
}