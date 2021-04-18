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
    public partial class CreateEvent : Form
    {
        public CreateEvent()
        {
            InitializeComponent();
        }

        private void createEvent_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void eventnameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (eventnameTextBox.Text == "")
            {
                saveButton.Enabled = false;
            }
            else
            {
                saveButton.Enabled = true;
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your Event Saved Successfully.");
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void discardButton_Click(object sender, EventArgs e)
        {
            eventnameTextBox.Text = "";
            dateTimePicker1.Text = "";
            storyTextBox.Text = "";
            importanceComboBox.Text = "";
            createPictureBox.Image = null;
        }
    }
}
