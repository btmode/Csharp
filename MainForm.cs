using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DbCRUD
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Register_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var login = new Login();

            this.Show();
            login.Show();

        }

        private void SignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var signUp = new SignUpForm();
            signUp.Show();
            this.Hide();
        }
    }
}
