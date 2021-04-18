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
    }
}
