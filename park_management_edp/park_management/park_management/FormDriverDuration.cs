using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace park_management
{
    public partial class FormDriverDuration : Form
    {

        string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\CarParkDB.mdf;Integrated Security=True;";

        private string licensePlate;
        private int selectedHours = 0;
        private double baseFee = 2.00;
        private double hourlyRate = 1.00; // Mengatasi isu undeclared 'hourlyRate' sebelum ini
        private double finalTotal = 0.00;

        public FormDriverDuration(string plate)
        {
            InitializeComponent(); 
            this.licensePlate = plate;
        }

        public FormDriverDuration()
        {
            InitializeComponent();
        }

        private void textBoxHours_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxHours.Text, out int customHour))
            {
                selectedHours = customHour;
                KiraDanPaparHarga();
            }
        }

        private void FormDriverDuration_Load(object sender, EventArgs e)
        {
            labelTotalFee.Text = "RM " + baseFee.ToString("0.00");
        }
        private void KiraDanPaparHarga()
        {
            double totalHourly = selectedHours * hourlyRate;
            finalTotal = baseFee + totalHourly;

            labelTotalHR.Text = "RM " + totalHourly.ToString("0.00");
            labelOutputTotalPay.Text = finalTotal.ToString("0.00");

        }

        private void button1H_Click(object sender, EventArgs e)
        {
            selectedHours = 1;
            KiraDanPaparHarga();
        }

        private void button2H_Click(object sender, EventArgs e)
        {
            selectedHours = 2;
            KiraDanPaparHarga();
        }

        private void button3H_Click(object sender, EventArgs e)
        {
            selectedHours = 3;
            KiraDanPaparHarga();
        }

        private void button4H_Click(object sender, EventArgs e)
        {
            selectedHours = 4;
            KiraDanPaparHarga();
        }

        
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            if (selectedHours == 0)
            {
                MessageBox.Show("Please select or enter parking duration first!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double totalHourlyCharge = selectedHours * hourlyRate;
            string assignedSlot = "A-01"; // Simulasi peruntukan slot petak parking

            // SIMPAN DATA SEMENTARA (INSERT REKOD BARU)
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string query = "INSERT INTO ParkingSession (LicensePlate, SlotNumber, EntryTime, Duration, TotalPay, Status) " +
                               "VALUES (@plate, @slot, @entry, @duration, @total, 'Pending')";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@plate", licensePlate);
                    cmd.Parameters.AddWithValue("@slot", assignedSlot);
                    cmd.Parameters.AddWithValue("@entry", DateTime.Now);
                    cmd.Parameters.AddWithValue("@duration", selectedHours);
                    cmd.Parameters.AddWithValue("@total", finalTotal);

                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Database Error: " + ex.Message);
                        return;
                    }
                }
            }

            FormDriverPayment paymentForm = new FormDriverPayment(licensePlate, selectedHours, baseFee, totalHourlyCharge, finalTotal, assignedSlot);
            paymentForm.Show();
            this.Hide();
        }

    }
}
