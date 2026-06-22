using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using CarParkManagementSystem;

namespace park_management
{
    public partial class AdminRate : Form
    {
        SqlConnection con = new SqlConnection(
            @"Data Source=(LocalDB)\MSSQLLocalDB;
            AttachDbFilename=|DataDirectory|\CarParkDB.mdf;
            Integrated Security=True");

        public AdminRate()
        {
            InitializeComponent();
        }

        private void AdminRate_Load(object sender, EventArgs e)
        {
            LoadRates();
        }

        private void LoadRates()
        {
            try
            {
                SqlDataAdapter da =
                    new SqlDataAdapter(
                        "SELECT * FROM Rate",
                        con);

                DataTable dt = new DataTable();

                da.Fill(dt);

                dgvPreview.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private string GenerateRateID()
        {
            string prefix = "";

            if (cmbVehicleType.Text == "Car")
                prefix = "C";
            else if (cmbVehicleType.Text == "Motorcycle")
                prefix = "M";
            else
                return "";

            string query =
                @"SELECT COUNT(*) + 1
          FROM Rate
          WHERE Vehicle_Type = @type";

            SqlCommand cmd =
                new SqlCommand(query, con);

            cmd.Parameters.AddWithValue(
                "@type",
                cmbVehicleType.Text);

            int count =
                Convert.ToInt32(
                    cmd.ExecuteScalar());

            return prefix + count.ToString("D2");
        }
        private void ClearFields()
        {
            txtRateID.Text = "";

            cmbVehicleType.SelectedIndex = -1;

            numBaseFee.Value = 0;
            numHourlyRate.Value = 0;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dgvPreview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row =
                    dgvPreview.Rows[e.RowIndex];

                txtRateID.Text =
                    row.Cells["Rate_ID"].Value.ToString();

                cmbVehicleType.Text =
                    row.Cells["Vehicle_Type"].Value.ToString();

                numBaseFee.Value =
                    Convert.ToDecimal(
                        row.Cells["Base_Fee"].Value);

                numHourlyRate.Value =
                    Convert.ToDecimal(
                        row.Cells["Hourly_Rate"].Value);
            }
        }

        private void txtRateID_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbVehicleType_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbVehicleType.Text == "")
                    return;

                if (con.State != ConnectionState.Open)
                    con.Open(); 

                txtRateID.Text = GenerateRateID();

                con.Close();
            }
            catch
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }   

        private void numGrace_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numBaseFee_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numHourlyRate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                string rateID = GenerateRateID();

                string query =
                @"INSERT INTO Rate
        (
            Rate_ID,
            Vehicle_Type,
            Grace_Period,
            Base_Fee,
            Hourly_Rate
        )
        VALUES
        (
            @id,
            @type,
            @grace,
            @base,
            @hourly
        )";

                SqlCommand cmd =
                    new SqlCommand(query, con);

                cmd.Parameters.AddWithValue(
                    "@id",
                    rateID);

                cmd.Parameters.AddWithValue(
                    "@type",
                    cmbVehicleType.Text);

                cmd.Parameters.AddWithValue(
                    "@base",
                    numBaseFee.Value);

                cmd.Parameters.AddWithValue(
                    "@hourly",
                    numHourlyRate.Value);

                cmd.ExecuteNonQuery();

                con.Close();

                MessageBox.Show(
                    "Rate Saved Successfully");

                LoadRates();

                ClearFields();
            }
            catch (Exception ex)
            {
                if (con.State == ConnectionState.Open)
                    con.Close();

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
                string query =
                    @"DELETE FROM Rate
                      WHERE Rate_ID = @id";

                SqlCommand cmd =
                    new SqlCommand(query, con);

                cmd.Parameters.AddWithValue(
                    "@id",
                    txtRateID.Text);

                con.Open();

                cmd.ExecuteNonQuery();

                con.Close();

                MessageBox.Show(
                    "Rate Deleted Successfully");

                LoadRates();

                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void linkLogOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 frm = new Form1();

            frm.Show();

            this.Hide();
        }

        private void parkSlotbttn_Click(object sender, EventArgs e)
        {
            adminParkSlot frm =
                new adminParkSlot();

            frm.Show();

            this.Hide();
        }

        private void TranscBttn_Click(object sender, EventArgs e)
        {
            adminTransaction frm =
                new adminTransaction();

            frm.Show();

            this.Hide();
        }

        private void EntryBttn_Click(object sender, EventArgs e)
        {
            adminEntry frm =
                new adminEntry();

            frm.Show();

            this.Hide();
        }

        private void RateBttn_Click(object sender, EventArgs e)
        {

        }

        private void vehicleBttn_Click(object sender, EventArgs e)
        {
            adminDashboard frm =
                new adminDashboard();

            frm.Show();

            this.Hide();
        }

        private void dashboardBttn_Click(object sender, EventArgs e)
        {
            adminDashBooard frm =
                new adminDashBooard();

            frm.Show();

            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string query =
                @"UPDATE Rate
          SET Vehicle_Type = @type,
              Grace_Period = @grace,
              Base_Fee = @base,
              Hourly_Rate = @hourly
          WHERE Rate_ID = @id";

                SqlCommand cmd =
                    new SqlCommand(query, con);

                cmd.Parameters.AddWithValue(
                    "@id",
                    txtRateID.Text);

                cmd.Parameters.AddWithValue(
                    "@type",
                    cmbVehicleType.Text);

                cmd.Parameters.AddWithValue(
                    "@base",
                    numBaseFee.Value);

                cmd.Parameters.AddWithValue(
                    "@hourly",
                    numHourlyRate.Value);

                con.Open();

                cmd.ExecuteNonQuery();

                con.Close();

                MessageBox.Show(
                    "Rate Updated Successfully");

                LoadRates();

                ClearFields();
            }
            catch (Exception ex)
            {
                if (con.State == ConnectionState.Open)
                    con.Close();

                MessageBox.Show(ex.Message);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}