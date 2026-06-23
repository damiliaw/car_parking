using park_management;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Data.SqlClient;

namespace Project_EDP
{
    public partial class FormDriverLogin : Form
    {
        SqlConnection con = new SqlConnection(
            @"Data Source=(LocalDB)\MSSQLLocalDB;
            AttachDbFilename=|DataDirectory|\CarParkDB.mdf;
            Integrated Security=True");

        public FormDriverLogin()
        {
            InitializeComponent();
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            string plate = textBoxPlateNumber.Text.Trim();

            if (string.IsNullOrEmpty(plate))
            {
                MessageBox.Show("Please enter your license plate number!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            bool plateExists = false;

            try
            {
                string query = "SELECT COUNT(*) FROM Vehicle WHERE License_Plate = @plate";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@plate", plate);

                con.Open();
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                con.Close();

                plateExists = count > 0;
            }
            catch (Exception ex)
            {
                if (con.State == ConnectionState.Open) con.Close();
                MessageBox.Show(ex.Message);
                return;
            }

            if (!plateExists)
            {
                MessageBox.Show("License plate not found. Please register your vehicle at the admin counter before proceeding.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            FormDriverDuration durationForm = new FormDriverDuration(plate);
            durationForm.Show();
            this.Hide();
        }

        private void buttonBackLanding_Click(object sender, EventArgs e)
        {
            FormDriverLogin LoginForm = new FormDriverLogin();
            LoginForm.Show();
            this.Hide();
        }

        private void labelTitle_Click(object sender, EventArgs e)
        {
        }

        private void FormDriverLogin_Load(object sender, EventArgs e)
        {
            textBoxPlateNumber.Focus();
        }
    }
}