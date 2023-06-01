using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformFamilyTree
{
    public partial class SignInPage : UserControl
    {
        public static SignInPage instance;
        static string myConnectionString = ConfigurationManager.ConnectionStrings["connstrngAccount"].ConnectionString;

        public SignInPage()
        {
            InitializeComponent();

            instance = this;
        }


        private void signInButton_Click(object sender, EventArgs e)
        {
            string email = SignInEmailTextBox.Text;
            string password = SignInPasswordTextBox.Text;
            SqlConnection conn = new SqlConnection(myConnectionString);
            try
            {
                conn.Open();
                string sql = "SELECT * FROM UserData WHERE Email = '" +email+ "' AND UserPassword = '"+password+"'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dTable = new DataTable();
                sda.Fill(dTable);
                // exist accout in database
                if(dTable.Rows.Count > 0) 
                {
                    // load to next page
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Sai email hoặc mật khẩu!");
                    SignInEmailTextBox.Clear();
                    SignInPasswordTextBox.Clear();
                }
            }
            catch 
            {
                MessageBox.Show("Lỗi, hãy thử lại!");
            }
            finally { conn.Close(); }



        }

        private void SignInEmailTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
