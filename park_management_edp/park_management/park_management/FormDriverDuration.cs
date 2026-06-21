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
            // Ganti hardcodedConnString dengan laluan penuh PC kau
            string hardcodedConnString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\source\repos\carParkSystem\carParkSystem\CarParkDB.mdf;Integrated Security=True;";

            using (SqlConnection conn = new SqlConnection(hardcodedConnString))
            {
                // Query untuk cari harga berdasarkan jenis kenderaan yang didaftarkan oleh plat ini
                string query = "SELECT r.Base_Fee, r.Hourly_Rate FROM Vehicle v " +
                               "JOIN Rate r ON v.Vehicle_Type = r.Vehicle_Type " +
                               "WHERE v.License_Plate = @plate";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@plate", licensePlate);

                    try
                    {
                        conn.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            // Ambil nilai terus dari table Rate database kau!
                            baseFee = Convert.ToDouble(reader["Base_Fee"]);
                            hourlyRate = Convert.ToDouble(reader["Hourly_Rate"]);
                        }
                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error loading rates from database: " + ex.Message);
                    }
                }
            }

            // Papar harga asas yang ditarik dari DB tadi ke UI
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
                MessageBox.Show("Please select parking duration first!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string hardcodedConnString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\source\repos\carParkSystem\carParkSystem\CarParkDB.mdf;Integrated Security=True;";

            int vehicleId = 0;
            int rateId = 0;
            int slotId = 0;
            string slotNumber = "";

            using (SqlConnection conn = new SqlConnection(hardcodedConnString))
            {
                try
                {
                    conn.Open();

                    // A. Ambil Vehicle_ID & Rate_ID berdasarkan plat
                    string infoQuery = "SELECT v.Vehicle_ID, r.Rate_ID FROM Vehicle v " +
                                       "JOIN Rate r ON v.Vehicle_Type = r.Vehicle_Type " +
                                       "WHERE v.License_Plate = @plate";

                    using (SqlCommand cmd = new SqlCommand(infoQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@plate", licensePlate);
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            vehicleId = Convert.ToInt32(reader["Vehicle_ID"]);
                            rateId = Convert.ToInt32(reader["Rate_ID"]);
                        }
                        reader.Close();
                    }

                    // B. Cari Slot_ID yang kosong (Status = 'Available') dari table Parking_Slot
                    string slotQuery = "SELECT TOP 1 Slot_ID, Slot_Number FROM Parking_Slot WHERE Status = 'Available'";
                    using (SqlCommand cmd = new SqlCommand(slotQuery, conn))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            slotId = Convert.ToInt32(reader["Slot_ID"]);
                            slotNumber = reader["Slot_Number"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("Sorry, parking full!");
                            return;
                        }
                        reader.Close();
                    }

                    // C. Kira total harga muktamad
                    double totalHourlyCharge = selectedHours * hourlyRate;
                    finalTotal = baseFee + totalHourlyCharge;

                    // D. INSERT masuk ke table Parking_Transaction kau!
                    string insertTxQuery = "INSERT INTO Parking_Transaction (Entry_Timestamp, Total_Fee, Slot_ID, Vehicle_ID, Rate_ID) " +
                                           "VALUES (@entry, @total, @slotId, @vehicleId, @rateId); SELECT SCOPE_IDENTITY();";

                    int newTransactionId = 0;
                    using (SqlCommand cmd = new SqlCommand(insertTxQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@entry", DateTime.Now);
                        cmd.Parameters.AddWithValue("@total", finalTotal);
                        cmd.Parameters.AddWithValue("@slotId", slotId);
                        cmd.Parameters.AddWithValue("@vehicleId", vehicleId);
                        cmd.Parameters.AddWithValue("@rateId", rateId);

                        // Ambil ID Transaksi yang baru dicipta untuk dibawa ke skrin Payment nanti
                        newTransactionId = Convert.ToInt32(cmd.ExecuteScalar());
                    }

                    // E. UPDATE status slot tersebut jadi 'Occupied' (Dah diduduki) supaya orang lain takleh ambil
                    string updateSlotQuery = "UPDATE Parking_Slot SET Status = 'Occupied' WHERE Slot_ID = @slotId";
                    using (SqlCommand cmd = new SqlCommand(updateSlotQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@slotId", slotId);
                        cmd.ExecuteNonQuery();
                    }

                    // 3. BAWA DATA REAL-TIME KE FORM PAYMENT (Bawa Transaction_ID sekali)
                    // Kau boleh suaikan constructor FormDriverPayment kau untuk terima parameter ni
                    FormDriverPayment paymentForm = new FormDriverPayment(licensePlate, selectedHours, baseFee, totalHourlyCharge, finalTotal, slotNumber, newTransactionId);
                    paymentForm.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database Transaction Error: " + ex.Message);
                }
            }
        }

    }
}
