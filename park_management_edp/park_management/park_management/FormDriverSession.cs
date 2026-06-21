using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace park_management
{
    public partial class FormDriverSession : Form
    {
        string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\CarParkDB.mdf;Integrated Security=True;";
        private string activePlate;

        public FormDriverSession(string plate)
        {
            InitializeComponent();
            this.activePlate = plate;
        }
        public FormDriverSession()
        {
            InitializeComponent();
        }

        private void labelNoPlate_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void FormDriverSession_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string query = "SELECT top 1 SessionID, SlotNumber, EntryTime, Duration, TotalPay, Status " +
                               "FROM ParkingSession WHERE LicensePlate = @plate ORDER BY SessionID DESC";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@plate", activePlate);

                    try
                    {
                        conn.Open();
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            // Mengisi label maklumat status atas (Petak, Masa Mula, Waktu Tamat)
                            labelSlot.Text = reader["SlotNumber"].ToString();

                            DateTime entryTime = Convert.ToDateTime(reader["EntryTime"]);
                            labelParked.Text = entryTime.ToString("hh:mm tt");

                            int hours = Convert.ToInt32(reader["Duration"]);
                            labelDue.Text = entryTime.AddHours(hours).ToString("hh:mm tt");

                            // Mengisi label ringkasan output bawah mengikut nama rekaan kau
                            labelTransactionOutput.Text = "TXN-" + reader["SessionID"].ToString();
                            labelEntryTImeOutput.Text = entryTime.ToString("dd/MM/yyyy hh:mm tt");
                            labelDurationChosenOutput.Text = hours.ToString() + " Hours";
                            labelRateOutput.Text = "RM " + Convert.ToDouble(reader["TotalPay"]).ToString("0.00");
                            labelStatusOuput.Text = reader["Status"].ToString();
                        }
                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Database Error: " + ex.Message);
                    }
                }
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you! Have a safe drive.", "Goodbye", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Exit();
        }
    }
}
