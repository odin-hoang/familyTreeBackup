using System.Drawing.Drawing2D;
using System.Drawing;
using System.Windows.Forms;

namespace WinformFamilyTree
{
    partial class familyTree
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.homeScreenButton = new System.Windows.Forms.Button();
            this.viewBiographyButton = new System.Windows.Forms.Button();
            this.memberListButton = new System.Windows.Forms.Button();
            this.sharedButton = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.sharedScreen = new WinformFamilyTree.SharedScreen();
            this.memberListScreen = new WinformFamilyTree.MemberListScreen();
            this.biographyScreen = new WinformFamilyTree.BiographyViewScreen();
            this.homeScreen = new WinformFamilyTree.HomeScreen();
            this.SearchIconPictureBox = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.AvatarPictureBox = new System.Windows.Forms.PictureBox();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.signUpPage = new WinformFamilyTree.SignUpPage();
            this.firstPage = new WinformFamilyTree.FirstPage();
            this.signInPage = new WinformFamilyTree.SignInPage();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchIconPictureBox)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AvatarPictureBox)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // homeScreenButton
            // 
            this.homeScreenButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.homeScreenButton.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeScreenButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.homeScreenButton.Location = new System.Drawing.Point(0, 0);
            this.homeScreenButton.Margin = new System.Windows.Forms.Padding(0);
            this.homeScreenButton.Name = "homeScreenButton";
            this.homeScreenButton.Size = new System.Drawing.Size(290, 49);
            this.homeScreenButton.TabIndex = 0;
            this.homeScreenButton.Text = "Màn hình chính";
            this.homeScreenButton.UseVisualStyleBackColor = false;
            this.homeScreenButton.Click += new System.EventHandler(this.homeScreenButton_Click);
            this.homeScreenButton.MouseCaptureChanged += new System.EventHandler(this.homeScreenButton_onClick);
            // 
            // viewBiographyButton
            // 
            this.viewBiographyButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.viewBiographyButton.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewBiographyButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.viewBiographyButton.Location = new System.Drawing.Point(0, 49);
            this.viewBiographyButton.Margin = new System.Windows.Forms.Padding(0);
            this.viewBiographyButton.Name = "viewBiographyButton";
            this.viewBiographyButton.Size = new System.Drawing.Size(290, 49);
            this.viewBiographyButton.TabIndex = 1;
            this.viewBiographyButton.Text = "Xem tiểu sử";
            this.viewBiographyButton.UseVisualStyleBackColor = false;
            this.viewBiographyButton.Click += new System.EventHandler(this.viewBiographyButton_Click);
            // 
            // memberListButton
            // 
            this.memberListButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.memberListButton.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberListButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.memberListButton.Location = new System.Drawing.Point(0, 98);
            this.memberListButton.Margin = new System.Windows.Forms.Padding(0);
            this.memberListButton.Name = "memberListButton";
            this.memberListButton.Size = new System.Drawing.Size(290, 49);
            this.memberListButton.TabIndex = 2;
            this.memberListButton.Text = "Danh sách thành viên";
            this.memberListButton.UseVisualStyleBackColor = false;
            this.memberListButton.Click += new System.EventHandler(this.memberListButton_Click);
            // 
            // sharedButton
            // 
            this.sharedButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.sharedButton.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sharedButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.sharedButton.Location = new System.Drawing.Point(0, 147);
            this.sharedButton.Margin = new System.Windows.Forms.Padding(0);
            this.sharedButton.Name = "sharedButton";
            this.sharedButton.Size = new System.Drawing.Size(290, 49);
            this.sharedButton.TabIndex = 3;
            this.sharedButton.Text = "Chia sẻ cây";
            this.sharedButton.UseVisualStyleBackColor = false;
            this.sharedButton.Click += new System.EventHandler(this.shareButton_Click);
            // 
            // searchBox
            // 
            this.searchBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBox.ForeColor = System.Drawing.Color.Silver;
            this.searchBox.Location = new System.Drawing.Point(1028, 53);
            this.searchBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(210, 29);
            this.searchBox.TabIndex = 4;
            this.searchBox.Text = "Nhập tên thành viên";
            this.searchBox.Click += new System.EventHandler(this.searchBox_Click);
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            this.searchBox.DoubleClick += new System.EventHandler(this.searchBox_DoubleClick);
            this.searchBox.Leave += new System.EventHandler(this.searchBox_LostFocus);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 9;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 6, 3);
            this.tableLayoutPanel1.Controls.Add(this.searchBox, 7, 2);
            this.tableLayoutPanel1.Controls.Add(this.SearchIconPictureBox, 6, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1264, 681);
            this.tableLayoutPanel1.TabIndex = 9;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // flowLayoutPanel2
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.flowLayoutPanel2, 2);
            this.flowLayoutPanel2.Controls.Add(this.sharedScreen);
            this.flowLayoutPanel2.Controls.Add(this.memberListScreen);
            this.flowLayoutPanel2.Controls.Add(this.biographyScreen);
            this.flowLayoutPanel2.Controls.Add(this.homeScreen);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(370, 100);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.tableLayoutPanel1.SetRowSpan(this.flowLayoutPanel2, 5);
            this.flowLayoutPanel2.Size = new System.Drawing.Size(872, 550);
            this.flowLayoutPanel2.TabIndex = 3;
            // 
            // sharedScreen
            // 
            this.sharedScreen.Location = new System.Drawing.Point(0, 0);
            this.sharedScreen.Margin = new System.Windows.Forms.Padding(0);
            this.sharedScreen.Name = "sharedScreen";
            this.sharedScreen.Size = new System.Drawing.Size(1024, 900);
            this.sharedScreen.TabIndex = 3;
            // 
            // memberListScreen
            // 
            this.memberListScreen.Location = new System.Drawing.Point(0, 900);
            this.memberListScreen.Margin = new System.Windows.Forms.Padding(0);
            this.memberListScreen.Name = "memberListScreen";
            this.memberListScreen.Size = new System.Drawing.Size(1024, 900);
            this.memberListScreen.TabIndex = 2;
            // 
            // biographyScreen
            // 
            this.biographyScreen.Location = new System.Drawing.Point(0, 1800);
            this.biographyScreen.Margin = new System.Windows.Forms.Padding(0);
            this.biographyScreen.Name = "biographyScreen";
            this.biographyScreen.Size = new System.Drawing.Size(1024, 900);
            this.biographyScreen.TabIndex = 1;
            // 
            // homeScreen
            // 
            this.homeScreen.Location = new System.Drawing.Point(0, 2700);
            this.homeScreen.Margin = new System.Windows.Forms.Padding(0);
            this.homeScreen.Name = "homeScreen";
            this.homeScreen.Size = new System.Drawing.Size(1024, 900);
            this.homeScreen.TabIndex = 0;
            // 
            // SearchIconPictureBox
            // 
            this.SearchIconPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchIconPictureBox.ErrorImage = global::WinformFamilyTree.Properties.Resources.search;
            this.SearchIconPictureBox.Image = global::WinformFamilyTree.Properties.Resources.search;
            this.SearchIconPictureBox.Location = new System.Drawing.Point(994, 57);
            this.SearchIconPictureBox.Margin = new System.Windows.Forms.Padding(4, 7, 4, 3);
            this.SearchIconPictureBox.Name = "SearchIconPictureBox";
            this.SearchIconPictureBox.Size = new System.Drawing.Size(26, 26);
            this.SearchIconPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SearchIconPictureBox.TabIndex = 8;
            this.SearchIconPictureBox.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel2, 5);
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel2.Controls.Add(this.AvatarPictureBox, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.userNameLabel, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel1, 1, 4);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(30, 50);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel1.SetRowSpan(this.tableLayoutPanel2, 6);
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(340, 600);
            this.tableLayoutPanel2.TabIndex = 9;
            // 
            // AvatarPictureBox
            // 
            this.AvatarPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AvatarPictureBox.Image = global::WinformFamilyTree.Properties.Resources.chu_chim_canh_cut_con_nhin_cute_de_thuong_113124382;
            this.AvatarPictureBox.Location = new System.Drawing.Point(67, 47);
            this.AvatarPictureBox.Margin = new System.Windows.Forms.Padding(0);
            this.AvatarPictureBox.Name = "AvatarPictureBox";
            this.AvatarPictureBox.Size = new System.Drawing.Size(200, 200);
            this.AvatarPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AvatarPictureBox.TabIndex = 0;
            this.AvatarPictureBox.TabStop = false;
            // 
            // userNameLabel
            // 
            this.userNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel2.SetColumnSpan(this.userNameLabel, 3);
            this.userNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameLabel.Location = new System.Drawing.Point(20, 247);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(294, 50);
            this.userNameLabel.TabIndex = 1;
            this.userNameLabel.Text = "Ricardo Penguin";
            this.userNameLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // flowLayoutPanel1
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.flowLayoutPanel1, 3);
            this.flowLayoutPanel1.Controls.Add(this.homeScreenButton);
            this.flowLayoutPanel1.Controls.Add(this.viewBiographyButton);
            this.flowLayoutPanel1.Controls.Add(this.memberListButton);
            this.flowLayoutPanel1.Controls.Add(this.sharedButton);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(17, 327);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(300, 273);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.signUpPage);
            this.panel1.Controls.Add(this.firstPage);
            this.panel1.Controls.Add(this.signInPage);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1264, 681);
            this.panel1.TabIndex = 10;
            // 
            // signUpPage
            // 
            this.signUpPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.signUpPage.Location = new System.Drawing.Point(0, 0);
            this.signUpPage.Name = "signUpPage";
            this.signUpPage.Size = new System.Drawing.Size(1264, 681);
            this.signUpPage.TabIndex = 12;
            // 
            // firstPage
            // 
            this.firstPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.firstPage.Location = new System.Drawing.Point(0, 0);
            this.firstPage.Margin = new System.Windows.Forms.Padding(2);
            this.firstPage.Name = "firstPage";
            this.firstPage.Size = new System.Drawing.Size(1264, 681);
            this.firstPage.TabIndex = 11;
            // 
            // signInPage
            // 
            this.signInPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.signInPage.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signInPage.Location = new System.Drawing.Point(0, 0);
            this.signInPage.Name = "signInPage";
            this.signInPage.Size = new System.Drawing.Size(1264, 681);
            this.signInPage.TabIndex = 10;
            // 
            // familyTree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "familyTree";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Family Tree";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SearchIconPictureBox)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AvatarPictureBox)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Button homeScreenButton;
        private Button viewBiographyButton;
        private Button memberListButton;
        private Button sharedButton;
        private TextBox searchBox;
        private PictureBox SearchIconPictureBox;
        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox AvatarPictureBox;
        private Label userNameLabel;
        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel2;
        private SharedScreen sharedScreen;
        private MemberListScreen memberListScreen;
        private BiographyViewScreen biographyScreen;
        private HomeScreen homeScreen;
        private TableLayoutPanel tableLayoutPanel2;
        private SignInPage signInPage;
        private FirstPage firstPage;
        private SignUpPage signUpPage;
        private Panel panel1;
    }
}

