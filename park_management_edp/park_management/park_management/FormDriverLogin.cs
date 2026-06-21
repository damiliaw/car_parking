using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            FormDriverLogin formDriverLogin = new FormDriverLogin();
            formDriverLogin.Show();
            this.Hide();
        }

        private void labelTItle_Click(object sender, EventArgs e)
        {

        }
    }
}
