using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resturant_management_system.Views
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void loginClearbutton_Click(object sender, EventArgs e)
        {
            loginUsernameTextBox.Text = string.Empty;
            loginPasswordTextBox.Text = string.Empty;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string uname = loginUsernameTextBox.Text;
            string pass = loginPasswordTextBox.Text;

            if (uname == "esoft" && pass == "123")
            {
                MessageBox.Show("Login Success !");
                Home home = new Home();
                home.Show();
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Login not Success !");
            }
        }

        private void loginExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
