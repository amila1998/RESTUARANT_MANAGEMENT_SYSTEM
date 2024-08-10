using MySql.Data.MySqlClient;
using Resturant_management_system.Utils;
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

namespace Resturant_management_system.Views
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            InitializeDatabase();
        }

        private void InitializeDatabase()
        {
            string createEmployeeTable = @"
                CREATE TABLE IF NOT EXISTS employees (
                    Id INT AUTO_INCREMENT PRIMARY KEY,
                    EmployeeNo VARCHAR(50) NOT NULL,
                    FirstName VARCHAR(255) NOT NULL,
                    LastName VARCHAR(255) NOT NULL,
                    DateOfBirth DATE NOT NULL,
                    Gender VARCHAR(10) NOT NULL,
                    Address VARCHAR(255) NOT NULL,
                    Email VARCHAR(255) NOT NULL,
                    MobilePhoneNo VARCHAR(20) NOT NULL,
                    HomePhoneNo VARCHAR(20),
                    Role VARCHAR(255) NOT NULL
                );
            ";

            try
            {
                using (MySqlConnection con = new MySqlConnection(DatabaseConfig.ConnectionString))
                {
                    con.Open();

                    // Execute the create table commands for all tables
                    ExecuteNonQuery(con, createEmployeeTable);

                    con.Close();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"MySQL Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ExecuteNonQuery(MySqlConnection con, string query)
        {
            using (MySqlCommand cmd = new MySqlCommand(query, con))
            {
                cmd.ExecuteNonQuery();
            }
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
                MessageBox.Show("You are successfully login", "Login Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Hide the Login form
                this.Hide();

                // Open the Home form
                Home home = new Home();
                home.FormClosed += (s, args) => this.Show(); // Re-show the Login form when Home is closed
                home.Show();
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void loginExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
