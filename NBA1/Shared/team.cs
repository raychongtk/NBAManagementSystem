using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NBA1.Shared
{
    public partial class team : UserControl
    {
        public team(Image img, string teamName, int teamId)
        {
            InitializeComponent();
            pictureBox1.Image = img;
            label1.Text = teamName;
            pictureBox1.Tag = teamId;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lib.redirect(new frmTeamDetail((int)pictureBox1.Tag, 0), (Form)this.TopLevelControl);
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lib.redirect(new frmTeamDetail((int)pictureBox1.Tag, 1), (Form)this.TopLevelControl);
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lib.redirect(new frmTeamDetail((int)pictureBox1.Tag, 2), (Form)this.TopLevelControl);
        }
    }
}
