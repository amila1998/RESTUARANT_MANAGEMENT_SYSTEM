using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using Resturant_management_system.Models;
using Resturant_management_system.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Mysqlx.Expect.Open.Types.Condition.Types;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Resturant_management_system.Views
{
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
            LoadEmployeeData();
        }

        private EmployeeModel employeeObject = new EmployeeModel();

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LoadEmployeeData()
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(DatabaseConfig.ConnectionString))
                {
                    con.Open();
                    string query = "SELECT * FROM employees";
                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable employeeTable = new DataTable();
                            adapter.Fill(employeeTable);
                            dataGridView1.DataSource = employeeTable;

                            insertButton.Enabled = true;
                            updatebutton.Enabled = false;
                            deleteButton.Enabled = false;
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

        private void Employee_Load(object sender, EventArgs e)
        {
            dataGridView1.CellClick += new DataGridViewCellEventHandler(dataGridView1_CellClick);


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Ensure the click is on a valid row
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Display the data in the text boxes
                empNotextBox.Text = row.Cells["EmployeeNo"].Value.ToString();
                empfirstNameTextBox.Text = row.Cells["FirstName"].Value.ToString();
                empLastNameTextBox.Text = row.Cells["LastName"].Value.ToString();
                empDOBPicker.Text = row.Cells["DateOfBirth"].Value.ToString();

                if (row.Cells["Gender"].Value.ToString().Equals("Male"))
                {
                    maleRadioButton.Checked = true;
                    femaleRadioButton.Checked = false;
                }else if(row.Cells["Gender"].Value.ToString().Equals("Female"))
                {
                    maleRadioButton.Checked = false;
                    femaleRadioButton.Checked = true;
                }

                empAddressTextBox.Text = row.Cells["Address"].Value.ToString();
                empEmailTextBox.Text = row.Cells["Email"].Value.ToString();
                mobilePhoneTextBox.Text = row.Cells["MobilePhoneNo"].Value.ToString();
                homePhoneTextBox.Text = row.Cells["HomePhoneNo"].Value.ToString();
                comboBox1.Text = row.Cells["Role"].Value.ToString();

                // Assign attributes to the employeeObject
                employeeObject.Id = Convert.ToInt32(row.Cells["Id"].Value);
                employeeObject.EmployeeNo = row.Cells["EmployeeNo"].Value.ToString();
                employeeObject.FirstName = row.Cells["FirstName"].Value.ToString();
                employeeObject.LastName = row.Cells["LastName"].Value.ToString();
                employeeObject.DateOfBirth = Convert.ToDateTime(row.Cells["DateOfBirth"].Value);
                employeeObject.Gender = row.Cells["Gender"].Value.ToString();
                employeeObject.Address = row.Cells["Address"].Value.ToString();
                employeeObject.Email = row.Cells["Email"].Value.ToString();
                employeeObject.MobilePhoneNo = row.Cells["MobilePhoneNo"].Value.ToString();
                employeeObject.HomePhoneNo = row.Cells["HomePhoneNo"].Value.ToString();
                employeeObject.Role = row.Cells["Role"].Value.ToString();

                insertButton.Enabled = false;
                updatebutton.Enabled = true;
                deleteButton.Enabled = true;
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            empNotextBox.Text = string.Empty;
            empfirstNameTextBox.Text = string.Empty;
            empLastNameTextBox.Text = string.Empty;
            empDOBPicker.Text = string.Empty;
            maleRadioButton.Checked = false;
            femaleRadioButton.Checked = false;
            empAddressTextBox.Text = string.Empty;
            empEmailTextBox.Text = string.Empty;
            mobilePhoneTextBox.Text = string.Empty;
            homePhoneTextBox.Text = string.Empty;
            comboBox1.Text = string.Empty;


            insertButton.Enabled = true;
            updatebutton.Enabled = false;
            deleteButton.Enabled = false;
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            try
            {
                string empGender = "";




                if (maleRadioButton.Checked)
                {
                    empGender = "Male";
                }else if (femaleRadioButton.Checked)
                {
                    empGender = "Female";
                }

                EmployeeModel newEmp = new EmployeeModel
                {
                    Id = 0,
                    EmployeeNo = empNotextBox.Text,
                    FirstName = empfirstNameTextBox.Text,
                    LastName = empLastNameTextBox.Text,
                    DateOfBirth = DateTime.Parse(empDOBPicker.Text),
                    Gender = empGender,
                    Address = empAddressTextBox.Text,
                    Email = empEmailTextBox.Text,
                    MobilePhoneNo = mobilePhoneTextBox.Text,
                    HomePhoneNo = homePhoneTextBox.Text,
                    Role = comboBox1.Text

                };

                newEmp.Add_employee();
                MessageBox.Show("Employee added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                empNotextBox.Text = string.Empty;
                empfirstNameTextBox.Text = string.Empty;
                empLastNameTextBox.Text = string.Empty;
                empDOBPicker.Text = string.Empty;
                maleRadioButton.Checked = false;
                femaleRadioButton.Checked = false;
                empAddressTextBox.Text = string.Empty;
                empEmailTextBox.Text = string.Empty;
                mobilePhoneTextBox.Text = string.Empty;
                homePhoneTextBox.Text = string.Empty;
                comboBox1.Text = string.Empty;


                insertButton.Enabled = true;
                updatebutton.Enabled = false;
                deleteButton.Enabled = false;
                this.LoadEmployeeData();
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

        private void updatebutton_Click(object sender, EventArgs e)
        {
            try
            {
                string empGender = "";

                if (maleRadioButton.Checked)
                {
                    empGender = "Male";
                }
                else if (femaleRadioButton.Checked)
                {
                    empGender = "Female";
                }

                    employeeObject.EmployeeNo = empNotextBox.Text;
                    employeeObject.FirstName = empfirstNameTextBox.Text;
                    employeeObject.LastName = empLastNameTextBox.Text;
                    employeeObject.DateOfBirth = DateTime.Parse(empDOBPicker.Text);
                    employeeObject.Gender = empGender;
                    employeeObject.Address = empAddressTextBox.Text;
                    employeeObject.Email = empEmailTextBox.Text;
                    employeeObject.MobilePhoneNo = mobilePhoneTextBox.Text;
                    employeeObject.HomePhoneNo = homePhoneTextBox.Text;
                    employeeObject.Role = comboBox1.Text;


                employeeObject.Update_employee();
                MessageBox.Show("Employee updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                empNotextBox.Text = string.Empty;
                empfirstNameTextBox.Text = string.Empty;
                empLastNameTextBox.Text = string.Empty;
                empDOBPicker.Text = string.Empty;
                maleRadioButton.Checked = false;
                femaleRadioButton.Checked = false;
                empAddressTextBox.Text = string.Empty;
                empEmailTextBox.Text = string.Empty;
                mobilePhoneTextBox.Text = string.Empty;
                homePhoneTextBox.Text = string.Empty;
                comboBox1.Text = string.Empty;


                insertButton.Enabled = true;
                updatebutton.Enabled = false;
                deleteButton.Enabled = false;
                this.LoadEmployeeData();
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

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {

                employeeObject.Delete_employee();
                MessageBox.Show("Employee deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Optionally, clear the text boxes after deletion
                empNotextBox.Text = string.Empty;
                empfirstNameTextBox.Text = string.Empty;
                empLastNameTextBox.Text = string.Empty;
                empDOBPicker.Text = string.Empty;
                maleRadioButton.Checked = false;
                femaleRadioButton.Checked = false;
                empAddressTextBox.Text = string.Empty;
                empEmailTextBox.Text = string.Empty;
                mobilePhoneTextBox.Text = string.Empty;
                homePhoneTextBox.Text = string.Empty;
                comboBox1.Text = string.Empty;
                insertButton.Enabled = true;
                updatebutton.Enabled = false;
                deleteButton.Enabled = false;
                this.LoadEmployeeData();
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
