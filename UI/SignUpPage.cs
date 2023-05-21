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
        public SignUpPage()
        {
            InitializeComponent();
            instance = this;
            SignUpLastNameTextBox.Text = "Vd: Nguyễn Văn";
            SignUpLastNameTextBox.StateCommon.Content.Color1 = Color.Gray;
            SignUpFirstNameTextBox.Text = "Vd: An";
            SignUpFirstNameTextBox.StateCommon.Content.Color1 = Color.Gray;
        }
   
        private void signUpButton_Click(object sender, EventArgs e)
        {
            familyTree.instance.formSubmit_SignUp(sender, e);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void kryptonTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void kryptonContextMenu1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void kryptonTextBox1_Enter(object sender, EventArgs e)
        {
            if (SignUpLastNameTextBox.Text == "Vd: Nguyễn Văn")
            {
                SignUpLastNameTextBox.Text = "";
                SignUpLastNameTextBox.StateCommon.Content.Color1 = Color.Black;
            }
        }

        private void kryptonTextBox1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(SignUpLastNameTextBox.Text))
            {
                SignUpLastNameTextBox.Text = "Vd: Nguyễn Văn";
                SignUpLastNameTextBox.StateCommon.Content.Color1 = Color.Gray;
            }
        }


        private void kryptonTextBox2_Enter(object sender, EventArgs e)
        {
            if (SignUpFirstNameTextBox.Text == "Vd: An")
            {
                SignUpFirstNameTextBox.Text = "";
                SignUpFirstNameTextBox.StateCommon.Content.Color1 = Color.Black;
            }
        }

        private void kryptonTextBox2_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(SignUpFirstNameTextBox.Text))
            {
                SignUpFirstNameTextBox.Text = "Vd: An";
                SignUpFirstNameTextBox.StateCommon.Content.Color1 = Color.Gray;
            }
        }
    }
}
