using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinformFamilyTree.TreeClasses;

namespace WinformFamilyTree
{
    
    public partial class familyTree : Form
    {
        // These variable used to communicate together.
        public static familyTree instance;
        public UserControl ucFirstPage;
        public UserControl ucSignUpPage;
        public UserControl ucSignInPage;

        // Declaring a variable to submit a sign up form to database
        public void formSubmit_SignUp(object sender, EventArgs e)
        {
            AccountClass c = new AccountClass();
            c.FirstName = SignUpPage.instance.firstNameTextBox.Text;
            c.LastName = SignUpPage.instance.lastNameTextBox.Text;
            c.Email = SignUpPage.instance.emailTextBox.Text;
            c.Password = SignUpPage.instance.passwordTextBox.Text;
            bool success = c.Insert(c);
            if (success)
            {
                MessageBox.Show("Đăng ký tài khoản thành công!");
            } else
            {
                MessageBox.Show("Vui lòng thử lại!");
            }
            DataTable dt = c.Select();
            MemberListScreen.instance.dtg.DataSource = dt;

        }
        public familyTree()
        {
            InitializeComponent();
            ucSignInPage = signInPage;
            ucFirstPage = firstPage; 
            ucSignUpPage = signUpPage;
            instance = this;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Inital View is Home Screen 
            tableLayoutPanel1.BackColor = Color.FromArgb(0, 0, 0, 0);
            viewBiographyButton.FlatStyle = FlatStyle.Flat; 
            viewBiographyButton.FlatAppearance.BorderSize = 0;
            homeScreenButton.FlatStyle = FlatStyle.Flat;
            homeScreenButton.FlatAppearance.BorderSize= 0;
            memberListButton.FlatStyle = FlatStyle.Flat;
            memberListButton.FlatAppearance.BorderSize = 0;
            sharedButton.FlatStyle = FlatStyle.Flat;
            sharedButton.FlatAppearance.BorderSize = 0;
            firstPage.Show();
            signUpPage.Hide();
            signInPage.Hide();
            homeScreen.Hide();
            biographyScreen.Hide();
            memberListScreen.Hide();
            sharedScreen.Hide();
            homeScreen.BringToFront();
            
        }



        private void searchBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void homeScreenButton_Click(object sender, EventArgs e)
        {
            homeScreen.Show();
            biographyScreen.Hide();
            memberListScreen.Hide();
            sharedScreen.Hide();
            homeScreen.BringToFront();

        }

        private void viewBiographyButton_Click(object sender, EventArgs e)
        {
            homeScreen.Hide();
            biographyScreen.Show();
            memberListScreen.Hide();
            sharedScreen.Hide();
            biographyScreen.BringToFront();

        }

        private void memberListButton_Click(object sender, EventArgs e)
        {
            // Only show screen of member list and hide other screen
            homeScreen.Hide();
            biographyScreen.Hide();
            memberListScreen.Show();
            sharedScreen.Hide();
            memberListScreen.BringToFront();
            // Hide search box

        }

        private void shareButton_Click(object sender, EventArgs e)
        {
            homeScreen.Hide();
            biographyScreen.Hide();
            memberListScreen.Hide();
            sharedScreen.Show();
            sharedScreen.BringToFront();

        }

        private void searchBox_DoubleClick(object sender, EventArgs e)
        {
            
            searchBox.Text = "";
            searchBox.ForeColor = System.Drawing.SystemColors.ControlText;
    
        }

        private void True(object sender, ScrollEventArgs e)
        {

        }
        string placeHolder = "Nhập tên thành viên";
        private void searchBox_Click(object sender, EventArgs e)
        {
            
            if (searchBox.Text == placeHolder)
            {
                searchBox.Text = "";
                searchBox.ForeColor = Color.Black;
            } else if (searchBox.Text == "") {
                searchBox.Text = placeHolder;
                searchBox.ForeColor = Color.Silver;
            }
        }

        private void searchBox_LostFocus(object sender, EventArgs e)
        {
            if (searchBox.Text == "") { 
                searchBox.Text = placeHolder;
                searchBox.ForeColor = Color.Silver;
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void homeScreenButton_TabStopChanged(object sender, EventArgs e)
        {

        }
        Color mainColor = Color.FromArgb(137, 170, 255);


        private void homeScreenButton_onClick(object sender, EventArgs e)
        {

            homeScreenButton.BackColor = Color.White;
            homeScreenButton.ForeColor = mainColor;
            homeScreenButton.Font = new Font(homeScreenButton.Font, FontStyle.Bold);

        }

        private void signUpPage2_Load(object sender, EventArgs e)
        {
       
        }
    }
}
