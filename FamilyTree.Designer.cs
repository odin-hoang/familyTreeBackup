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
            this.shareButton = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.signUpPage1 = new WinformFamilyTree.SignUpPage();
            this.firstPage1 = new WinformFamilyTree.FirstPage();
            this.signInPage1 = new WinformFamilyTree.SignInPage();
            this.userControl41 = new WinformFamilyTree.UserControl4();
            this.userControl31 = new WinformFamilyTree.UserControl3();
            this.userControl21 = new WinformFamilyTree.UserControl2();
            this.userControl11 = new WinformFamilyTree.UserControl1();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
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
            // shareButton
            // 
            this.shareButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.shareButton.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shareButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.shareButton.Location = new System.Drawing.Point(0, 147);
            this.shareButton.Margin = new System.Windows.Forms.Padding(0);
            this.shareButton.Name = "shareButton";
            this.shareButton.Size = new System.Drawing.Size(290, 49);
            this.shareButton.TabIndex = 3;
            this.shareButton.Text = "Chia sẻ cây";
            this.shareButton.UseVisualStyleBackColor = false;
            this.shareButton.Click += new System.EventHandler(this.shareButton_Click);
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
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 6, 2);
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
            this.flowLayoutPanel2.Controls.Add(this.userControl41);
            this.flowLayoutPanel2.Controls.Add(this.userControl31);
            this.flowLayoutPanel2.Controls.Add(this.userControl21);
            this.flowLayoutPanel2.Controls.Add(this.userControl11);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(370, 100);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.tableLayoutPanel1.SetRowSpan(this.flowLayoutPanel2, 5);
            this.flowLayoutPanel2.Size = new System.Drawing.Size(872, 550);
            this.flowLayoutPanel2.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.ErrorImage = global::WinformFamilyTree.Properties.Resources.search;
            this.pictureBox1.Image = global::WinformFamilyTree.Properties.Resources.search;
            this.pictureBox1.Location = new System.Drawing.Point(994, 57);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 7, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
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
            this.tableLayoutPanel2.Controls.Add(this.pictureBox2, 2, 1);
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
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = global::WinformFamilyTree.Properties.Resources.chu_chim_canh_cut_con_nhin_cute_de_thuong_113124382;
            this.pictureBox2.Location = new System.Drawing.Point(67, 47);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(200, 200);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
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
            this.flowLayoutPanel1.Controls.Add(this.shareButton);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(17, 327);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(300, 273);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.signUpPage1);
            this.panel1.Controls.Add(this.firstPage1);
            this.panel1.Controls.Add(this.signInPage1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1264, 681);
            this.panel1.TabIndex = 10;
            // 
            // signUpPage1
            // 
            this.signUpPage1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.signUpPage1.Location = new System.Drawing.Point(0, 0);
            this.signUpPage1.Name = "signUpPage1";
            this.signUpPage1.Size = new System.Drawing.Size(1264, 681);
            this.signUpPage1.TabIndex = 12;
            // 
            // firstPage1
            // 
            this.firstPage1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.firstPage1.Location = new System.Drawing.Point(0, 0);
            this.firstPage1.Margin = new System.Windows.Forms.Padding(2);
            this.firstPage1.Name = "firstPage1";
            this.firstPage1.Size = new System.Drawing.Size(1264, 681);
            this.firstPage1.TabIndex = 11;
            // 
            // signInPage1
            // 
            this.signInPage1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.signInPage1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signInPage1.Location = new System.Drawing.Point(0, 0);
            this.signInPage1.Name = "signInPage1";
            this.signInPage1.Size = new System.Drawing.Size(1264, 681);
            this.signInPage1.TabIndex = 10;
            // 
            // userControl41
            // 
            this.userControl41.Location = new System.Drawing.Point(0, 0);
            this.userControl41.Margin = new System.Windows.Forms.Padding(0);
            this.userControl41.Name = "userControl41";
            this.userControl41.Size = new System.Drawing.Size(1024, 900);
            this.userControl41.TabIndex = 3;
            // 
            // userControl31
            // 
            this.userControl31.Location = new System.Drawing.Point(0, 900);
            this.userControl31.Margin = new System.Windows.Forms.Padding(0);
            this.userControl31.Name = "userControl31";
            this.userControl31.Size = new System.Drawing.Size(1024, 900);
            this.userControl31.TabIndex = 2;
            // 
            // userControl21
            // 
            this.userControl21.Location = new System.Drawing.Point(0, 1800);
            this.userControl21.Margin = new System.Windows.Forms.Padding(0);
            this.userControl21.Name = "userControl21";
            this.userControl21.Size = new System.Drawing.Size(1024, 900);
            this.userControl21.TabIndex = 1;
            // 
            // userControl11
            // 
            this.userControl11.Location = new System.Drawing.Point(0, 2700);
            this.userControl11.Margin = new System.Windows.Forms.Padding(0);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(1024, 900);
            this.userControl11.TabIndex = 0;
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Button homeScreenButton;
        private Button viewBiographyButton;
        private Button memberListButton;
        private Button shareButton;
        private TextBox searchBox;
        private PictureBox pictureBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox pictureBox2;
        private Label userNameLabel;
        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel2;
        private UserControl4 userControl41;
        private UserControl3 userControl31;
        private UserControl2 userControl21;
        private UserControl1 userControl11;
        private TableLayoutPanel tableLayoutPanel2;
        private SignInPage signInPage1;
        private Panel panel1;
        private FirstPage firstPage1;
        private SignUpPage signUpPage1;
    }
}

