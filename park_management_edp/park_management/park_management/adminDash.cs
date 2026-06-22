using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using CarParkManagementSystem;

namespace park_management
{
    public partial class adminDashBooard : Form
    {
        SqlConnection con = new SqlConnection(
            @"Data Source=(LocalDB)\MSSQLLocalDB;
            AttachDbFilename=|DataDirectory|\CarParkDB.mdf;
            Integrated Security=True");

        public adminDashBooard()
        {
            InitializeComponent();
        }

        private void adminDashBooard_Load(object sender, EventArgs e)
        {
            LoadDashboardData();
            LoadChart();
        }

        // =================================================================
        // PENGAMBILAN DATA METRIK UTAMA
        // =================================================================
        private void LoadDashboardData()
        {
            try
            {
                if (con.State != ConnectionState.Open) con.Open();

                // 1. Total Slots
                SqlCommand totalSlots = new SqlCommand("SELECT COUNT(*) FROM Parking_Slot", con);
                lblTotalSlots.Text = totalSlots.ExecuteScalar().ToString();

                // 2. Occupied Slots
                SqlCommand occupiedSlots = new SqlCommand("SELECT COUNT(*) FROM Parking_Slot WHERE Status='Occupied'", con);
                lblOccupied.Text = occupiedSlots.ExecuteScalar().ToString();

                // 3. Available Slots
                SqlCommand availableSlots = new SqlCommand("SELECT COUNT(*) FROM Parking_Slot WHERE Status='Available'", con);
                lblAvailable.Text = availableSlots.ExecuteScalar().ToString();

                // 4. Total Revenue
                SqlCommand revenue = new SqlCommand("SELECT ISNULL(SUM(Total_Fee),0) FROM Parking_Transaction", con);
                lblRevenue.Text = "RM " + Convert.ToDecimal(revenue.ExecuteScalar()).ToString("0.00");

                con.Close();
            }
            catch (Exception ex)
            {
                if (con.State == ConnectionState.Open) con.Close();
                MessageBox.Show("Error loading metrics: " + ex.Message);
            }
        }

        // =================================================================
        // PENGEMASAN DATA CARTA VISUAL
        // =================================================================
        private void LoadChart()
        {
            try
            {
                chart1.Series[0].Points.Clear();

                int available = 0;
                int occupied = 0;

                int.TryParse(lblAvailable.Text, out available);
                int.TryParse(lblOccupied.Text, out occupied);

                chart1.Series[0].Points.AddXY("Available", available);
                chart1.Series[0].Points.AddXY("Occupied", occupied);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Chart Error: " + ex.Message);
            }
        }

        // =================================================================
        // EVENT BUTTON ASAL (KEKALKAN NAMA AGAR DESIGN TIDAK HILANG)
        // =================================================================

        // Button Refresh / Dashboard (Butang paling atas sekali)
        private void button1_Click(object sender, EventArgs e)
        {
            LoadDashboardData();
            LoadChart();
        }

        // Button Dashboard (Menu Navigasi)
        private void button2_Click(object sender, EventArgs e)
        {
            // Muat semula halaman ini sahaja
            LoadDashboardData();
            LoadChart();
        }

        // Button Entry
        private void button3_Click(object sender, EventArgs e)
        {
            adminEntry frm = new adminEntry();
            frm.Show();
            this.Hide();
        }

        // Button Transaction
        private void button4_Click(object sender, EventArgs e)
        {
            adminTransaction frm = new adminTransaction();
            frm.Show();
            this.Hide();
        }

        // Button Rate
        private void button5_Click(object sender, EventArgs e)
        {
            AdminRate frm = new AdminRate();
            frm.Show();
            this.Hide();
        }

        // Button Parking Slot
        private void button6_Click(object sender, EventArgs e)
        {
            adminParkSlot frm = new adminParkSlot();
            frm.Show();
            this.Hide();
        }

        // Link Log Out
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }

        // =================================================================
        // EVENT HANDLERS SOKONGAN (KOSONG)
        // =================================================================
        private void lblTotalSlots_Click(object sender, EventArgs e) { }
        private void lblOccupied_Click(object sender, EventArgs e) { }
        private void lblAvailable_Click(object sender, EventArgs e) { }
        private void lblRevenue_Click(object sender, EventArgs e) { }
        private void chart1_Click(object sender, EventArgs e) { }
        private void layoutSlotMap_Paint(object sender, PaintEventArgs e) { }
        private void layoutRecentTransactions_Paint(object sender, PaintEventArgs e) { }
        private void groupBox2_Enter(object sender, EventArgs e) { }
    }
}