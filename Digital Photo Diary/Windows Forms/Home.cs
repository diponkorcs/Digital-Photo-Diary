﻿using Digital_Photo_Diary.Windows_Forms;
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
        public Home()
        {
            InitializeComponent();
        }

        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            CreateEvent cevent = new CreateEvent();
            cevent.Show();
            this.Hide();
        }

        private void viewButton_Click(object sender, EventArgs e)
        {
            SavedEvents sevent = new SavedEvents();
            sevent.Show();
            this.Hide();
        }
    }
}
