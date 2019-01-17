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
    public partial class frmMatchupDetail : Form
    {
        int matchupId;
        public frmMatchupDetail(int matchupId)
        {
            InitializeComponent();
            this.matchupId = matchupId;
            var quarter = lib.entity.MatchupLogs.Where(i => i.MatchupId == matchupId).GroupBy(g => g.Quarter).AsEnumerable().Select(x => new
            {
               id = x.FirstOrDefault().Quarter,
               name = lib.getQuarter(x.FirstOrDefault().Quarter)
            }).ToDictionary(x=>x.id,x=>x.name);
            lib.fillCombo(quarter, cboQuarter);

            var matchup = lib.entity.Matchups.FirstOrDefault(x => x.MatchupId == matchupId);
            lblTeamAway.Text = matchup.Team.TeamName;
            lblTeamHome.Text = matchup.Team1.TeamName;
            lblTeamAwayScore.Text = matchup.Team_Away_Score+"";
            lblTeamHomeScore.Text = matchup.Team_Home_Score + "";      
            picTeamAway.Image = lib.toImage(matchup.Team.Logo);
            picTeamHome.Image = lib.toImage(matchup.Team1.Logo);
            picTeamAwayLogo.Image = lib.toImage(matchup.Team.Logo);
            picTeamHomeLogo.Image = lib.toImage(matchup.Team1.Logo);
            picHome.Image = lib.toImage(matchup.Team1.Logo);
            picHomeLogo.Image = lib.toImage(matchup.Team1.Logo);
            picAwayLogo.Image = lib.toImage(matchup.Team.Logo);
            if (matchup.Team_Home_Score > matchup.Team_Away_Score)
            {
                lblTeamHome.Font = new Font(lblTeamHome.Font, FontStyle.Bold);
                lblTeamHomeScore.Font = new Font(lblTeamHomeScore.Font, FontStyle.Bold);
            }
            else
            {
                lblTeamAway.Font = new Font(lblTeamAway.Font, FontStyle.Bold);
                lblTeamAwayScore.Font = new Font(lblTeamAwayScore.Font, FontStyle.Bold);
            }

            lblStatus.Text = lib.getStatus(matchup.Status);
            switch (matchup.Status)
            {
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

            var starterAway = lib.entity.PlayerInTeams.Where(x => x.TeamId == matchup.Team_Away && x.StarterIndex == 1 && x.SeasonId == 3);
            foreach (var item in starterAway)
            {
                Shared.ucChart chart = new Shared.ucChart(lib.toImage(item.Player.Img), item.Player.Name + "(" + item.ShirtNumber + "#)");
                flowLayoutPanel1.Controls.Add(chart);
            }

            var starterHome = lib.entity.PlayerInTeams.Where(x => x.TeamId == matchup.Team_Home && x.StarterIndex == 1 && x.SeasonId == 3);
            foreach (var item in starterHome)
            {
                Shared.ucChart chart = new Shared.ucChart(lib.toImage(item.Player.Img), item.Player.Name + "(" + item.ShirtNumber + "#)");
                flowLayoutPanel2.Controls.Add(chart);
            }
            var matchupDetail = lib.entity.MatchupDetails.Where(i => i.MatchupId == matchupId).GroupBy(g=> new { g.Quarter, g.Matchup.Team_Away, g.Matchup.Team_Home}).Select(x => new
            {
                teamAwayAbbr = x.FirstOrDefault().Matchup.Team.Abbr,
                teamHomeAbbr = x.FirstOrDefault().Matchup.Team1.Abbr,
                quarter = x.FirstOrDefault().Quarter,
                teamAway = x.FirstOrDefault().Team_Away_Score,
                teamHome = x.FirstOrDefault().Team_Home_Score
            });
            if(matchupDetail != null)
            {
                dgvTeam.Columns.Add(" ", "");
                dgvTeam.Columns.Add(" ", "T");
                foreach (var item in matchupDetail)
                {
                    dgvTeam.Columns.Add(" ", lib.getQuarter(item.quarter));
                }
                dgvTeam.Rows.Add(matchup.Team.Abbr, matchupDetail.Sum(x => x.teamAway));
                dgvTeam.Rows.Add(matchup.Team1.Abbr, matchupDetail.Sum(x => x.teamHome));

                int j = 2;
                foreach (var item in matchupDetail)
                {
                    dgvTeam.Rows[0].Cells[j].Value = item.teamAway;
                    dgvTeam.Rows[1].Cells[j++].Value = item.teamHome;
                }
            }

            if(matchup.Status == -1)
            {
                MessageBox.Show("The game has not started!");
                return;
            }

            var status = lib.entity.PlayerStatistics.Where(x => x.MatchupId == matchupId).GroupBy(g => g.TeamId).AsEnumerable().Select(x => new
            {
               fg = x.FirstOrDefault().FieldGoalMade + "-" + x.FirstOrDefault().FieldGoalMissed,
               pt = x.FirstOrDefault().C3_PointFieldGoalMade + "-" + x.FirstOrDefault().C3_PointFieldGoalMissed,
               ft = x.FirstOrDefault().FreeThrowMade + "-" + x.FirstOrDefault().FreeThrowMissed,
               rebounds = x.Sum(i=>i.Rebound),
               assists = x.Sum(i => i.Assist),
               steals = x.Sum(i=>i.Steal),
               blocks = x.Sum(i=>i.Block),
               turnovers = x.Sum(i=>i.Turnover)
            }).ToArray();

            string[] title = { "FG Made-Attempted", "3PT Made-Attempted", "FT Made-Attempted", "Rebounds", "Assists", "Steals", "Blocks", "Turnovers" };
            for (int i = 0; i < 8; i++)
            {
                dgv1.Rows.Add(title[i], lib.getProperty(status[0], i), lib.getProperty(status[1], i));
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(cboQuarter.SelectedValue);
            dgv2.DataSource = lib.entity.MatchupLogs.Where(i => i.MatchupId == matchupId && i.Quarter == id).Select(x => new
            {
                OccurTime = x.OccurTime,
                Team = x.Team.Abbr,
                Player = x.Player.Name + "(" + x.Player.PlayerInTeams.FirstOrDefault(i => i.PlayerId == x.PlayerId && i.SeasonId == 3).ShirtNumber + "#)",
                ActionType = x.ActionType.Name,
                Remark = x.Remark
            }).ToList();
        }
    }
}
