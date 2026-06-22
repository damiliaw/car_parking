using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using CarParkManagementSystem;

namespace park_management
{
    public partial class adminEntry : Form
    {
        SqlConnection con = new SqlConnection(
            @"Data Source=(LocalDB)\MSSQLLocalDB;
            AttachDbFilename=|DataDirectory|\CarParkDB.mdf;
            Integrated Security=True");

        public adminEntry()
        {
            InitializeComponent();
        }

        private void adminEntry_Load(object sender, EventArgs e)
        {
            LoadVehiclePreview();       // JADUAL ATAS: Muat data Vehicle [dgvPreview]
            LoadTransactionPreview();   // JADUAL BAWAH: Muat data Parking_Transaction [dataGridView1]
            LoadSlotsComboBox();        // Mengisi dropdown slot Available
            LoadRatesComboBox();        // Mengisi dropdown konfigurasi kadar kenderaan
            SetRealTimeEntry();         // Mengeset auto masa masuk sistem
        }

        // =================================================================
        // JADUAL ATAS (FEE PREVIEW): PAPAR JADUAL VEHICLE
        // =================================================================
        private void LoadVehiclePreview()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Vehicle", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvPreview.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading vehicle grid: " + ex.Message);
            }
        }

        // =================================================================
        // FIX UTAMA - JADUAL BAWAH (TRANSACTION PREVIEW): PAPAR JADUAL TRANSACTION
        // =================================================================
        private void LoadTransactionPreview()
        {
            try
            {
                string query = "SELECT * FROM Parking_Transaction ORDER BY Transaction_ID DESC";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading transaction preview grid: " + ex.Message);
            }
        }

        private void LoadSlotsComboBox()
        {
            try
            {
                string query = "SELECT Slot_ID, Slot_Number FROM Parking_Slot WHERE Status='Available' ORDER BY Slot_Number ASC";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                availableSlot.DataSource = dt;
                availableSlot.DisplayMember = "Slot_Number";
                availableSlot.ValueMember = "Slot_ID";
                availableSlot.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading slots: " + ex.Message);
            }
        }

        private void LoadRatesComboBox()
        {
            try
            {
                string query = "SELECT Rate_ID, Vehicle_Type, Hourly_Rate FROM Rate";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dt.Columns.Add("RateDisplay", typeof(string));
                foreach (DataRow row in dt.Rows)
                {
                    row["RateDisplay"] = $"{row["Vehicle_Type"]} (RM {row["Hourly_Rate"]})";
                }

                rateApplied.DataSource = dt;
                rateApplied.DisplayMember = "RateDisplay";
                rateApplied.ValueMember = "Rate_ID";
                rateApplied.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading rates: " + ex.Message);
            }
        }

        private void SetRealTimeEntry()
        {
            txtBoxEntryAuto.Text = DateTime.Now.ToString("dd/M/yyyy HH:mm");
        }

        private void ClearFields()
        {
            txtNoPlate.Clear();
            txtVehicleID.Clear();
            txtBoxVehicleType.Clear();
            txtBoxDuration.Clear();

            // Mengosongkan paparan yuran yang dikira jika komponen ini wujud di UI anda
            // txtBoxTotalFee.Clear(); 

            availableSlot.SelectedIndex = -1;
            rateApplied.SelectedIndex = -1;

            SetRealTimeEntry();
        }

        private void refreshBttn_Click(object sender, EventArgs e)
        {
            LoadVehiclePreview();
            LoadTransactionPreview();
            LoadSlotsComboBox();
            LoadRatesComboBox();
            ClearFields();
            MessageBox.Show("Data refreshed successfully!");
        }

        private void dgvPreview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvPreview.Rows.Count)
            {
                DataGridViewRow row = dgvPreview.Rows[e.RowIndex];

                txtNoPlate.Text = row.Cells["License_Plate"].Value?.ToString() ?? "";
                txtVehicleID.Text = row.Cells["Vehicle_ID"].Value?.ToString() ?? "";
                txtBoxVehicleType.Text = row.Cells["Vehicle_Type"].Value?.ToString() ?? "";

                FetchRateIDByVehicleType(txtBoxVehicleType.Text);
                CalculateLiveFee();
            }
        }

        private void FetchRateIDByVehicleType(string vehicleType)
        {
            if (string.IsNullOrEmpty(vehicleType)) return;
            try
            {
                string query = "SELECT Rate_ID FROM Rate WHERE Vehicle_Type = @type";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@type", vehicleType);

                if (con.State != ConnectionState.Open) con.Open();
                object rID = cmd.ExecuteScalar();
                con.Close();

                if (rID != null)
                {
                    rateApplied.SelectedValue = rID.ToString();
                }
            }
            catch { }
        }

        private void btnLookup_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNoPlate.Text.Trim()))
            {
                MessageBox.Show("Please enter a License Plate first!");
                return;
            }

            try
            {
                string query = @"SELECT v.Vehicle_ID, v.Vehicle_Type, r.Rate_ID 
                                FROM Vehicle v
                                LEFT JOIN Rate r ON v.Vehicle_Type = r.Vehicle_Type
                                WHERE v.License_Plate = @plate";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@plate", txtNoPlate.Text.Trim());

                if (con.State != ConnectionState.Open) con.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    txtVehicleID.Text = dr["Vehicle_ID"].ToString();
                    txtBoxVehicleType.Text = dr["Vehicle_Type"].ToString();

                    if (dr["Rate_ID"] != DBNull.Value)
                    {
                        rateApplied.SelectedValue = dr["Rate_ID"].ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Vehicle License Plate Not Found!");
                    txtVehicleID.Clear();
                    txtBoxVehicleType.Clear();
                    rateApplied.SelectedIndex = -1;
                }

                dr.Close();
                con.Close();

                CalculateLiveFee();
            }
            catch (Exception ex)
            {
                if (con.State == ConnectionState.Open) con.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void txtBoxDuration_TextChanged(object sender, EventArgs e)
        {
            CalculateLiveFee();
        }

        private void rateApplied_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalculateLiveFee();
        }

        // =================================================================
        // DIBETULKAN: PEMBENTULAN LOGIK PENGIRAAN LIVE FEE & STRUKTUR OUTPUT
        // =================================================================
        private void CalculateLiveFee()
        {
            // Pastikan duration diisi dengan nombor bulat (Hours)
            if (int.TryParse(txtBoxDuration.Text.Trim(), out int hours) && rateApplied.SelectedValue != null)
            {
                try
                {
                    if (con.State != ConnectionState.Open) con.Open();

                    string query = "SELECT Base_Fee, Hourly_Rate FROM Rate WHERE Rate_ID = @rID";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@rID", rateApplied.SelectedValue.ToString());

                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        decimal baseFee = Convert.ToDecimal(dr["Base_Fee"]);
                        decimal hourlyRate = Convert.ToDecimal(dr["Hourly_Rate"]);

                        // Formula pengiraan utama
                        decimal totalFee = baseFee + (hourlyRate * hours);

                        // INFO JIKA ANDA MEMPUNYAI TXTBOX ATAU LABEL UNTUK TOTAL FEE DI UI:
                        // Sila aktifkan baris kod di bawah jika ingin memaparkan terus harga live ke UI screen.
                        // txtBoxTotalFee.Text = "RM " + totalFee.ToString("0.00");
                    }
                    dr.Close();
                    con.Close();
                }
                catch
                {
                    if (con.State == ConnectionState.Open) con.Close();
                }
            }
        }

        // BUTTON CONFIRM ENTRY (SIMPAN REKOD BARU)
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtVehicleID.Text))
                {
                    MessageBox.Show("Please perform a Lookup first with a valid registered vehicle.");
                    return;
                }

                if (availableSlot.SelectedValue == null)
                {
                    MessageBox.Show("Please select an available slot from the dropdown.");
                    return;
                }

                if (rateApplied.SelectedValue == null)
                {
                    MessageBox.Show("Please select a rate applied from the dropdown.");
                    return;
                }

                if (con.State != ConnectionState.Open) con.Open();

                // Generate ID format TX-0001
                string nextTransactionID = "TX-0001";
                string colQuery = "SELECT TOP 1 Transaction_ID FROM Parking_Transaction ORDER BY Transaction_ID DESC";
                SqlCommand colCmd = new SqlCommand(colQuery, con);
                object lastID = colCmd.ExecuteScalar();

                if (lastID != null && lastID != DBNull.Value)
                {
                    string currentID = lastID.ToString();
                    if (currentID.StartsWith("TX-"))
                    {
                        int num = int.Parse(currentID.Substring(3)) + 1;
                        nextTransactionID = "TX-" + num.ToString("D4");
                    }
                }

                // Masuk data ke Parking_Transaction (Kemasukan baru, Total_Fee permulaan diletakkan 0.00 dahulu)
                string query = @"INSERT INTO Parking_Transaction (Transaction_ID, Entry_Timestamp, Exit_Timestamp, Total_Fee, Slot_ID, Vehicle_ID, Rate_ID)
                                VALUES (@txID, @entry, NULL, 0.00, @slot, @vehicle, @rate)";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@txID", nextTransactionID);
                cmd.Parameters.AddWithValue("@entry", DateTime.Now);
                cmd.Parameters.AddWithValue("@slot", availableSlot.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("@vehicle", txtVehicleID.Text);
                cmd.Parameters.AddWithValue("@rate", rateApplied.SelectedValue.ToString());

                cmd.ExecuteNonQuery();
                con.Close();

                // Tukar status slot ke 'Occupied'
                UpdateSlotStatus(availableSlot.SelectedValue.ToString());
                MessageBox.Show($"Vehicle Entry Recorded Successfully!\nTransaction ID Generated: {nextTransactionID}");

                // REFRESH KEDUA-DUA JADUAL SELEPAS CONFIRM
                LoadVehiclePreview();
                LoadTransactionPreview();
                LoadSlotsComboBox();
                ClearFields();
            }
            catch (Exception ex)
            {
                if (con.State == ConnectionState.Open) con.Close();
                MessageBox.Show("Insertion failed: " + ex.Message);
            }
        }

        private void UpdateSlotStatus(string slotID)
        {
            try
            {
                string query = @"UPDATE Parking_Slot SET Status='Occupied' WHERE Slot_ID=@slot";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@slot", slotID);

                if (con.State != ConnectionState.Open) con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                if (con.State == ConnectionState.Open) con.Close();
                MessageBox.Show("Error updating slot status: " + ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        // Navigasi Menu
        private void dashboardBttn_Click(object sender, EventArgs e)
        {
            adminDashBooard frm = new adminDashBooard();
            frm.Show();
            this.Hide();
        }

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

        private void TranscBttn_Click(object sender, EventArgs e)
        {
            adminTransaction frm = new adminTransaction();
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

        private void availableSlot_SelectedIndexChanged(object sender, EventArgs e) { }
        private void dgvPreview_CellContentClick(object sender, DataGridViewCellEventArgs e) { dgvPreview_CellClick(sender, e); }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void txtBoxEntryAuto_TextChanged(object sender, EventArgs e) { }
        private void txtVehicleID_TextChanged(object sender, EventArgs e) { }
        private void txtBoxVehicleType_TextChanged(object sender, EventArgs e) { }
        private void txtNoPlate_TextChanged_1(object sender, EventArgs e) { }
        private void EntryBttn_Click(object sender, EventArgs e) { }
    }
}