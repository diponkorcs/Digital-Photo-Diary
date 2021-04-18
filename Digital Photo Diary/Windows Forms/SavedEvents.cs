using Digital_Photo_Diary.Codes;
using Digital_Photo_Diary.Data_Access_Layer.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Digital_Photo_Diary.Windows_Forms
{
    public partial class SavedEvents : Form
    {
        public string username = "";
        public SavedEvents()
        {
            InitializeComponent();
        }

        private void selectLabel_Click(object sender, EventArgs e)
        {

        }

        private void SavedEvents_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void SavedEvents_Load(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.UserName(username);
            home.Show();
            this.Hide();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void iLabel_Click(object sender, EventArgs e)
        {

        }
        public void UserName(string username)
        {
            this.username = username;
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            /*Home home = new Home();
            home.UserName(username);*/
        }

        private void showButton_Click_1(object sender, EventArgs e)
        {
            EventService eventService = new EventService();
            comboBox2.DataSource = eventService.EventNames(username);
        }

        private void button1_Click(object sender, EventArgs e)
        {


            panel1.Controls.Clear();
            PicturesService picturesService = new PicturesService();
            int x = 20;
            int y = 20;
            int maxHight = -1;
            foreach (Pictures pic in picturesService.GetPictures(comboBox2.Text))
            {
                PictureBox picture = new PictureBox();
                Size size = picture.Size;
                size.Height = 150;
                size.Width = 150;
                picture.Size = size;
                picture.SizeMode = PictureBoxSizeMode.StretchImage;
                picture.Image = Image.FromFile(pic.StorageLocation);
                picture.Location = new Point(x, y);
                x += picture.Width + 10;
                maxHight = Math.Max(picture.Height, maxHight);
                if (x > this.ClientSize.Width - 100)
                {
                    x = 20;
                    y += maxHight + 10;
                }
                this.panel1.Controls.Add(picture);
            }
        }
    }
}
