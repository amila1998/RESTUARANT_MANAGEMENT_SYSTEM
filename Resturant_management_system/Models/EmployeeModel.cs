using MySql.Data.MySqlClient;
using Resturant_management_system.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resturant_management_system.Models
{
    public class EmployeeModel
    {
        public int Id { get; set; }
        public string EmployeeNo { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string MobilePhoneNo { get; set; }
        public string HomePhoneNo { get; set; }
        public string Role { get; set; }



        public void Add_employee()
        {
            using (MySqlConnection con = new MySqlConnection(DatabaseConfig.ConnectionString))
            {
                con.Open();
                string query = "INSERT INTO employees (EmployeeNo, FirstName, LastName, DateOfBirth, Gender, Address, Email, MobilePhoneNo, HomePhoneNo, Role) VALUES (@empNo, @fName, @lName, @dob, @gender, @address, @email, @mNo, @hNo, @role)";
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@empNo", EmployeeNo);
                    cmd.Parameters.AddWithValue("@fName", FirstName);
                    cmd.Parameters.AddWithValue("@lName", LastName);
                    cmd.Parameters.AddWithValue("@dob", DateOfBirth);
                    cmd.Parameters.AddWithValue("@gender", Gender);
                    cmd.Parameters.AddWithValue("@address", Address);
                    cmd.Parameters.AddWithValue("@email", Email);
                    cmd.Parameters.AddWithValue("@mNo", MobilePhoneNo);
                    cmd.Parameters.AddWithValue("@hNo", HomePhoneNo);
                    cmd.Parameters.AddWithValue("@role", Role);

                    cmd.ExecuteNonQuery();
                }
                con.Close();
            }
        }

        public void Delete_employee()
        {
            using (MySqlConnection con = new MySqlConnection(DatabaseConfig.ConnectionString))
            {
                con.Open();
                string query = "DELETE FROM employees WHERE Id = @id";
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@id", Id);
                    cmd.ExecuteNonQuery();
                }
                con.Close();
            }
        }

        public void Update_employee()
        {
            using (MySqlConnection con = new MySqlConnection(DatabaseConfig.ConnectionString))
            {
                con.Open();
                string query = "UPDATE employees SET EmployeeNo = @empNo, FirstName = @fName, LastName = @lName, DateOfBirth = @dob, Gender = @gender, Address = @address, Email = @email, MobilePhoneNo = @mNo, HomePhoneNo = @hNo, Role = @role WHERE Id = @id";
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    
                    cmd.Parameters.AddWithValue("@id", Id);
                    cmd.Parameters.AddWithValue("@empNo", EmployeeNo);
                    cmd.Parameters.AddWithValue("@fName", FirstName);
                    cmd.Parameters.AddWithValue("@lName", LastName);
                    cmd.Parameters.AddWithValue("@dob", DateOfBirth);
                    cmd.Parameters.AddWithValue("@gender", Gender);
                    cmd.Parameters.AddWithValue("@address", Address);
                    cmd.Parameters.AddWithValue("@email", Email);
                    cmd.Parameters.AddWithValue("@mNo", MobilePhoneNo);
                    cmd.Parameters.AddWithValue("@hNo", HomePhoneNo);
                    cmd.Parameters.AddWithValue("@role", Role);

                    cmd.ExecuteNonQuery();
                }
                con.Close();
            }
        }
    }
}
