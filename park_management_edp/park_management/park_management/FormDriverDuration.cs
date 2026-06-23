using Project_EDP;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace park_management
{
    public partial class FormDriverDuration : Form
    {
        private string currentVehicleID = "";
        private string currentVehicleType = "";
        private string currentLicensePlate = "";
        private string currentTransactionID = "";
        private string currentSlotID = "";
        private string currentSlotNumber = "";

        private decimal baseFee = 0;
        private decimal hourlyRate = 0;
        private int selectedHours = 1;

        private string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\CarParkDB.mdf;Integrated Security=True;";

        public FormDriverDuration(string licensePlate)
        {
            InitializeComponent();
            this.currentLicensePlate = licensePlate;
        }

        public FormDriverDuration()
        {
            InitializeComponent();
        }

        private void FormDriverDuration_Load(object sender, EventArgs e)
        {
            LoadVehicleAndRates();
            CalculateParkingFee();
        }

        private void LoadVehicleAndRates()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();

                    string vehicleQuery = "SELECT Vehicle_ID, Vehicle_Type FROM Vehicle WHERE License_Plate = @Plate";
                    using (SqlCommand cmd = new SqlCommand(vehicleQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@Plate", currentLicensePlate);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                currentVehicleID = reader["Vehicle_ID"].ToString();
                                currentVehicleType = reader["Vehicle_Type"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("Vehicle not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                    }

                    string rateQuery = "SELECT Base_Fee, Hourly_Rate FROM Rate WHERE Vehicle_Type = @Type";
                    using (SqlCommand cmd = new SqlCommand(rateQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@Type", currentVehicleType);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                baseFee = Convert.ToDecimal(reader["Base_Fee"]);
                                hourlyRate = Convert.ToDecimal(reader["Hourly_Rate"]);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading rates: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CalculateParkingFee()
        {
            decimal totalHourly = (selectedHours - 1) * hourlyRate;
            if (totalHourly < 0) totalHourly = 0;
            decimal totalToPay = baseFee + totalHourly;

            labelTotalFee.Text = "RM " + baseFee.ToString("0.00");
            labelTotalHR.Text = "RM " + totalHourly.ToString("0.00");
            labelOutputTotalPay.Text = totalToPay.ToString("0.00");
        }

        private void button1H_Click(object sender, EventArgs e) { selectedHours = 1; CalculateParkingFee(); }
        private void button2H_Click(object sender, EventArgs e) { selectedHours = 2; CalculateParkingFee(); }
        private void button3H_Click(object sender, EventArgs e) { selectedHours = 3; CalculateParkingFee(); }
        private void button4H_Click(object sender, EventArgs e) { selectedHours = 4; CalculateParkingFee(); }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();

                    // Jana Transaction ID baru
                    string maxIdQuery = "SELECT TOP 1 Transaction_ID FROM Parking_Transaction ORDER BY Transaction_ID DESC";
                    using (SqlCommand cmd = new SqlCommand(maxIdQuery, conn))
                    {
                        object result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            string lastId = result.ToString();
                            int lastNum = int.Parse(lastId.Replace("TX-", ""));
                            currentTransactionID = $"TX-{(lastNum + 1):D4}";
                        }
                        else
                        {
                            currentTransactionID = "TX-0001";
                        }
                    }

                    // Dapatkan Rate ID
                    string rateId = "";
                    using (SqlCommand cmd = new SqlCommand("SELECT Rate_ID FROM Rate WHERE Vehicle_Type = @Type", conn))
                    {
                        cmd.Parameters.AddWithValue("@Type", currentVehicleType);
                        object rIdResult = cmd.ExecuteScalar();
                        if (rIdResult != null) rateId = rIdResult.ToString();
                    }

                    // Dapatkan Slot Available
                    using (SqlCommand cmd = new SqlCommand("SELECT TOP 1 Slot_ID, Slot_Number FROM Parking_Slot WHERE Status = 'Available'", conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                currentSlotID = reader["Slot_ID"].ToString();
                                currentSlotNumber = reader["Slot_Number"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("No available parking slots!", "Full", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                        }
                    }

                    // Kira fee
                    decimal totalHourly = (selectedHours - 1) * hourlyRate;
                    if (totalHourly < 0) totalHourly = 0;
                    decimal totalFee = baseFee + totalHourly;

                    // Insert Transaction
                    string insertQuery = @"INSERT INTO Parking_Transaction 
    (Transaction_ID, Entry_Timestamp, Exit_Timestamp, Total_Fee, Slot_ID, Vehicle_ID, Rate_ID) 
    VALUES (@TxID, @Entry, NULL, @Fee, @SlotID, @VehID, @RateID)";

                    using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@TxID", currentTransactionID);
                        cmd.Parameters.AddWithValue("@Entry", DateTime.Now);
                        cmd.Parameters.AddWithValue("@Fee", totalFee);
                        cmd.Parameters.AddWithValue("@SlotID", currentSlotID);
                        cmd.Parameters.AddWithValue("@VehID", currentVehicleID);
                        cmd.Parameters.AddWithValue("@RateID", rateId);
                        cmd.ExecuteNonQuery();
                    }

                    // Update Slot jadi Occupied
                    using (SqlCommand cmd = new SqlCommand("UPDATE Parking_Slot SET Status = 'Occupied' WHERE Slot_ID = @SlotID", conn))
                    {
                        cmd.Parameters.AddWithValue("@SlotID", currentSlotID);
                        cmd.ExecuteNonQuery();
                    }
                }

                // Pergi ke Session — BUKAN Payment
                FormDriverSession sessionForm = new FormDriverSession(
                    currentLicensePlate,
                    currentTransactionID,
                    currentSlotNumber,
                    selectedHours,
                    Convert.ToDouble(baseFee),
                    Convert.ToDouble((selectedHours - 1) * hourlyRate < 0 ? 0 : (selectedHours - 1) * hourlyRate)
                );
                sessionForm.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Transaction Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormDriverLogin loginForm = new FormDriverLogin();
            loginForm.Show();
            this.Hide();
            //this.Hide(); 
        }

        private void textBoxHours_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxHours.Text, out int customHours) && customHours > 0)
            {
                selectedHours = customHours;
                CalculateParkingFee();
            }
        }
    }
}