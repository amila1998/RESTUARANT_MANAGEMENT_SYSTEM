using MySql.Data.MySqlClient;
using RESTUARANT_MANAGEMENT_SYSTEM.Models;
using RESTUARANT_MANAGEMENT_SYSTEM.Utils;
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

namespace RESTUARANT_MANAGEMENT_SYSTEM
{
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
            LoadCustomerData();
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                CustomerModel newCustomer = new CustomerModel
                {
                    Customer_id = 0,
                    Customer_name = cusNameTextBox.Text,
                    Customer_date_of_birth = DateTime.Parse(birthdaytextbox.Text),
                    Customer_mobile_no = contactNoTextBox.Text,
                    Customer_address = addressTextBox.Text,
                    Customer_age = int.Parse(ageTextBox.Text)
                };

                newCustomer.Add_customer();
                MessageBox.Show("Customer added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Optionally, clear the text boxes after insertion
                cusIdTextBox.Clear();
                cusNameTextBox.Clear();
                birthdaytextbox.Clear();
                contactNoTextBox.Clear();
                addressTextBox.Clear();
                ageTextBox.Clear();
                button2.Enabled = true;
                loginBtn.Enabled = false;
                button1.Enabled = false;
                this.LoadCustomerData();
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Invalid input format. Please check your input values.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                CustomerModel updatedCustomer = new CustomerModel
                {
                    Customer_id = int.Parse(cusIdTextBox.Text),
                    Customer_name = cusNameTextBox.Text,
                    Customer_date_of_birth = DateTime.Parse(birthdaytextbox.Text),
                    Customer_mobile_no = contactNoTextBox.Text,
                    Customer_address = addressTextBox.Text,
                    Customer_age = int.Parse(ageTextBox.Text)
                };

                updatedCustomer.Update_customer();
                MessageBox.Show("Customer updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Optionally, clear the text boxes after update
                // Optionally, clear the text boxes after insertion
                cusIdTextBox.Clear();
                cusNameTextBox.Clear();
                birthdaytextbox.Clear();
                contactNoTextBox.Clear();
                addressTextBox.Clear();
                ageTextBox.Clear();
                this.LoadCustomerData();
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Invalid input format. Please check your input values.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void LoadCustomerData()
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(DatabaseConfig.ConnectionString))
                {
                    con.Open();
                    string query = "SELECT Customer_id, Customer_name, Customer_date_of_birth, Customer_mobile_no, Customer_address, Customer_age FROM customers";
                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable customerTable = new DataTable();
                            adapter.Fill(customerTable);
                            dataGridViewCustomers.DataSource = customerTable;
                            button2.Enabled = true;
                            loginBtn.Enabled = false;
                            button1.Enabled = false;
                        }
                    }
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

        // Handle the FormClosing event
        private void Customer_FormClosing(object sender, FormClosingEventArgs e)
        {
            Home home = new Home();
            home.Show();
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            this.FormClosing += new FormClosingEventHandler(Customer_FormClosing);
            dataGridViewCustomers.CellClick += new DataGridViewCellEventHandler(dataGridViewCustomers_CellClick);
        }

        private void contactNoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Ensure the click is on a valid row
            {
                DataGridViewRow row = dataGridViewCustomers.Rows[e.RowIndex];

                // Display the data in the text boxes
                cusIdTextBox.Text = row.Cells["Customer_id"].Value.ToString();
                cusNameTextBox.Text = row.Cells["Customer_name"].Value.ToString();
                birthdaytextbox.Text = row.Cells["Customer_date_of_birth"].Value.ToString();
                contactNoTextBox.Text = row.Cells["Customer_mobile_no"].Value.ToString();
                addressTextBox.Text = row.Cells["Customer_address"].Value.ToString();
                ageTextBox.Text = row.Cells["Customer_age"].Value.ToString();
                button2.Enabled = false;
                loginBtn.Enabled = true;
                button1.Enabled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cusIdTextBox.Text = null;
            cusNameTextBox.Text = null;
            birthdaytextbox.Text = null;
            contactNoTextBox.Text = null;
            addressTextBox.Text = null;
            ageTextBox.Text = null;
            button2.Enabled = true;
            loginBtn.Enabled = false;
            button1.Enabled = false;
            this.LoadCustomerData();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            try
            {
                CustomerModel customerToDelete = new CustomerModel
                {
                    Customer_id = int.Parse(cusIdTextBox.Text)
                };

                customerToDelete.Delete_customer();
                MessageBox.Show("Customer deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Optionally, clear the text boxes after deletion
                cusIdTextBox.Clear();
                cusNameTextBox.Clear();
                birthdaytextbox.Clear();
                contactNoTextBox.Clear();
                addressTextBox.Clear();
                ageTextBox.Clear();
                button2.Enabled = true;
                loginBtn.Enabled = false;
                button1.Enabled = false;
                this.LoadCustomerData();
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Invalid input format. Please check your input values.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
