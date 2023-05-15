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
    }
}
