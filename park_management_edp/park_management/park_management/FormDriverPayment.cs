using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace park_management
{
    public partial class FormDriverPayment : Form
    {
        private string licensePlate;
        private int durationHours;
        private double baseFee;
        private double hourlyCharge;
        private double totalDue;
        private string slotNumber;
        private string transactionId;
        private string selectedMethod = "Cash";

        private string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\CarParkDB.mdf;Integrated Security=True;";

        public FormDriverPayment(string plate, int hours, double bFee, double hCharge, double total, string slot, string txnId)
        {
            InitializeComponent();
            this.licensePlate = plate;
            this.durationHours = hours;
            this.baseFee = bFee;
            this.hourlyCharge = hCharge;
            this.totalDue = total;
            this.slotNumber = slot;
            this.transactionId = txnId;
        }

        public FormDriverPayment()
        {
            InitializeComponent();
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

        // Pilih method — tunjuk message je
        private void buttonCash_Click(object sender, EventArgs e)
        {
            selectedMethod = "Cash";
            MessageBox.Show("Payment set to Cash!", "Payment Method", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonCard_Click(object sender, EventArgs e)
        {
            selectedMethod = "Card";
            MessageBox.Show("Payment set to Card!", "Payment Method", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonOnline_Click(object sender, EventArgs e)
        {
            selectedMethod = "Online";
            MessageBox.Show("Payment set to Online!", "Payment Method", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Urusan bank — tak buat apa
        private void buttonPay_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Payment done! Please proceed to view your receipt.", "Payment Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Receipt — update DB dan show receipt
        private void buttonReceipt_Click(object sender, EventArgs e)
        {
            try
            {
                string vehicleType = "";
                string colorModel = "";
                DateTime entryTime = DateTime.Now;
                DateTime exitTimeNow = entryTime.AddHours(durationHours);
                string newPaymentID = "PY-001";

                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();

                    // Jana Payment ID
                    using (SqlCommand cmd = new SqlCommand("SELECT TOP 1 Payment_ID FROM Payment ORDER BY Payment_ID DESC", conn))
                    {
                        object result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            string lastId = result.ToString();
                            int lastNum = int.Parse(lastId.Replace("PY-", ""));
                            newPaymentID = $"PY-{(lastNum + 1):D3}";
                        }
                    }

                    // Insert Payment
                    using (SqlCommand cmd = new SqlCommand(
                        @"INSERT INTO Payment (Payment_ID, Payment_Method, Payment_Status, Amount_Paid, Transaction_ID) 
                          VALUES (@PayID, @Method, 'Paid', @Amount, @TxID)", conn))
                    {
                        cmd.Parameters.AddWithValue("@PayID", newPaymentID);
                        cmd.Parameters.AddWithValue("@Method", selectedMethod);
                        cmd.Parameters.AddWithValue("@Amount", totalDue);
                        cmd.Parameters.AddWithValue("@TxID", transactionId);
                        cmd.ExecuteNonQuery();
                    }

                    // Update Exit Timestamp
                    using (SqlCommand cmd = new SqlCommand(
                        "UPDATE Parking_Transaction SET Exit_Timestamp = @Exit WHERE Transaction_ID = @TxID", conn))
                    {
                        cmd.Parameters.AddWithValue("@Exit", exitTimeNow);
                        cmd.Parameters.AddWithValue("@TxID", transactionId);
                        cmd.ExecuteNonQuery();
                    }

                    // Free slot
                    using (SqlCommand cmd = new SqlCommand(
                        "UPDATE Parking_Slot SET Status = 'Available' WHERE Slot_Number = @SlotNum", conn))
                    {
                        cmd.Parameters.AddWithValue("@SlotNum", slotNumber);
                        cmd.ExecuteNonQuery();
                    }

                    // Ambil Vehicle Type & Color/Model dari table Vehicle
                    using (SqlCommand cmd = new SqlCommand(
                        "SELECT Vehicle_Type, Color_Model FROM Vehicle WHERE License_Plate = @plate", conn))
                    {
                        cmd.Parameters.AddWithValue("@plate", licensePlate);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                vehicleType = reader["Vehicle_Type"].ToString();
                                colorModel = reader["Color_Model"].ToString();
                            }
                        }
                    }

                    // Ambil Entry Timestamp dari table Parking_Transaction
                    using (SqlCommand cmd = new SqlCommand(
                        "SELECT Entry_Timestamp FROM Parking_Transaction WHERE Transaction_ID = @TxID", conn))
                    {
                        cmd.Parameters.AddWithValue("@TxID", transactionId);
                        object result = cmd.ExecuteScalar();
                        if (result != null)
                            entryTime = Convert.ToDateTime(result);
                    }
                }

                // Tunjuk receipt - bukak Receipt form (bukan MessageBox lagi)
                Receipt receiptForm = new Receipt(
                    transactionId, newPaymentID, licensePlate,
                    vehicleType, colorModel, slotNumber,
                    entryTime, exitTimeNow, durationHours,
                    baseFee, hourlyCharge, totalDue, selectedMethod);
                receiptForm.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            FormDriverSession sessionForm = new FormDriverSession(
                licensePlate, transactionId, slotNumber, durationHours, baseFee, hourlyCharge);
            sessionForm.Show();
            this.Hide();
        }
    }
}