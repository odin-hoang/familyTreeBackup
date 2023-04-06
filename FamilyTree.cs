using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformFamilyTree
{
    public partial class familyTree : Form
    {
        public static familyTree instance;
        public UserControl ucSignInPage;
        public UserControl ucSignUpPage;

        public familyTree()
        {
            InitializeComponent();
            ucSignInPage = signInPage1;
            ucSignUpPage = signUpPage2;
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
            shareButton.FlatStyle = FlatStyle.Flat;
            shareButton.FlatAppearance.BorderSize = 0;
            userControl11.Show();
            userControl21.Hide();
            userControl31.Hide();
            userControl41.Hide();
            userControl11.BringToFront();
            
        }



        private void searchBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void homeScreenButton_Click(object sender, EventArgs e)
        {
            userControl11.Show();
            userControl21.Hide();
            userControl31.Hide();
            userControl41.Hide();
            userControl11.BringToFront();

        }

        private void viewBiographyButton_Click(object sender, EventArgs e)
        {
            userControl11.Hide();
            userControl21.Show();
            userControl31.Hide();
            userControl41.Hide();
            userControl21.BringToFront();

        }

        private void memberListButton_Click(object sender, EventArgs e)
        {
            // Only show screen of member list and hide other screen
            userControl11.Hide();
            userControl21.Hide();
            userControl31.Show();
            userControl41.Hide();
            userControl31.BringToFront();
            // Hide search box

        }

        private void shareButton_Click(object sender, EventArgs e)
        {
            userControl11.Hide();
            userControl21.Hide();
            userControl31.Hide();
            userControl41.Show();
            userControl41.BringToFront();

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
