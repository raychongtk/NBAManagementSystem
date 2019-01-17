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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            if (Properties.Settings.Default.remember)
            {
                txtUsername.Text = Properties.Settings.Default.username;
                txtPassword.Text = Properties.Settings.Default.password;
                chkRemember.Checked = Properties.Settings.Default.remember;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmMain f = new frmMain();
            f.Show();
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var user = lib.entity.Admins.FirstOrDefault(i => i.Jobnumber.Equals(txtUsername.Text) && i.Passwords.Equals(txtPassword.Text));
            if(user != null)
            {
                if (chkRemember.Checked)
                {
                    Properties.Settings.Default.username = txtUsername.Text;
                    Properties.Settings.Default.password = txtPassword.Text;
                    Properties.Settings.Default.remember = chkRemember.Checked;
                    Properties.Settings.Default.Save(); // save
                }
                MessageBox.Show("Login successful!");
                if (user.RoleId.Equals("1"))
                {
                    lib.redirect(new frmEventAdminMenu(), this);
                }
                else
                {
                    lib.redirect(new frmTechAdminMenu(), this);
                }
            }
            else
            {
                MessageBox.Show("Login failure!");
            }
        }
    }
}
