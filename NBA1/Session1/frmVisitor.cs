using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NBA1
{
    public partial class frmVisitor : Form
    {
        public frmVisitor()
        {
            InitializeComponent();
        }

        private void btnVisitor_Click(object sender, EventArgs e)
        {
            lib.redirect(new frmTeams(), this);
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            lib.redirect(new frmPlayersMain(), this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lib.redirect(new frmMatachupList(), this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lib.redirect(new frmPhotos(), this);
        }
    }
}
