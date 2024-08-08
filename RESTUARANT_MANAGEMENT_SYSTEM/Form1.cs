using MySql.Data.MySqlClient;
using RESTUARANT_MANAGEMENT_SYSTEM.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RESTUARANT_MANAGEMENT_SYSTEM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeDatabase();
        }

        private void InitializeDatabase()
        {
            string createCustomerTable = @"
                CREATE TABLE IF NOT EXISTS customers (
                    Customer_id INT AUTO_INCREMENT PRIMARY KEY,
                    Customer_name VARCHAR(255) NOT NULL,
                    Customer_date_of_birth DATE,
                    Customer_mobile_no VARCHAR(20),
                    Customer_address VARCHAR(255),
                    Customer_age INT
                );";

            string createMenuTable = @"
                CREATE TABLE IF NOT EXISTS menus (
                    Menu_id INT AUTO_INCREMENT PRIMARY KEY,
                    Menu_foods VARCHAR(255),
                    Menu_beverages VARCHAR(255),
                    Menu_desserts VARCHAR(255)
                );";

            string createEmployeeTable = @"
                CREATE TABLE IF NOT EXISTS employees (
                    Employee_id INT AUTO_INCREMENT PRIMARY KEY,
                    Employee_name VARCHAR(255),
                    Employee_address VARCHAR(255),
                    Employee_tel VARCHAR(20),
                    Employee_job_description VARCHAR(255)
                );";

            string createBillTable = @"
                CREATE TABLE IF NOT EXISTS bills (
                    Bill_id INT AUTO_INCREMENT PRIMARY KEY,
                    Bill_payment_method VARCHAR(255),
                    Bill_payment_no VARCHAR(255),
                    Bill_payment_date DATE
                );";

            try
            {
                using (MySqlConnection con = new MySqlConnection(DatabaseConfig.ConnectionString))
                {
                    con.Open();

                    // Execute the create table commands for all tables
                    ExecuteNonQuery(con, createCustomerTable);
                    ExecuteNonQuery(con, createMenuTable);
                    ExecuteNonQuery(con, createEmployeeTable);
                    ExecuteNonQuery(con, createBillTable);

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

        private void button1_Click(object sender, EventArgs e)
        {
            string uname = UserNameTextBox.Text;
            string pass = passwordTextBox.Text;

            if (uname == "esoft" && pass == "123")
            {
                MessageBox.Show("Login Success !");
                Home obj = new Home();
                obj.Show();
            }
            else
            {
                MessageBox.Show("Login not Success !");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
             UserNameTextBox.Text = null;
             passwordTextBox.Text = null;
            MessageBox.Show("Logout Success !");
        }
    }
}
