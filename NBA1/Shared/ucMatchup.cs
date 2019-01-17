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
    public partial class ucMatchup : UserControl
    {
        int matchupId;
        public ucMatchup(int matchupId)
        {
            InitializeComponent();
            this.matchupId = matchupId;
            var team = lib.entity.Matchups.FirstOrDefault(i => i.MatchupId == matchupId);
            lblStatus.Text = lib.getStatus(team.Status);
            switch (team.Status) {
                case -1:
                    lblStatus.BackColor = Color.DeepSkyBlue;
                    break;
                case 0:
                    lblStatus.BackColor = Color.Red;
                    break;
                default:
                    lblStatus.BackColor = Color.DarkGray;
                    break;
            }
            lblStartTime.Text = team.Starttime.ToString("MM/dd") + " " + team.Starttime.ToString("hh:mm");
            picTeamAway.Image = lib.toImage(team.Team.Logo);
            picTeamHome.Image = lib.toImage(team.Team1.Logo);
            lblTeamAway.Text = team.Team.TeamName;
            lblTeamHome.Text = team.Team1.TeamName;
            lblResult.Text = (team.Team_Away_Score == 0 ? "" : team.Team_Away_Score + "") + "-" + (team.Team_Home_Score == 0 ? "" : team.Team_Home_Score + "");
            lblLoc.Text = team.Location;
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            lib.redirect(new frmMatchupDetail(matchupId), (Form)this.TopLevelControl);
        }
    }
}
