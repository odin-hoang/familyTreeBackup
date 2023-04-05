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
            this.listMemberButton = new System.Windows.Forms.Button();
            this.shareButton = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.searchLabel = new System.Windows.Forms.Label();
            this.userAvatar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.userAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // homeScreenButton
            // 
            this.homeScreenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeScreenButton.Location = new System.Drawing.Point(103, 269);
            this.homeScreenButton.Name = "homeScreenButton";
            this.homeScreenButton.Size = new System.Drawing.Size(227, 46);
            this.homeScreenButton.TabIndex = 0;
            this.homeScreenButton.Text = "Màn hình chính";
            this.homeScreenButton.UseVisualStyleBackColor = true;
            this.homeScreenButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // viewBiographyButton
            // 
            this.viewBiographyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewBiographyButton.Location = new System.Drawing.Point(103, 335);
            this.viewBiographyButton.Name = "viewBiographyButton";
            this.viewBiographyButton.Size = new System.Drawing.Size(227, 46);
            this.viewBiographyButton.TabIndex = 0;
            this.viewBiographyButton.Text = "Xem tiểu sử";
            this.viewBiographyButton.UseVisualStyleBackColor = true;
            this.viewBiographyButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // listMemberButton
            // 
            this.listMemberButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listMemberButton.Location = new System.Drawing.Point(103, 401);
            this.listMemberButton.Name = "listMemberButton";
            this.listMemberButton.Size = new System.Drawing.Size(227, 46);
            this.listMemberButton.TabIndex = 0;
            this.listMemberButton.Text = "Danh sách thành viên";
            this.listMemberButton.UseVisualStyleBackColor = true;
            this.listMemberButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // shareButton
            // 
            this.shareButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shareButton.Location = new System.Drawing.Point(103, 464);
            this.shareButton.Name = "shareButton";
            this.shareButton.Size = new System.Drawing.Size(227, 46);
            this.shareButton.TabIndex = 0;
            this.shareButton.Text = "Chia sẻ cây";
            this.shareButton.UseVisualStyleBackColor = true;
            this.shareButton.Click += new System.EventHandler(this.button1_Click_1);
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
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLabel.Location = new System.Drawing.Point(1049, 30);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(91, 25);
            this.searchLabel.TabIndex = 2;
            this.searchLabel.Text = "Tìm kiếm";
            this.searchLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // userAvatar
            // 
            this.userAvatar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userAvatar.Image = global::WinformFamilyTree.Properties.Resources.chu_chim_canh_cut_con_nhin_cute_de_thuong_113124382;
            this.userAvatar.Location = new System.Drawing.Point(114, 45);
            this.userAvatar.Name = "userAvatar";
            this.userAvatar.Size = new System.Drawing.Size(200, 200);
            this.userAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userAvatar.TabIndex = 3;
            this.userAvatar.TabStop = false;
            // 
            // familyTree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1422, 977);
            this.Controls.Add(this.userAvatar);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.shareButton);
            this.Controls.Add(this.listMemberButton);
            this.Controls.Add(this.viewBiographyButton);
            this.Controls.Add(this.homeScreenButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "familyTree";
            this.Text = "Family Tree";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button homeScreenButton;
        private Button viewBiographyButton;
        private Button listMemberButton;
        private Button shareButton;
        private TextBox searchBox;
        private Label searchLabel;
        private PictureBox userAvatar;
    }
}

