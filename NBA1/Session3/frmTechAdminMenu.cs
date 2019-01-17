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
    public partial class frmTechAdminMenu : Form
    {
        public frmTechAdminMenu()
        {
            InitializeComponent();
        }

        private void btnTeamReport_Click(object sender, EventArgs e)
        {
            lib.redirect(new frmTeamReport(), this);
        }
    }
}
