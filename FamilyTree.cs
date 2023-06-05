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
            homeScreenButton.Paint += homeScreenButton_Paint;
            viewBiographyButton.Paint += viewBiographyButton_Paint;
            memberListButton.Paint += memberListButton_Paint;
            sharedButton.Paint += sharedButton_Paint;
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
        private void homeScreenButton_Paint(object sender, PaintEventArgs e)
        {
            botronnut(homeScreenButton);
        }
        private void viewBiographyButton_Paint(Object sender, PaintEventArgs e)
        {
            botronnut(viewBiographyButton);
        }
        private void memberListButton_Paint(object obj, PaintEventArgs e)
        {
            botronnut(memberListButton);
        }
        private void sharedButton_Paint(object obj, PaintEventArgs e)
        {
            botronnut(sharedButton);
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
        Color mainColor = Color.FromArgb(137, 170, 255);


        private void homeScreenButton_onClick(object sender, EventArgs e)
        {

            homeScreenButton.BackColor = Color.White;
            homeScreenButton.ForeColor = mainColor;
            homeScreenButton.Font = new Font(homeScreenButton.Font, FontStyle.Bold);
            
            viewBiographyButton.BackColor = mainColor;
            viewBiographyButton.ForeColor = Color.White;
            viewBiographyButton.Font = new Font(viewBiographyButton.Font, FontStyle.Regular);

            memberListButton.BackColor = mainColor;
            memberListButton.ForeColor = Color.White;
            memberListButton.Font = new Font(memberListButton.Font, FontStyle.Regular);

            sharedButton.BackColor = mainColor;
            sharedButton.ForeColor = Color.White;
            sharedButton.Font = new Font(sharedButton.Font, FontStyle.Regular);

        }
        private void viewBiographyButton_onClick(Object sender, EventArgs e)
        {
            viewBiographyButton.BackColor = Color.White;
            viewBiographyButton.ForeColor = mainColor;
            viewBiographyButton.Font = new Font(viewBiographyButton.Font, FontStyle.Bold);

            memberListButton.BackColor = mainColor;
            memberListButton.ForeColor = Color.White;
            memberListButton.Font = new Font(memberListButton.Font, FontStyle.Regular);

            sharedButton.BackColor = mainColor;
            sharedButton.ForeColor = Color.White;
            sharedButton.Font = new Font(sharedButton.Font, FontStyle.Regular);


            homeScreenButton.BackColor = mainColor;
            homeScreenButton.ForeColor = Color.White;
            homeScreenButton.Font = new Font(homeScreenButton.Font, FontStyle.Regular);
        }
        private void memberListbutton_onClick(object sender, EventArgs e)
        {
            memberListButton.BackColor = Color.White;
            memberListButton.ForeColor = mainColor;
            memberListButton.Font = new Font(memberListButton.Font, FontStyle.Bold);

            sharedButton.BackColor = mainColor;
            sharedButton.ForeColor = Color.White;
            sharedButton.Font = new Font(sharedButton.Font, FontStyle.Regular);


            homeScreenButton.BackColor = mainColor;
            homeScreenButton.ForeColor = Color.White;
            homeScreenButton.Font = new Font(homeScreenButton.Font, FontStyle.Regular);

            viewBiographyButton.BackColor = mainColor;
            viewBiographyButton.ForeColor = Color.White;
            viewBiographyButton.Font = new Font(viewBiographyButton.Font, FontStyle.Regular);
        }
        private void sharedButton_onClick(object sender, EventArgs e)
        {
            sharedButton.BackColor = Color.White;
            sharedButton.ForeColor = mainColor;
            sharedButton.Font = new Font(sharedButton.Font, FontStyle.Bold);

            homeScreenButton.BackColor = mainColor;
            homeScreenButton.ForeColor = Color.White;
            homeScreenButton.Font = new Font(homeScreenButton.Font, FontStyle.Regular);

            viewBiographyButton.BackColor = mainColor;
            viewBiographyButton.ForeColor = Color.White;
            viewBiographyButton.Font = new Font(viewBiographyButton.Font, FontStyle.Regular);

            memberListButton.BackColor = mainColor;
            memberListButton.ForeColor = Color.White;
            memberListButton.Font = new Font(memberListButton.Font, FontStyle.Regular);
        }


        
       
    }
}
