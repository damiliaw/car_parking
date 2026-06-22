using Project_EDP;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace park_management
{
    public partial class FormDriverSession : Form
    {
        private string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\CarParkDB.mdf;Integrated Security=True;";

        private string activePlate;
        private string activeTransactionID;
        private string activeSlotNumber;
        private int activeDurationHours;
        private double activeBaseFee;
        private double activeHourlyCharge;

        public FormDriverSession(string plate, string txnId, string slotNum, int hours, double bFee, double hCharge)
        {
            InitializeComponent();
            this.activePlate = plate;
            this.activeTransactionID = txnId;
            this.activeSlotNumber = slotNum;
            this.activeDurationHours = hours;
            this.activeBaseFee = bFee;
            this.activeHourlyCharge = hCharge;
        }

        public FormDriverSession()
        {
            InitializeComponent();
        }

        private void FormDriverSession_Load(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();

                    string query = @"SELECT pt.Transaction_ID, pt.Entry_Timestamp, pt.Total_Fee,
                                           s.Slot_Number, v.License_Plate, v.Color_Model
                                    FROM Parking_Transaction pt
                                    JOIN Parking_Slot s ON pt.Slot_ID = s.Slot_ID
                                    JOIN Vehicle v ON pt.Vehicle_ID = v.Vehicle_ID
                                    WHERE pt.Transaction_ID = @TxID";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@TxID", activeTransactionID);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                DateTime entryTime = Convert.ToDateTime(reader["Entry_Timestamp"]);
                                DateTime dueTime = entryTime.AddHours(activeDurationHours);

                                // Header info
                                labelNoPlate.Text = reader["License_Plate"].ToString();
                                labelColorModel.Text = reader["Color_Model"].ToString();

                                // Slot / Parked / Due bar
                                labelSlot.Text = reader["Slot_Number"].ToString();
                                labelParked.Text = entryTime.ToString("hh:mm tt");
                                labelDue.Text = dueTime.ToString("hh:mm tt");

                                // Detail bawah
                                labelTransactionOutput.Text = reader["Transaction_ID"].ToString();
                                labelEntryTImeOutput.Text = entryTime.ToString("dd/MM/yyyy hh:mm tt");
                                labelDurationChosenOutput.Text = activeDurationHours.ToString() + " Hour(s)";
                                labelRateOutput.Text = "RM " + Convert.ToDouble(reader["Total_Fee"]).ToString("0.00");
                                labelStatusOuput.Text = "Active";
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Butang Pay Now → pergi Payment
        private void buttonPayNow_Click(object sender, EventArgs e)
        {
            double totalDue = activeBaseFee + activeHourlyCharge;

            FormDriverPayment paymentForm = new FormDriverPayment(
                activePlate,
                activeDurationHours,
                activeBaseFee,
                activeHourlyCharge,
                totalDue,
                activeSlotNumber,
                activeTransactionID
            );
            paymentForm.Show();
            this.Hide();
        }

        // Butang Change Duration → balik ke Duration
        private void buttonChangeDuration_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(
                        "UPDATE Parking_Slot SET Status = 'Available' WHERE Slot_Number = @SlotNum", conn))
                    {
                        cmd.Parameters.AddWithValue("@SlotNum", activeSlotNumber);
                        cmd.ExecuteNonQuery();
                    }

                    using (SqlCommand cmd = new SqlCommand(
                        "DELETE FROM Parking_Transaction WHERE Transaction_ID = @TxID", conn))
                    {
                        cmd.Parameters.AddWithValue("@TxID", activeTransactionID);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error resetting session: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            FormDriverDuration durationForm = new FormDriverDuration(activePlate);
            durationForm.Show();
            this.Hide();
        }

        // Butang Exit
        private void buttonExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you! Have a safe drive.", "Goodbye", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Exit();
        }

        // Stub untuk elak error designer
        private void labelNoPlate_Click(object sender, EventArgs e) { }
        private void button1_Click(object sender, EventArgs e) {
            FormDriverDuration loginForm = new FormDriverDuration(activePlate);
            loginForm.Show();
            this.Hide();
        }
        private void label1_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(
                        "UPDATE Parking_Slot SET Status = 'Available' WHERE Slot_Number = @SlotNum", conn))
                    {
                        cmd.Parameters.AddWithValue("@SlotNum", activeSlotNumber);
                        cmd.ExecuteNonQuery();
                    }

                    using (SqlCommand cmd = new SqlCommand(
                        "DELETE FROM Parking_Transaction WHERE Transaction_ID = @TxID", conn))
                    {
                        cmd.Parameters.AddWithValue("@TxID", activeTransactionID);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error resetting session: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        private void labelPlate_Click(object sender, EventArgs e) { }

        private void button2_Click(object sender, EventArgs e)
        {
            double totalDue = activeBaseFee + activeHourlyCharge;

            FormDriverPayment paymentForm = new FormDriverPayment(
                activePlate,
                activeDurationHours,
                activeBaseFee,
                activeHourlyCharge,
                totalDue,
                activeSlotNumber,
                activeTransactionID
            );
            paymentForm.Show();
            this.Hide();
        }

        private void buttonExit_Click_1(object sender, EventArgs e)
        {
            FormDriverDuration LoginForm = new FormDriverDuration();
            LoginForm.Show();
            this.Hide();
        }
    }
}