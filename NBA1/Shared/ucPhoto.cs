using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace NBA1.Shared
{
    public partial class ucPhoto : UserControl
    {
        public ucPhoto(Image img, int id)
        {
            InitializeComponent();
            pictureBox1.Image = img;
            pictureBox1.Tag = id;
        }

        private void downloadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(AppDomain.CurrentDomain.BaseDirectory + @"download"))
            {
                Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + @"download");
            }
            pictureBox1.Image.Save(AppDomain.CurrentDomain.BaseDirectory + @"download\" + (int)pictureBox1.Tag + ".jpg");
            MessageBox.Show("Your photo is downloaded successfully! The path is " + AppDomain.CurrentDomain.BaseDirectory + @"download\" + (int)pictureBox1.Tag + ".jpg");
        }
    }
}
