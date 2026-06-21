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
