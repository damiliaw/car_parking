using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using CarParkManagementSystem;

namespace park_management
{
    public partial class adminDashboard : Form
    {
        SqlConnection con = new SqlConnection(
            @"Data Source=(LocalDB)\MSSQLLocalDB;
            AttachDbFilename=|DataDirectory|\CarParkDB.mdf;
            Integrated Security=True");

        // Flag untuk halang auto-generate ID masa klik DataGridView
        private bool isBinding = false;

        public adminDashboard()
        {
            InitializeComponent();

            cmbVehicleType.Items.Clear();
            cmbVehicleType.Items.Add("Car");
            cmbVehicleType.Items.Add("Motorcycle");
        }

        private void adminDashboard_Load(object sender, EventArgs e)
        {
            LoadVehicle();
        }

        private void LoadVehicle()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Vehicle", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvVehicles.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private string GenerateVehicleID()
        {
            try
            {
                string query = "SELECT COUNT(*) FROM Vehicle";
                SqlCommand cmd = new SqlCommand(query, con);

                if (con.State != ConnectionState.Open)
                    con.Open();

                int count = Convert.ToInt32(cmd.ExecuteScalar());
                con.Close();

                int nextNumber = count + 1;
                return "VH-" + nextNumber.ToString("D3");
            }
            catch
            {
                if (con.State == ConnectionState.Open)
                    con.Close();

                return "VH-001";
            }
        }

        private void ClearFields()
        {
            txtVehicleID.Clear();
            txtNoPlate.Clear();
            txtColorModel.Clear();
            txtSearchPlate.Clear();
            cmbVehicleType.SelectedIndex = -1;
        }

        private void cmbVehicleType_SelectedIndexChanged(object sender, EventArgs e)
        {
            // JIKA isBinding = true (tengah klik grid), potong barisan & jangan generate ID baru!
            if (isBinding) return;

            try
            {
                if (cmbVehicleType.Text == "")
                    return;

                txtVehicleID.Text = GenerateVehicleID();
            }
            catch (Exception ex)
            {
                if (con.State == ConnectionState.Open) con.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvVehicles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Set true sebab kita nak masukkan data lama ke dalam fields
                isBinding = true;

                DataGridViewRow row = dgvVehicles.Rows[e.RowIndex];

                txtVehicleID.Text = row.Cells["Vehicle_ID"].Value.ToString();
                txtNoPlate.Text = row.Cells["License_Plate"].Value.ToString();
                cmbVehicleType.Text = row.Cells["Vehicle_Type"].Value.ToString();
                txtColorModel.Text = row.Cells["Color_Model"].Value.ToString();

                // Lepas dah siap masukkan semua data, set balik jadi false
                isBinding = false;
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                string query = @"INSERT INTO Vehicle (Vehicle_ID, License_Plate, Vehicle_Type, Color_Model) 
                                VALUES (@id, @plate, @type, @color)";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id", txtVehicleID.Text);
                cmd.Parameters.AddWithValue("@plate", txtNoPlate.Text);
                cmd.Parameters.AddWithValue("@type", cmbVehicleType.Text);
                cmd.Parameters.AddWithValue("@color", txtColorModel.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Vehicle Registered Successfully");
                LoadVehicle();
                ClearFields();
            }
            catch (Exception ex)
            {
                if (con.State == ConnectionState.Open) con.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string query = @"SELECT * FROM Vehicle WHERE License_Plate LIKE @plate";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.SelectCommand.Parameters.AddWithValue("@plate", "%" + txtSearchPlate.Text + "%");

                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvVehicles.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string query = @"DELETE FROM Vehicle WHERE Vehicle_ID = @id";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id", txtVehicleID.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Vehicle Deleted Successfully");
                LoadVehicle();
                ClearFields();
            }
            catch (Exception ex)
            {
                if (con.State == ConnectionState.Open) con.Close();
                MessageBox.Show(ex.Message);
            }
        }

        // =================================================================
        // SIDEBAR NAVIGATION BUTTONS
        // =================================================================
        private void dashboardBttn_Click(object sender, EventArgs e)
        {
            adminDashBooard frm = new adminDashBooard();
            frm.Show();
            this.Hide();
        }

        private void vehicleBttn_Click(object sender, EventArgs e) { }

        private void RateBttn_Click(object sender, EventArgs e)
        {
            AdminRate frm = new AdminRate();
            frm.Show();
            this.Hide();
        }

        private void EntryBttn_Click(object sender, EventArgs e)
        {
            adminEntry frm = new adminEntry();
            frm.Show();
            this.Hide();
        }

        private void TranscBttn_Click(object sender, EventArgs e)
        {
            adminTransaction frm = new adminTransaction();
            frm.Show();
            this.Hide();
        }

        private void parkSlotbttn_Click(object sender, EventArgs e)
        {
            adminParkSlot frm = new adminParkSlot();
            frm.Show();
            this.Hide();
        }

        private void linkLogOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }

        private void txtVehicleID_TextChanged(object sender, EventArgs e) { }
        private void txtNoPlate_TextChanged(object sender, EventArgs e) { }
        private void txtColorModel_TextChanged(object sender, EventArgs e) { }
        private void txtSearchPlate_TextChanged(object sender, EventArgs e) { }
    }
}