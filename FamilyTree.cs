using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
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
            tableLayoutPanel2.Paint += tableLayoutPanel2_Paint;
            tableLayoutPanel3.Paint += tableLayoutPanel3_Paint;
            AvatarPictureBox.Paint += AvatarPictureBox_Paint;
            Nutchinhsua.Paint += Nutchinhsua_Paint;
        }

        //---------------code chỉnh sửa-------------------

        private void botronpanel(Panel panel)
        {	    
	    int radius = 30; // nơi chỉnh độ bo tròn
        GraphicsPath path = new GraphicsPath();
        Rectangle rect = panel.ClientRectangle; 
        path.AddLine(rect.X + radius, rect.Y, rect.X + rect.Width - radius, rect.Y);
            path.AddArc(rect.X + rect.Width - radius, rect.Y, radius, radius, 270, 90);
            path.AddLine(rect.X + rect.Width, rect.Y + radius, rect.X + rect.Width, rect.Y + rect.Height - radius);
            path.AddArc(rect.X + rect.Width - radius, rect.Y + rect.Height - radius, radius, radius, 0, 90);
            path.AddLine(rect.X + rect.Width - radius, rect.Y + rect.Height, rect.X + radius, rect.Y + rect.Height);
            path.AddArc(rect.X, rect.Y + rect.Height - radius, radius, radius, 90, 90);
            path.AddLine(rect.X, rect.Y + rect.Height - radius, rect.X, rect.Y + radius);
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.CloseFigure();
            panel.Region = new Region(path); 
         }

        private void botronanh(PictureBox picturebox)
        {
            int radius = 30; // nơi chỉnh độ bo tròn
            GraphicsPath path = new GraphicsPath();
            Rectangle rect = picturebox.ClientRectangle;
            path.AddLine(rect.X + radius, rect.Y, rect.X + rect.Width - radius, rect.Y);
            path.AddArc(rect.X + rect.Width - radius, rect.Y, radius, radius, 270, 90);
            path.AddLine(rect.X + rect.Width, rect.Y + radius, rect.X + rect.Width, rect.Y + rect.Height - radius);
            path.AddArc(rect.X + rect.Width - radius, rect.Y + rect.Height - radius, radius, radius, 0, 90);
            path.AddLine(rect.X + rect.Width - radius, rect.Y + rect.Height, rect.X + radius, rect.Y + rect.Height);
            path.AddArc(rect.X, rect.Y + rect.Height - radius, radius, radius, 90, 90);
            path.AddLine(rect.X, rect.Y + rect.Height - radius, rect.X, rect.Y + radius);
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.CloseFigure();
            picturebox.Region = new Region(path);
        }

        private void botronnut(Button button)
        {
            int radius = 30; // nơi chỉnh độ bo tròn
            GraphicsPath path = new GraphicsPath();
            Rectangle rect = button.ClientRectangle;
            path.AddLine(rect.X + radius, rect.Y, rect.X + rect.Width - radius, rect.Y);
            path.AddArc(rect.X + rect.Width - radius, rect.Y, radius, radius, 270, 90);
            path.AddLine(rect.X + rect.Width, rect.Y + radius, rect.X + rect.Width, rect.Y + rect.Height - radius);
            path.AddArc(rect.X + rect.Width - radius, rect.Y + rect.Height - radius, radius, radius, 0, 90);
            path.AddLine(rect.X + rect.Width - radius, rect.Y + rect.Height, rect.X + radius, rect.Y + rect.Height);
            path.AddArc(rect.X, rect.Y + rect.Height - radius, radius, radius, 90, 90);
            path.AddLine(rect.X, rect.Y + rect.Height - radius, rect.X, rect.Y + radius);
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.CloseFigure();
            button.Region = new Region(path);
        }
        //-----------------bo tròn--------------------

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {
            botronpanel(tableLayoutPanel2);
        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        { 
            botronpanel(tableLayoutPanel3); 
        }

        private void AvatarPictureBox_Paint(object sender, PaintEventArgs e)
        {
            botronanh(AvatarPictureBox);
        }
        private void Nutchinhsua_Paint(object sender, EventArgs e)
        {
            botronnut(Nutchinhsua);
        }
        //--------------------------------------------
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
            Nutchinhsua.Visible = false;

        }

        private void viewBiographyButton_Click(object sender, EventArgs e)
        {
            homeScreen.Hide();
            biographyScreen.Show();
            memberListScreen.Hide();
            sharedScreen.Hide();
            biographyScreen.BringToFront();
            Nutchinhsua.Visible = true;

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
            Nutchinhsua.Visible = false;

        }

        private void shareButton_Click(object sender, EventArgs e)
        {
            homeScreen.Hide();
            biographyScreen.Hide();
            memberListScreen.Hide();
            sharedScreen.Show();
            sharedScreen.BringToFront();
            Nutchinhsua.Visible = false;

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
                searchBox.ForeColor = Color.White;
            } else if (searchBox.Text == "") {
                searchBox.Text = placeHolder;
                searchBox.ForeColor = Color.White;
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
