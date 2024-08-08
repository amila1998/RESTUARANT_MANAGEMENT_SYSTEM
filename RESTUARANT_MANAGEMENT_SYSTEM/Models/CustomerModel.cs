using MySql.Data.MySqlClient;
using RESTUARANT_MANAGEMENT_SYSTEM.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RESTUARANT_MANAGEMENT_SYSTEM.Models
{
    public class CustomerModel
    {
        public string Customer_name { get; set; }
        public int Customer_id { get; set; }
        public DateTime Customer_date_of_birth { get; set; }
        public string Customer_mobile_no { get; set; }
        public string Customer_address { get; set; }
        public int Customer_age { get; set; }

        public void Add_customer()
        {
            using (MySqlConnection con = new MySqlConnection(DatabaseConfig.ConnectionString))
            {
                con.Open();
                string query = "INSERT INTO customers (Customer_name, Customer_date_of_birth, Customer_mobile_no, Customer_address, Customer_age) VALUES (@name, @dob, @mobile, @address, @age)";
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@name", Customer_name);
                    cmd.Parameters.AddWithValue("@dob", Customer_date_of_birth);
                    cmd.Parameters.AddWithValue("@mobile", Customer_mobile_no);
                    cmd.Parameters.AddWithValue("@address", Customer_address);
                    cmd.Parameters.AddWithValue("@age", Customer_age);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Delete_customer()
        {
            using (MySqlConnection con = new MySqlConnection(DatabaseConfig.ConnectionString))
            {
                con.Open();
                string query = "DELETE FROM customers WHERE Customer_id = @id";
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@id", Customer_id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Update_customer()
        {
            using (MySqlConnection con = new MySqlConnection(DatabaseConfig.ConnectionString))
            {
                con.Open();
                string query = "UPDATE customers SET Customer_name = @name, Customer_date_of_birth = @dob, Customer_mobile_no = @mobile, Customer_address = @address, Customer_age = @age WHERE Customer_id = @id";
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@name", Customer_name);
                    cmd.Parameters.AddWithValue("@dob", Customer_date_of_birth);
                    cmd.Parameters.AddWithValue("@mobile", Customer_mobile_no);
                    cmd.Parameters.AddWithValue("@address", Customer_address);
                    cmd.Parameters.AddWithValue("@age", Customer_age);
                    cmd.Parameters.AddWithValue("@id", Customer_id);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Search_customer()
        {
            using (MySqlConnection con = new MySqlConnection(DatabaseConfig.ConnectionString))
            {
                con.Open();
                string query = "SELECT * FROM customers WHERE Customer_id = @id";
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@id", Customer_id);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Customer_name = reader["Customer_name"].ToString();
                            Customer_date_of_birth = DateTime.Parse(reader["Customer_date_of_birth"].ToString());
                            Customer_mobile_no = reader["Customer_mobile_no"].ToString();
                            Customer_address = reader["Customer_address"].ToString();
                            Customer_age = int.Parse(reader["Customer_age"].ToString());
                        }
                    }
                }
            }
        }
    }
}
