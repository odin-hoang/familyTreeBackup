using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace WinformFamilyTree
{
    public partial class SignUpPage : UserControl
    {
        public static SignUpPage instance;
        public KryptonTextBox lastNameTextBox;
        public TextBox firstNameTextBox;
        public TextBox emailTextBox;
        public TextBox passwordTextBox;
        string lastNamePlaceholder = "Vd: Nguyễn Văn";
        string firstNamePlaceholder = "Vd: An";
        public SignUpPage()
        {
            InitializeComponent();
            instance = this;

            SignUpLastNameTextBox.Text = lastNamePlaceholder;
            SignUpLastNameTextBox.StateCommon.Content.Color1 = Color.Gray;
            SignUpFirstNameTextBox.Text = firstNamePlaceholder;
            SignUpFirstNameTextBox.StateCommon.Content.Color1 = Color.Gray;
        }
   
        private void signUpButton_Click(object sender, EventArgs e)
        {
            familyTree.instance.formSubmit_SignUp(sender, e);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void kryptonContextMenu1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void SignUpLastNameTextBox_Enter(object sender, EventArgs e)
        {
            if (SignUpLastNameTextBox.Text == lastNamePlaceholder)
            {
                SignUpLastNameTextBox.Text = "";
                SignUpLastNameTextBox.StateCommon.Content.Color1 = Color.Black;
            }
        }

        private void SignUpLastNameTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(SignUpLastNameTextBox.Text))
            {
                SignUpLastNameTextBox.Text = lastNamePlaceholder;
                SignUpLastNameTextBox.StateCommon.Content.Color1 = Color.Gray;
            }
        }


        private void SignUpFirstNameTextBox_Enter(object sender, EventArgs e)
        {
            if (SignUpFirstNameTextBox.Text == firstNamePlaceholder)
            {
                SignUpFirstNameTextBox.Text = "";
                SignUpFirstNameTextBox.StateCommon.Content.Color1 = Color.Black;
            }
        }

        private void SignUpFirstNameTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(SignUpFirstNameTextBox.Text))
            {
                SignUpFirstNameTextBox.Text = firstNamePlaceholder;
                SignUpFirstNameTextBox.StateCommon.Content.Color1 = Color.Gray;
            }
        }

        private void SignUpFirstNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SignUpLastNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
