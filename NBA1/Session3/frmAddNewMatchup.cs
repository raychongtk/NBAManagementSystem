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
    public partial class frmAddNewMatchup : Form
    {
        public frmAddNewMatchup()
        {
            InitializeComponent();

            var teams = lib.entity.Teams.ToDictionary(x => x.TeamId, x => x.TeamName);
            lib.fillCombo(teams, cboTeamAway);
            lib.fillCombo(teams, cboTeamHome);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            int teamAway = Convert.ToInt32(cboTeamAway.SelectedValue);
            int teamHome = Convert.ToInt32(cboTeamHome.SelectedValue);

            if(teamAway == teamHome)
            {
                MessageBox.Show("Sorry, Team Away and Team Home cannot be the same!");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtTime.Text))
            {
                MessageBox.Show("sorry, time should be filled!");
                return;
            }
            DateTime dt = dtpDate.Value.Date;
            TimeSpan ts = TimeSpan.Parse(txtTime.Text);
            dt = dt.Add(ts);
            Matchup m = new Matchup()
            {
                SeasonId = 3,
                MatchupTypeId = 1,
                Team_Away = teamAway,
                Team_Home = teamHome,
                Starttime = dt,
                Team_Away_Score = 0,
                Team_Home_Score = 0,
                Location = txtLocation.Text,
                Status = -1,
                CurrentQuarter = null
            };
            lib.entity.Matchups.Add(m);
            lib.entity.SaveChanges();
            MessageBox.Show("Save successfully!");
        }

        private void cboTeamHome_SelectedIndexChanged(object sender, EventArgs e)
        {
            int teamHome = Convert.ToInt32(cboTeamHome.SelectedValue);
            var team = lib.entity.Teams.FirstOrDefault(x => x.TeamId == teamHome);
            txtLocation.Text = team.Stadium;
        }
    }
}
