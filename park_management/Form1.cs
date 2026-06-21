using park_management;
using System;
using System.Windows.Forms;

namespace CarParkManagementSystem
{
    public partial class Form1 : Form
    {
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
            
            //driverForm.Show();
            this.Hide(); // sembunyikan form login
        }

       
    }
}
