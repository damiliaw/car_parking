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
    public partial class FormDriverPayment : Form
    {
        string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\CarParkDB.mdf;Integrated Security=True;";

        private string licensePlate;
        private int durationHours;
        private double baseFee;
        private double hourlyCharge;
        private double totalDue;
        private string slotNumber;
        private string chosenMethod = "Cash"; // Default method

        // CONSTRUCTOR SEPADAN: Menyambut tepat 6 data (Sama padan dengan penghantar)
        public FormDriverPayment(string plate, int hours, double bFee, double hCharge, double total, string slot)
        {
            InitializeComponent();
            this.licensePlate = plate;
            this.durationHours = hours;
            this.baseFee = bFee;
            this.hourlyCharge = hCharge;
            this.totalDue = total;
            this.slotNumber = slot;
        }
        private void FormDriverPayment_Load(object sender, EventArgs e)
        {
            labelOutputSlot.Text = slotNumber;
            labelDuration.Text = durationHours.ToString() + " Hours";
            labelOutputBF.Text = "RM " + baseFee.ToString("0.00");
            labelOutputHC.Text = "RM " + hourlyCharge.ToString("0.00");
            labelOutputTotalDue.Text = "RM " + totalDue.ToString("0.00");

            buttonPay.Text = "Pay RM " + totalDue.ToString("0.00");
        }
        public FormDriverPayment()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonCash_Click(object sender, EventArgs e)
        {
            chosenMethod = "Cash"; MessageBox.Show("Payment method set to Cash");
        }

        private void buttonCard_Click(object sender, EventArgs e)
        {
            chosenMethod = "Card"; MessageBox.Show("Payment method set to Card");
        }

        private void buttonOnline_Click(object sender, EventArgs e)
        {
            chosenMethod = "Online"; MessageBox.Show("Payment method set to Online");
        }

        private void buttonPay_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string query = "UPDATE ParkingSession SET Status = 'Paid', PaymentMethod = @method " +
                               "WHERE LicensePlate = @plate AND Status = 'Pending'";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@method", chosenMethod);
                    cmd.Parameters.AddWithValue("@plate", licensePlate);

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

            MessageBox.Show("Payment Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Buka skrin Sesi Aktif Pemandu
            FormDriverSession sessionForm = new FormDriverSession(licensePlate);
            sessionForm.Show();
            this.Hide();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            FormDriverDuration durationForm = new FormDriverDuration(licensePlate);
            durationForm.Show();
            this.Close();
        }
    }
}