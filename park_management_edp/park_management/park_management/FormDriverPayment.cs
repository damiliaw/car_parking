using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace park_management
{
    public partial class FormDriverPayment : Form
    {
        // 1. Alamat pautan database MDF laluan penuh PC kau
        string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\source\repos\carParkSystem\carParkSystem\CarParkDB.mdf;Integrated Security=True;";

        // 2. Isytihar Variable Global
        private string licensePlate;
        private int durationHours;
        private double baseFee;
        private double hourlyCharge;
        private double totalDue;
        private string slotNumber;
        private int transactionId;
        private string chosenMethod = "Cash"; // Default method jika user tak tekan butang lain

        // CONSTRUCTOR UTAMA: Menyambut 7 data tepat dari Form Duration
        public FormDriverPayment(string plate, int hours, double bFee, double hCharge, double total, string slot, int txnId)
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

        // Constructor kosong backup (jangan buang)
        public FormDriverPayment()
        {
            InitializeComponent();
        }

        // 3. Memaparkan maklumat data real-time pada Label UI semasa skrin dibuka
        private void FormDriverPayment_Load(object sender, EventArgs e)
        {
            // Sila sesuaikan nama label bawah ni dengan nama label pada Design kau!
            labelOutputSlot.Text = slotNumber;
            labelDuration.Text = durationHours.ToString() + " Hours";
            labelOutputBF.Text = "RM " + baseFee.ToString("0.00");
            labelOutputHC.Text = "RM " + hourlyCharge.ToString("0.00");
            labelOutputTotalDue.Text = "RM " + totalDue.ToString("0.00");

            buttonPay.Text = "Pay RM " + totalDue.ToString("0.00");
        }

        // 4. Event Handler untuk Pilihan Cara Pembayaran
        private void buttonCash_Click(object sender, EventArgs e)
        {
            chosenMethod = "Cash";
            MessageBox.Show("Payment method set to Cash", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonCard_Click(object sender, EventArgs e)
        {
            chosenMethod = "Card";
            MessageBox.Show("Payment method set to Card", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonOnline_Click(object sender, EventArgs e)
        {
            chosenMethod = "Online";
            MessageBox.Show("Payment method set to Online", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // 5. BUTANG PROSES BAYAR (Klik Sahkan Pembayaran)
        private void buttonPay_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    conn.Open();

                    // MASALAH REKOD: A. Masukkan rekod baru dalam table Payment kau
                    // (Suaikan nama column: Payment_Method, Amount, Payment_Timestamp, Transaction_ID ikut DB kau)
                    string insertPaymentQuery = "INSERT INTO Payment (Payment_Method, Amount, Payment_Timestamp, Transaction_ID) " +
                                                "VALUES (@method, @amount, @timestamp, @txnId)";

                    using (SqlCommand paymentCmd = new SqlCommand(insertPaymentQuery, conn))
                    {
                        paymentCmd.Parameters.AddWithValue("@method", chosenMethod);
                        paymentCmd.Parameters.AddWithValue("@amount", totalDue);
                        paymentCmd.Parameters.AddWithValue("@timestamp", DateTime.Now);
                        paymentCmd.Parameters.AddWithValue("@txnId", transactionId);

                        paymentCmd.ExecuteNonQuery();
                    }

                    // MASALAH UPDATE: B. Tukar status dalam table Parking_Transaction kepada 'Paid'
                    // (Suaikan nama column status kalau kau guna nama lain contoh 'Status_Payment')
                    string updateTxQuery = "UPDATE Parking_Transaction SET Status = 'Paid' WHERE Transaction_ID = @txnId";

                    using (SqlCommand updateCmd = new SqlCommand(updateTxQuery, conn))
                    {
                        updateCmd.Parameters.AddWithValue("@txnId", transactionId);
                        updateCmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Payment Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // C. Lepas settle bayar, hantar pemandu ke skrin Sesi Aktif (FormDriverSession)
                    FormDriverSession sessionForm = new FormDriverSession(licensePlate);
                    sessionForm.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database Error during payment: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // 6. Butang Back (Kalau user nak tukar duration balik)
        private void buttonBack_Click(object sender, EventArgs e)
        {
            FormDriverDuration durationForm = new FormDriverDuration(licensePlate);
            durationForm.Show();
            this.Close();
        }
    }
}