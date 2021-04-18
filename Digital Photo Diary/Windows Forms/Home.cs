using Digital_Photo_Diary.Windows_Forms;
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
    public partial class Home : Form
    {
        public string username = "";
        /*SignUp signup;
        string name = "";*/
        public Home()
        {
            InitializeComponent();
            /*this.signup = signup;
            name = this.signup.NameTextBox;*/
            /*SignUp signUp = new SignUp();
            username = signUp.nameTextBox.Text;*/
            
        }

        public void UserName(string username)
        {
            this.username = username;
        }

        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            CreateEvent cevent = new CreateEvent();
            cevent.Show();
            cevent.UserName(username);
            this.Hide();
        }

        private void viewButton_Click(object sender, EventArgs e)
        {
            SavedEvents sevent = new SavedEvents();
            sevent.Show();
            this.Hide();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }
    }
}
