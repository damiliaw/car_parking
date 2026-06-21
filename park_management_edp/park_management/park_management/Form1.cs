using park_management;
using Project_EDP;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CarParkManagementSystem
{
    public partial class Form1 : Form
    {

        string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\CarParkDB.mdf;Integrated Security=True;";
        public Form1()
        {
            InitializeComponent();
        }

        // Event handler untuk button Admin
        private void btnAdmin_Click(object sender, EventArgs e)
        {
            AdminPage adminForm = new AdminPage();
            adminForm.Show();
            this.Hide(); // sembunyikan form login
        }

        // Event handler untuk button Driver
        private void btnDriver_Click(object sender, EventArgs e)
        {
            FormDriverLogin LoginForm = new FormDriverLogin();
            LoginForm.Show();
            this.Hide();
        }

       
    }
}
