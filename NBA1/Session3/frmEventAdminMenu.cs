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
    public partial class frmEventAdminMenu : Form
    {
        public frmEventAdminMenu()
        {
            InitializeComponent();
        }

        private void btnSeasons_Click(object sender, EventArgs e)
        {
            lib.redirect(new frmManageSeasons(), this);
        }

        private void btnMatchups_Click(object sender, EventArgs e)
        {
            lib.redirect(new frmManageMatchups(), this);
        }

        private void btnTeams_Click(object sender, EventArgs e)
        {
            lib.redirect(new frmManageTeams(), this);
        }

        private void btnPlayers_Click(object sender, EventArgs e)
        {
            lib.redirect(new frmManagePlayers(), this);
        }
    }
}
