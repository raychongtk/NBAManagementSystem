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
    public partial class header : UserControl
    {

        private bool allowLogout;

        public bool AllowLogout
        {
            get { return allowLogout; }
            set { allowLogout = value; btnLogout.Visible = value; }
        }

        private string title;

        public string Title
        {
            get { return title; }
            set { title = value; lblTitle.Text = value; }
        }

        public header()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ((Form)this.TopLevelControl).Owner.Show();
            ((Form)this.TopLevelControl).Close();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            frmMain f = new frmMain();
            f.Show();
            ((Form)this.TopLevelControl).Close();
        }
    }
}
