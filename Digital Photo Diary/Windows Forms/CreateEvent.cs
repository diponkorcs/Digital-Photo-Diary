using Digital_Photo_Diary.Codes;
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
        string picture = "";
        public string username = "";
        public CreateEvent()
        {
            InitializeComponent();
        }

        public void UserName(string username)
        {
            this.username = username;
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
            /*SignUp signUp = new SignUp();
            string username = signUp.nameTextBox.Text;

            MessageBox.Show(""+username);*/
            Home home = new Home();
            //username = home.username;
            home.UserName(username);

            PicturesService picturesService = new PicturesService();
            picturesService.AddPictures(picture, eventnameTextBox.Text);

            EventService eventService = new EventService();
            eventService.AddEvents(eventnameTextBox.Text, storyTextBox.Text, dateTimePicker1.Text, importanceComboBox.Text, username);

            MessageBox.Show("Your Event Saved Successfully.");
            
            home.Show();
            this.Hide();
        }

        private void discardButton_Click(object sender, EventArgs e)
        {
            eventnameTextBox.Text = "";
            dateTimePicker1.Text = "";
            storyTextBox.Text = "";
            importanceComboBox.Text = "";
            //createPictureBox.Image = null;
            panel1.Controls.Clear();
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Image Files(*.jpg; *.jpeg; *.png; *.JPG; .bmp)|.jpg; *.jpeg; *.png; *.JPG; *.bmp";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                picture = openFile.FileName;
                PictureBox createPictureBox = new PictureBox();
                //createPictureBox.Image = new Bitmap(picture);

                Size size = createPictureBox.Size;
                size.Height = 150;
                size.Width = 150;
                createPictureBox.Size = size;

                createPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                createPictureBox.Image = Image.FromFile(picture);
                panel1.Controls.Add(createPictureBox);
            }
        }
    }
}
