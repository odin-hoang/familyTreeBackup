using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinformFamilyTree.TreeClasses
{
    internal class AccountClass
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }


        // Connect to the database
        static string myConnectionString = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        // Function for Selecting data from Database
        public DataTable Select()
        {
            // Step 1: Database connection
            SqlConnection conn = new SqlConnection(myConnectionString);
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                // Creating SQL Command using sql and connection
                string sql = "SELECT * FROM tbl_user";
                SqlCommand cmd = new SqlCommand(sql, conn);
                // Creating Adapter using cmd
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally { conn.Close(); }
            return dt;
        }
        // Function for inserting Data into database
        public bool Insert(AccountClass c)
        {
            // Creating a default return type and setting its value to false
            bool isSuccess = false;
            // Step 1: Database connection
            SqlConnection conn = new SqlConnection(myConnectionString);
            try
            {
                conn.Open();
                // Creating SQL Command using sql and conn
                string sql = "INSERT INTO tbl_user (FirstName, LastName, Email, Password) VALUES(@FirstName, @LastName, @Email, @Password)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@FirstName", c.FirstName);
                cmd.Parameters.AddWithValue("@LastName", c.LastName);
                cmd.Parameters.AddWithValue("@Email", c.Email);
                cmd.Parameters.AddWithValue("@Password", c.Password);
                int rows = cmd.ExecuteNonQuery();
                // If the query run sucessfully, the value of rows will be greater than 0 else its value will be 0
                if (rows > 0) { isSuccess = true; }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally { conn.Close(); }
            return isSuccess;
        }
        // Function for Update data to database
        public bool Update(AccountClass c)
        {
            // Creating a default return type and setting its value to false
            bool isSuccess = false;
            // Step 1: Database connection
            SqlConnection conn = new SqlConnection(myConnectionString);
            try
            {
                conn.Open();
                // Creating SQL Command using sql and conn
                string sql = "UPDATE tbl_user " + "SET FirstName = @FirstName," + "LastName = @LastName," + "Email = @Email," + "Password = @Password," +
                    "WHERE ID = @ID";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@FirstName", c.FirstName);
                cmd.Parameters.AddWithValue("@LastName", c.LastName);
                cmd.Parameters.AddWithValue("@Gender", c.Email);
                cmd.Parameters.AddWithValue("@DateOfBirth", c.Password);
                cmd.Parameters.AddWithValue("@ID", c.ID);
                int rows = cmd.ExecuteNonQuery();
                // If the query run sucessfully, the value of rows will be greater than 0 else its value will be 0
                if (rows > 0) { isSuccess = true; }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally { conn.Close(); }
            return isSuccess;
        }
        // Function for delete data to database
        public bool Delete(AccountClass c)
        {
            // Creating a default return type and setting its value to false
            bool isSuccess = false;
            // Step 1: Database connection
            SqlConnection conn = new SqlConnection(myConnectionString);
            try
            {
                conn.Open();
                // Creating SQL Command using sql and conn
                string sql = "DELETE FROM tbl_user WHERE ID = @ID";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ID", c.ID);
                int rows = cmd.ExecuteNonQuery();
                // If the query run sucessfully, the value of rows will be greater than 0 else its value will be 0
                if (rows > 0) { isSuccess = true; }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally { conn.Close(); }
            return isSuccess;
        }
    }
}
