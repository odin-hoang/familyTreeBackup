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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.userAvatar = new System.Windows.Forms.PictureBox();
            this.userControl41 = new WinformFamilyTree.UserControl4();
            this.userControl31 = new WinformFamilyTree.UserControl3();
            this.userControl21 = new WinformFamilyTree.UserControl2();
            this.userControl11 = new WinformFamilyTree.UserControl1();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // homeScreenButton
            // 
            this.homeScreenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeScreenButton.Location = new System.Drawing.Point(35, 254);
            this.homeScreenButton.Name = "homeScreenButton";
            this.homeScreenButton.Size = new System.Drawing.Size(227, 46);
            this.homeScreenButton.TabIndex = 0;
            this.homeScreenButton.Text = "Màn hình chính";
            this.homeScreenButton.UseVisualStyleBackColor = true;
            this.homeScreenButton.Click += new System.EventHandler(this.homeScreenButton_Click);
            // 
            // viewBiographyButton
            // 
            this.viewBiographyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewBiographyButton.Location = new System.Drawing.Point(35, 320);
            this.viewBiographyButton.Name = "viewBiographyButton";
            this.viewBiographyButton.Size = new System.Drawing.Size(227, 46);
            this.viewBiographyButton.TabIndex = 0;
            this.viewBiographyButton.Text = "Xem tiểu sử";
            this.viewBiographyButton.UseVisualStyleBackColor = true;
            this.viewBiographyButton.Click += new System.EventHandler(this.viewBiographyButton_Click);
            // 
            // memberListButton
            // 
            this.memberListButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberListButton.Location = new System.Drawing.Point(35, 386);
            this.memberListButton.Name = "memberListButton";
            this.memberListButton.Size = new System.Drawing.Size(227, 46);
            this.memberListButton.TabIndex = 0;
            this.memberListButton.Text = "Danh sách thành viên";
            this.memberListButton.UseVisualStyleBackColor = true;
            this.memberListButton.Click += new System.EventHandler(this.memberListButton_Click);
            // 
            // shareButton
            // 
            this.shareButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shareButton.Location = new System.Drawing.Point(35, 449);
            this.shareButton.Name = "shareButton";
            this.shareButton.Size = new System.Drawing.Size(227, 46);
            this.shareButton.TabIndex = 0;
            this.shareButton.Text = "Chia sẻ cây";
            this.shareButton.UseVisualStyleBackColor = true;
            this.shareButton.Click += new System.EventHandler(this.shareButton_Click);
            // 
            // searchBox
            // 
            this.searchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBox.ForeColor = System.Drawing.Color.Silver;
            this.searchBox.Location = new System.Drawing.Point(1146, 27);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(235, 30);
            this.searchBox.TabIndex = 1;
            this.searchBox.Text = "Nhập tên thành viên";
            this.searchBox.Click += new System.EventHandler(this.searchBox_Click);
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            this.searchBox.DoubleClick += new System.EventHandler(this.searchBox_DoubleClick);
            this.searchBox.Leave += new System.EventHandler(this.searchBox_LostFocus);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = global::WinformFamilyTree.Properties.Resources.search;
            this.pictureBox1.Image = global::WinformFamilyTree.Properties.Resources.search;
            this.pictureBox1.Location = new System.Drawing.Point(1110, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // userAvatar
            // 
            this.userAvatar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userAvatar.Image = global::WinformFamilyTree.Properties.Resources.chu_chim_canh_cut_con_nhin_cute_de_thuong_113124382;
            this.userAvatar.Location = new System.Drawing.Point(46, 30);
            this.userAvatar.Name = "userAvatar";
            this.userAvatar.Size = new System.Drawing.Size(200, 200);
            this.userAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userAvatar.TabIndex = 3;
            this.userAvatar.TabStop = false;
            // 
            // userControl41
            // 
            this.userControl41.Location = new System.Drawing.Point(285, 63);
            this.userControl41.Name = "userControl41";
            this.userControl41.Size = new System.Drawing.Size(1024, 900);
            this.userControl41.TabIndex = 7;
            // 
            // userControl31
            // 
            this.userControl31.Location = new System.Drawing.Point(285, 63);
            this.userControl31.Name = "userControl31";
            this.userControl31.Size = new System.Drawing.Size(1024, 900);
            this.userControl31.TabIndex = 6;
            // 
            // userControl21
            // 
            this.userControl21.Location = new System.Drawing.Point(285, 63);
            this.userControl21.Name = "userControl21";
            this.userControl21.Size = new System.Drawing.Size(1024, 900);
            this.userControl21.TabIndex = 5;
            // 
            // userControl11
            // 
            this.userControl11.Location = new System.Drawing.Point(285, 63);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(1024, 900);
            this.userControl11.TabIndex = 4;
            // 
            // familyTree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1422, 977);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.userControl41);
            this.Controls.Add(this.userControl31);
            this.Controls.Add(this.userControl21);
            this.Controls.Add(this.userControl11);
            this.Controls.Add(this.userAvatar);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.shareButton);
            this.Controls.Add(this.memberListButton);
            this.Controls.Add(this.viewBiographyButton);
            this.Controls.Add(this.homeScreenButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "familyTree";
            this.Text = "Family Tree";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button homeScreenButton;
        private Button viewBiographyButton;
        private Button memberListButton;
        private Button shareButton;
        private TextBox searchBox;
        private PictureBox userAvatar;
        private UserControl1 userControl11;
        private UserControl2 userControl21;
        private UserControl3 userControl31;
        private UserControl4 userControl41;
        private PictureBox pictureBox1;
    }
}

