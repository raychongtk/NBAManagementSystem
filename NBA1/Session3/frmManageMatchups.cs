using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using excel = Microsoft.Office.Interop.Excel;
namespace NBA1
{
    public partial class frmManageMatchups : Form
    {
        public frmManageMatchups()
        {
            InitializeComponent();
            var seasons = lib.entity.Seasons.OrderByDescending(x => x.SeasonId).ToDictionary(x => x.SeasonId, x => x.Name);
            lib.fillCombo(seasons, cboSeason);

            loadMatchups();
        }

        void loadMatchups()
        {
            int seasonId = Convert.ToInt32(cboSeason.SelectedValue);
            DateTime startDate = dtpDate.Value.Date;
            DateTime endDate = startDate.AddDays(1).Date;
            dgvPreseason.Rows.Clear();
            dgvRegularSeason.Rows.Clear();
            var matchups = lib.entity.Matchups.Where(x => x.SeasonId == seasonId && x.MatchupTypeId == 0);
            var matchups2 = lib.entity.Matchups.Where(x => x.SeasonId == seasonId && x.MatchupTypeId == 1);
            
            if (chkEnable.Checked)
            {
                matchups = matchups.Where(i => i.Starttime >= startDate && i.Starttime < endDate);
                matchups2 = matchups2.Where(i => i.Starttime >= startDate && i.Starttime < endDate);
            }
            foreach (var matchup in matchups)
            {
                dgvPreseason.Rows.Add(matchup.Starttime.ToString("yyyy/MM/dd"), matchup.Team.TeamName, matchup.Team1.TeamName, matchup.Starttime.ToShortTimeString(), matchup.Location, (matchup.Status == 1 ? "Yes" : "No"), null, null, matchup.MatchupId);
            }
            foreach (var matchup in matchups2)
            {
                dgvRegularSeason.Rows.Add(matchup.Starttime.ToString("yyyy/MM/dd"), matchup.Team.TeamName, matchup.Team1.TeamName, matchup.Starttime.ToShortTimeString(), matchup.Location, (matchup.Status == 1 ? "Yes" : "No"), null, null, matchup.MatchupId);
            }
        }

        private void dgvPreseason_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                if(e.ColumnIndex == 6)
                {
                    MessageBox.Show("The feature would be a future add-on to the current system.", "Update Matchup - Future Add-on");
                    return;
                }
                if(e.ColumnIndex == 7)
                {
                    int matchupId = Convert.ToInt32(dgvPreseason[8, e.RowIndex].Value);
                    bool canDelete = Convert.ToString(dgvPreseason[5, e.RowIndex].Value) == "No";
                    if (canDelete)
                    {
                        var matchup = lib.entity.Matchups.FirstOrDefault(x => x.MatchupId == matchupId);
                        lib.entity.MatchupDetails.RemoveRange(lib.entity.MatchupDetails.Where(x => x.MatchupId == matchupId));
                        lib.entity.MatchupLogs.RemoveRange(lib.entity.MatchupLogs.Where(x => x.MatchupId == matchupId));
                        lib.entity.PlayerStatistics.RemoveRange(lib.entity.PlayerStatistics.Where(x => x.MatchupId == matchupId));
                        lib.entity.Matchups.Remove(matchup);
                        if (lib.entity.SaveChanges() > 0)
                        {
                            MessageBox.Show("Save successfully!");
                            dgvPreseason.Rows.RemoveAt(e.RowIndex);
                        }
                        else
                        {
                            MessageBox.Show("Save failed!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Sorry, the game is started, you cannot delete it!");
                    }
                }
            }
        }

        private void dgvRegularSeason_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == 6)
                {
                    MessageBox.Show("The feature would be a future add-on to the current system.", "Update Matchup - Future Add-on");
                    return;
                }
                if (e.ColumnIndex == 7)
                {
                    int matchupId = Convert.ToInt32(dgvRegularSeason[8, e.RowIndex].Value);
                    bool canDelete = Convert.ToString(dgvRegularSeason[5, e.RowIndex].Value) == "No";
                    if (canDelete)
                    {
                        var matchup = lib.entity.Matchups.FirstOrDefault(x => x.MatchupId == matchupId);
                        lib.entity.MatchupDetails.RemoveRange(lib.entity.MatchupDetails.Where(x => x.MatchupId == matchupId));
                        lib.entity.MatchupLogs.RemoveRange(lib.entity.MatchupLogs.Where(x => x.MatchupId == matchupId));
                        lib.entity.PlayerStatistics.RemoveRange(lib.entity.PlayerStatistics.Where(x => x.MatchupId == matchupId));
                        lib.entity.Matchups.Remove(matchup);
                        if (lib.entity.SaveChanges() > 0)
                        {
                            MessageBox.Show("Save successfully!");
                            dgvRegularSeason.Rows.RemoveAt(e.RowIndex);
                        }
                        else
                        {
                            MessageBox.Show("Save failed!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Sorry, the game is started, you cannot delete it!");
                    }
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            loadMatchups();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            excel.Application app = new excel.Application();
            excel.Worksheet ws = app.Workbooks.Add(Type.Missing).Sheets[1];

            ws.Cells[1, 1].Value = "Date";
            ws.Cells[1, 2].Value = "Team(Away)";
            ws.Cells[1, 3].Value = "Team(Home)";
            ws.Cells[1, 4].Value = "Time";
            ws.Cells[1, 5].Value = "Location";
            ws.Cells[1, 6].Value = "Finished";
            ws.Range["A1:F1"].Font.Bold = true;
            
            for (int i = 2; i < dgvRegularSeason.Rows.Count; i++)
            {
                ws.Cells[i, 1].Value = Convert.ToString(dgvRegularSeason.Rows[i-2].Cells[0].Value);
                ws.Cells[i, 2].Value = Convert.ToString(dgvRegularSeason.Rows[i - 2].Cells[1].Value);
                ws.Cells[i, 3].Value = Convert.ToString(dgvRegularSeason.Rows[i - 2].Cells[2].Value);
                ws.Cells[i, 4].Value = Convert.ToString(dgvRegularSeason.Rows[i - 2].Cells[3].Value);
                ws.Cells[i, 5].Value = Convert.ToString(dgvRegularSeason.Rows[i - 2].Cells[4].Value);
                ws.Cells[i, 6].Value = Convert.ToString(dgvRegularSeason.Rows[i - 2].Cells[5].Value);
            }
            ws.Columns.AutoFit();
            ws.SaveAs(AppDomain.CurrentDomain.BaseDirectory + @"export.xlsx");
            app.Quit();
            Marshal.ReleaseComObject(ws);
            Marshal.ReleaseComObject(app);
            MessageBox.Show("Your file is export on the path " + AppDomain.CurrentDomain.BaseDirectory + @"export.xlsx");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lib.redirect(new frmAddNewMatchup(), this);
        }
    }
}
