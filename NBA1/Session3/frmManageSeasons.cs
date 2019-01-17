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
    public partial class frmManageSeasons : Form
    {
        public frmManageSeasons()
        {
            InitializeComponent();
            var seasons = lib.entity.Seasons.OrderByDescending(x => x.SeasonId).ToDictionary(x => x.SeasonId, x => x.Name);
            lib.fillCombo(seasons, cboSeason);

            var matchupType = new Dictionary<int, string>
            {
                {-1,"ALL" },
                {0, "Preseason" },
                {1, "Regular Season" },
                {2, "Post Season" }
            };

            lib.fillCombo(matchupType, cboMatchupType);

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int seasonId = Convert.ToInt32(cboSeason.SelectedValue);
            int matchupTypeId = Convert.ToInt32(cboMatchupType.SelectedValue);
            dgvGroupedMatchups.Rows.Clear();
            var matchups = lib.entity.Matchups.Where(i => i.SeasonId == seasonId).GroupBy(g => g.MatchupTypeId).Select(x => new
            {
                season = x.FirstOrDefault().Season.Name,
                type = x.FirstOrDefault().MatchupType.Name,
                count = x.Count(),
                id = x.FirstOrDefault().MatchupTypeId
            });
            if(matchupTypeId == 0 || matchupTypeId == 1)
            {
                matchups = lib.entity.Matchups.Where(i => i.SeasonId == seasonId && i.MatchupTypeId == matchupTypeId).GroupBy(g => g.MatchupTypeId).Select(x => new
                {
                    season = x.FirstOrDefault().Season.Name,
                    type = x.FirstOrDefault().MatchupType.Name,
                    count = x.Count(),
                    id = x.FirstOrDefault().MatchupTypeId
                });
            }
            else if(matchupTypeId == 2)
            {
                matchups = lib.entity.Matchups.Where(i => i.SeasonId == seasonId && (i.MatchupTypeId == 201 || i.MatchupTypeId == 202 || i.MatchupTypeId == 203 || i.MatchupTypeId == 204)).GroupBy(g => g.MatchupTypeId).Select(x => new
                {
                    season = x.FirstOrDefault().Season.Name,
                    type = x.FirstOrDefault().MatchupType.Name,
                    count = x.Count(),
                    id = x.FirstOrDefault().MatchupTypeId
                });
            }

            foreach (var matchup in matchups)
            {
                if (matchup.type.Contains("post"))
                {
                    bool isFound = false;
                    int i = 0;
                    foreach (DataGridViewRow row in dgvGroupedMatchups.Rows)
                    {
                        string cell = Convert.ToString(row.Cells[1].Value);
                        if (cell.Contains("Post"))
                        {
                            int count = Convert.ToInt32(row.Cells[2].Value) + matchup.count;
                            dgvGroupedMatchups.Rows[i].Cells[2].Value = count;
                           isFound = true;
                        }
                        i++;
                    }
                    if (!isFound)
                    {
                        dgvGroupedMatchups.Rows.Add(matchup.season, "Post Season", matchup.count, 2);
                    }
                }
                else
                {
                    dgvGroupedMatchups.Rows.Add(matchup.season, matchup.type, matchup.count, matchup.id);
                }
            }
        }

        private void dgvGroupedMatchups_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int typeId = Convert.ToInt32(dgvGroupedMatchups[3, e.RowIndex].Value);
            int seasonId = Convert.ToInt32(cboSeason.SelectedValue);
            dgvAllMatchups.Rows.Clear();
            if (typeId == 0 || typeId == 1)
            {
                var mathcups = lib.entity.Matchups.Where(x => x.SeasonId == seasonId && x.MatchupTypeId == typeId);
                foreach (var matchup in mathcups)
                {
                    dgvAllMatchups.Rows.Add(matchup.Starttime.ToString("yyyy/MM/dd"), matchup.Team.TeamName + " @ " + matchup.Team1.TeamName, matchup.Team_Away_Score + "-" + matchup.Team_Home_Score, matchup.Location);
                }  
            } else if(typeId == 2)
            {
                var mathcups = lib.entity.Matchups.Where(x => x.SeasonId == seasonId && (x.MatchupTypeId == 201 || x.MatchupTypeId == 202 || x.MatchupTypeId == 203 || x.MatchupTypeId == 204));
                foreach (var matchup in mathcups)
                {
                    dgvAllMatchups.Rows.Add(matchup.Starttime.ToString("yyyy/MM/dd"), matchup.Team.TeamName + " @ " + matchup.Team1.TeamName, matchup.Team_Away_Score + "-" + matchup.Team_Home_Score, matchup.Location);
                }
            }
        }
    }
}
