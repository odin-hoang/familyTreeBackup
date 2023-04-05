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
    internal class MemberClass
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime DateOfDeath { get; set; }
        public string PlaceOfOrigin { get; set; }
        public string Biography { get; set; }

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
                string sql = "SELECT * FROM tbl_member";
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
        public bool Insert(MemberClass c)
        {
            // Creating a default return type and setting its value to false
            bool isSuccess = false;
            // Step 1: Database connection
            SqlConnection conn = new SqlConnection(myConnectionString);
            try
            {
                conn.Open();
                // Creating SQL Command using sql and conn
                string sql = "INSERT INTO tbl_member (FirstName, LastName, Gender, DateOfBirth, DateOfDeath, PlaceOfOrigin, Biography) VALUES(@FirstName, @LastName, @Gender, @DateOfBirth, @DateOfDeath, @PlaceOfOrigin, @Biography)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@FirstName", c.FirstName);
                cmd.Parameters.AddWithValue("@LastName", c.LastName);
                cmd.Parameters.AddWithValue("@Gender", c.Gender);
                cmd.Parameters.AddWithValue("@DateOfBirth", c.DateOfBirth);
                cmd.Parameters.AddWithValue("@DateOfDeath", c.DateOfDeath);
                cmd.Parameters.AddWithValue("@PlaceOfOrigin", c.PlaceOfOrigin);
                cmd.Parameters.AddWithValue("@Biography", c.Biography);
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
