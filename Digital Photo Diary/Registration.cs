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
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void Registration_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void termscheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (termscheckBox.Checked)
            {
                submitButton.Enabled = true;
            }
            else
                submitButton.Enabled = false;
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text == "")
            {
                nameWarning.Visible = true;
            }
            else if (usernameTextBox.Text == "")
            {
                usernameWarning.Visible = true;
            }
            else if (passTextBox.Text == "")
            {
                passWarning.Visible = true;
            }
            else if (cpassTextBox.Text == "")
            {
                cpassWarning.Visible = true;
            }
            else if (emailTextBox.Text == "")
            {
                emailWarning.Visible = true;
            }
            else if (dateTimePicker.Text == "")
            {
                dobWarning.Visible = true;
            }
            else if (maleRadioButton.Checked == false && femaleRadioButton.Checked == false)
            {
                genderWarning.Visible = true;
            }
            else if (bloodgroupTextBox.Text == "")
            {
                bgWarning.Visible = true;
            }
            else
            {
                if (passTextBox.Text != cpassTextBox.Text)
                {
                    MessageBox.Show("Password Did Not Match!!");
                }
                else
                {
                    SignUp signup = new SignUp();
                    signup.Show();
                    this.Hide();
                    //Database
                }
            }
            MessageBox.Show("Account Created. Go Back to Login Page To Login.");
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (nameWarning.Visible == true)
            {
                nameWarning.Visible = false;
            }
        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (usernameWarning.Visible == true)
            {
                usernameWarning.Visible = false;
            }
        }

        private void passTextBox_TextChanged(object sender, EventArgs e)
        {
            if (passWarning.Visible == true)
            {
                passWarning.Visible = false;
            }
        }

        private void cpassTextBox_TextChanged(object sender, EventArgs e)
        {
            if (cpassWarning.Visible == true)
            {
                cpassWarning.Visible = false;
            }
        }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {
            if (emailWarning.Visible == true)
            {
                emailWarning.Visible = false;
            }
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (dobWarning.Visible == true)
            {
                dobWarning.Visible = false;
            }
        }

        private void bloodgroupTextBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(bgWarning.Visible == true)
            {
                bgWarning.Visible = false;
            }
        }
    }
}
