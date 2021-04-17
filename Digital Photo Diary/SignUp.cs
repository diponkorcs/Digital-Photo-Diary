using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Digital_Photo_Diary
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void SignUp_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }



        private void loginButton_Click(object sender, EventArgs e)
        {
            if(nameTextBox.Text=="")
            {
                nameWarning.Visible = true;
            }
            else if(emailTextBox.Text=="")
            {
                emailWarning.Visible = true;
            }
            else if(passTextBox.Text=="")
            {
                passWarning.Visible = true;
            }
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (nameWarning.Visible == true)
            {
                nameWarning.Visible = false;
            }
        }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {
            if (emailWarning.Visible == true)
            {
                emailWarning.Visible = false;
            }
        }

        private void passTextBox_TextChanged(object sender, EventArgs e)
        {
            if (passWarning.Visible == true)
            {
                passWarning.Visible = false;
            }
        }

        private void loginGroupBox_Enter(object sender, EventArgs e)
        {
            if(nameWarning.Visible == true || emailWarning.Visible == true || passWarning.Visible == true)
            {
                loginButton.Enabled = false;
            }
            else
                loginButton.Enabled = true;
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            Registration reg = new Registration();
            reg.Show();
        }
    }
}
