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
            EventService eventService = new EventService();
            eventService.AddEvents(eventnameTextBox, storyTextBox, dateTimePicker1, importanceComboBox, gender, DateTimePicker, BloodGroupTextBox);

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
            //createPictureBox.Image = null;
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Image Files(*.jpg; *.jpeg; *.png; .bmp)|.jpg; *.jpeg; *.png; *.bmp";

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
