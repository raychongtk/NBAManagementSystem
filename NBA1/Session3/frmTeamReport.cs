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
    public partial class frmTeamReport : Form
    {
        public frmTeamReport()
        {
            InitializeComponent();
            var matchupType = new Dictionary<int, string>
            {
                {0, "Preseason" },
                {1, "Regular Season" },
                {2, "Post Season" }
            };

            lib.fillCombo(matchupType, cboMatchupType);

            cboRank.SelectedIndex = 0;
            cboView.SelectedIndex = 0;

            btnSearch_Click(null, null);
        }

        private void frmTeamReport_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        void loadSumReport(int index)
        {
            int typeId = Convert.ToInt32(cboMatchupType.SelectedValue);
            var teams = lib.entity.PlayerStatistics.GroupBy(g => g.TeamId).Select(x => new
            {
                name = x.FirstOrDefault().Team.TeamName,
                conference = x.FirstOrDefault().Team.Division.Conference.Name,
                division = x.FirstOrDefault().Team.Division.Name,
                points = x.Sum(i => i.Point),
                rebounds = x.Sum(i => i.Rebound),
                assists = x.Sum(i => i.Assist),
                steals = x.Sum(i => i.Steal),
                blocks = x.Sum(i => i.Block),
                turnovers = x.Sum(i => i.Turnover),
                foul = x.Sum(i => i.Foul)
            });
            if (typeId == 0 || typeId == 1)
            {
                teams = lib.entity.PlayerStatistics.Where(x => x.Matchup.MatchupTypeId == typeId).GroupBy(g => g.TeamId).Select(x => new
                {
                    name = x.FirstOrDefault().Team.TeamName,
                    conference = x.FirstOrDefault().Team.Division.Conference.Name,
                    division = x.FirstOrDefault().Team.Division.Name,
                    points = x.Sum(i=>i.Point),
                    rebounds = x.Sum(i=>i.Rebound),
                    assists = x.Sum(i=>i.Assist),
                    steals = x.Sum(i=>i.Steal),
                    blocks = x.Sum(i=>i.Block),
                    turnovers = x.Sum(i=>i.Turnover),
                    foul = x.Sum(i=>i.Foul)   
                });
            }
            else
            {
                teams = lib.entity.PlayerStatistics.Where(x => x.Matchup.MatchupTypeId == 201 || x.Matchup.MatchupTypeId == 202 || x.Matchup.MatchupTypeId == 203 || x.Matchup.MatchupTypeId == 204).GroupBy(g => g.TeamId).Select(x => new
                {
                    name = x.FirstOrDefault().Team.TeamName,
                    conference = x.FirstOrDefault().Team.Division.Conference.Name,
                    division = x.FirstOrDefault().Team.Division.Name,
                    points = x.Sum(i => i.Point),
                    rebounds = x.Sum(i => i.Rebound),
                    assists = x.Sum(i => i.Assist),
                    steals = x.Sum(i => i.Steal),
                    blocks = x.Sum(i => i.Block),
                    turnovers = x.Sum(i => i.Turnover),
                    foul = x.Sum(i => i.Foul)
                });
            }

            if(index == 3)
            {
                teams = teams.OrderByDescending(x => x.points);
            }
            else if(index == 4)
            {
                teams = teams.OrderByDescending(x => x.rebounds);
            }
            else if (index == 5)
            {
                teams = teams.OrderByDescending(x => x.assists);
            }
            else if (index == 6)
            {
                teams = teams.OrderByDescending(x => x.steals);
            }
            else if (index == 7)
            {
                teams = teams.OrderByDescending(x => x.blocks);
            }

            DataTable dt = new DataTable();
            dt.Columns.Add("Rank", typeof(string));
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Conference", typeof(string));
            dt.Columns.Add("Division", typeof(string));
            dt.Columns.Add("Points", typeof(string));
            dt.Columns.Add("Rebounds", typeof(string));
            dt.Columns.Add("Assists", typeof(string));
            dt.Columns.Add("Steals", typeof(string));
            dt.Columns.Add("Blocks", typeof(string));
            dt.Columns.Add("Turnovers", typeof(string));
            dt.Columns.Add("Fouls", typeof(string));
            int actualRank = 0;
            int prevValue = -1;

            foreach (var team in teams)
            {
                int value = (int)lib.getProperty(team, index);
                if (prevValue != value)
                {
                    actualRank++;
                    prevValue = value;
                }
                dt.Rows.Add(actualRank, team.name, team.conference, team.division, team.points, team.rebounds, team.assists, team.steals, team.blocks, team.turnovers, team.foul);
            }

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("teamReport", dt));
            reportViewer1.RefreshReport();
            reportViewer1.Refresh();
        }

        void loadAvgReport(int index)
        {
            int typeId = Convert.ToInt32(cboMatchupType.SelectedValue);
            var teams = lib.entity.PlayerStatistics.GroupBy(g => g.TeamId).Select(x => new
            {
                name = x.FirstOrDefault().Team.TeamName,
                conference = x.FirstOrDefault().Team.Division.Conference.Name,
                division = x.FirstOrDefault().Team.Division.Name,
                points = x.Average(i => i.Point),
                rebounds = x.Average(i => i.Rebound),
                assists = x.Average(i => i.Assist),
                steals = x.Average(i => i.Steal),
                blocks = x.Average(i => i.Block),
                turnovers = x.Average(i => i.Turnover),
                foul = x.Average(i => i.Foul)
            });
            if (typeId == 0 || typeId == 1)
            {
                teams = lib.entity.PlayerStatistics.Where(x => x.Matchup.MatchupTypeId == typeId).GroupBy(g => g.TeamId).Select(x => new
                {
                    name = x.FirstOrDefault().Team.TeamName,
                    conference = x.FirstOrDefault().Team.Division.Conference.Name,
                    division = x.FirstOrDefault().Team.Division.Name,
                    points = x.Average(i => i.Point),
                    rebounds = x.Average(i => i.Rebound),
                    assists = x.Average(i => i.Assist),
                    steals = x.Average(i => i.Steal),
                    blocks = x.Average(i => i.Block),
                    turnovers = x.Average(i => i.Turnover),
                    foul = x.Average(i => i.Foul)
                });
            }
            else
            {
                teams = lib.entity.PlayerStatistics.Where(x => x.Matchup.MatchupTypeId == 201 || x.Matchup.MatchupTypeId == 202 || x.Matchup.MatchupTypeId == 203 || x.Matchup.MatchupTypeId == 204).GroupBy(g => g.TeamId).Select(x => new
                {
                    name = x.FirstOrDefault().Team.TeamName,
                    conference = x.FirstOrDefault().Team.Division.Conference.Name,
                    division = x.FirstOrDefault().Team.Division.Name,
                    points = x.Average(i => i.Point),
                    rebounds = x.Average(i => i.Rebound),
                    assists = x.Average(i => i.Assist),
                    steals = x.Average(i => i.Steal),
                    blocks = x.Average(i => i.Block),
                    turnovers = x.Average(i => i.Turnover),
                    foul = x.Average(i => i.Foul)
                });
            }

            if (index == 3)
            {
                teams = teams.OrderByDescending(x => x.points);
            }
            else if (index == 4)
            {
                teams = teams.OrderByDescending(x => x.rebounds);
            }
            else if (index == 5)
            {
                teams = teams.OrderByDescending(x => x.assists);
            }
            else if (index == 6)
            {
                teams = teams.OrderByDescending(x => x.steals);
            }
            else if (index == 7)
            {
                teams = teams.OrderByDescending(x => x.blocks);
            }

            DataTable dt = new DataTable();
            dt.Columns.Add("Rank", typeof(string));
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Conference", typeof(string));
            dt.Columns.Add("Division", typeof(string));
            dt.Columns.Add("Points", typeof(string));
            dt.Columns.Add("Rebounds", typeof(string));
            dt.Columns.Add("Assists", typeof(string));
            dt.Columns.Add("Steals", typeof(string));
            dt.Columns.Add("Blocks", typeof(string));
            dt.Columns.Add("Turnovers", typeof(string));
            dt.Columns.Add("Fouls", typeof(string));
            int actualRank = 0;
            double prevValue = -1;

            foreach (var team in teams)
            {
                double value = (double)lib.getProperty(team, index);
                if (prevValue != value)
                {
                    actualRank++;
                    prevValue = value;
                }
                dt.Rows.Add(actualRank, team.name, team.conference, team.division, team.points.ToString("f2"), team.rebounds.ToString("f2"), team.assists.ToString("f2"), team.steals.ToString("f2"), team.blocks.ToString("f2"), team.turnovers.ToString("f2"), team.foul.ToString("f2"));
            }

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("teamReport", dt));
            reportViewer1.RefreshReport();
            reportViewer1.Refresh();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string view = Convert.ToString(cboView.SelectedItem);

            if (view.Equals("Average"))
            {
                loadAvgReport(cboRank.SelectedIndex + 3);
            }
            else
            {
                loadSumReport(cboRank.SelectedIndex + 3);
            }
        }
    }
}
