﻿using System;
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
    public partial class SignUpPage : UserControl
    {
        public SignUpPage()
        {
            InitializeComponent();
            instance = this;
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {

        }

        private void signInButton_Click(object sender, EventArgs e)
        {
            familyTree.instance.ucSignInPage.Show();
            familyTree.instance.ucSignInPage.BringToFront();
            familyTree.instance.ucSignUpPage.Hide();

        }
    }
}
