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
    public partial class frmTeamDetail : Form
    {
        int teamId;
        public frmTeamDetail(int teamId, int tab)
        {
            InitializeComponent();
            this.teamId = teamId;
            tabControl1.SelectTab(tab);
            var team = lib.entity.Teams.FirstOrDefault(i => i.TeamId == teamId);
            picLogo.Image = lib.toImage(team.Logo);
            lblTeam.Text = team.TeamName + " | " + team.Division.Name + " of " + team.Division.Conference.Name;


            var seasons = lib.entity.Seasons.OrderByDescending(x=>x.SeasonId).ToDictionary(x => x.SeasonId, x => x.Name);
            lib.fillCombo(seasons, cboSeason);

            loadData(3);
        }

        void loadData(int seasonId)
        {
            dgvRoster.DataSource = lib.entity.PlayerInTeams.Where(i => i.TeamId == teamId && i.SeasonId == seasonId).OrderBy(x => x.ShirtNumber).AsEnumerable().Select(i => new
            {
                No = i.ShirtNumber,
                Name = i.Player.Name,
                Position = i.Player.Position.Name,
                DateofBirth = i.Player.DateOfBirth.ToString("yyyy-MM-dd"),
                College = i.Player.College,
                Experience = (DateTime.Today.Year - i.Player.JoinYear.Year),
                Salary = (i.Salary * 1000000).ToString("C")
            }).ToList();
            dgvRoster.Columns[0].HeaderText = "No.";

            dgvMatchup.DataSource = lib.entity.Matchups.Where(i => i.SeasonId == seasonId && i.Team_Home == teamId).OrderBy(i => i.Starttime).AsEnumerable().Select(i => new
            {
                Date = i.Starttime.ToString("yyyy-MM-dd"),
                MatchupType = i.MatchupType.Name,
                Opponnet = i.Team.TeamName,
                Starttime = i.Starttime.ToShortTimeString(),
                Result = i.Team_Away_Score + "-" + i.Team_Home_Score,
                Location = i.Location,
                Status = lib.getStatus(i.Status)
            }).ToList();
            dgvMatchup.Columns[1].HeaderText = "Matchup Type";
            dgvMatchup.Columns[3].HeaderText = "Start Time";

            var pf = lib.entity.PlayerInTeams.Where(i => i.Player.PositionId == 2 && i.SeasonId == seasonId).OrderBy(i => i.StarterIndex);
            label2.Text = pf.ToList()[0].Player.Name;
            label3.Text = "";
            foreach (var item in pf.Skip(1))
            {
                label3.Text += item.Player.Name + "\r\n";
            }

            var sg = lib.entity.PlayerInTeams.Where(i => i.Player.PositionId == 4 && i.SeasonId == seasonId).OrderBy(i => i.StarterIndex);
            label6.Text = sg.ToList()[0].Player.Name;
            label5.Text = "";
            foreach (var item in sg.Skip(1))
            {
                label5.Text += item.Player.Name + "\r\n";
            }

            var c = lib.entity.PlayerInTeams.Where(i => i.Player.PositionId == 3 && i.SeasonId == seasonId).OrderBy(i => i.StarterIndex);
            label9.Text = c.ToList()[0].Player.Name;
            label8.Text = "";
            foreach (var item in c.Skip(1))
            {
                label8.Text += item.Player.Name + "\r\n";
            }

            var sf = lib.entity.PlayerInTeams.Where(i => i.Player.PositionId == 1 && i.SeasonId == seasonId).OrderBy(i => i.StarterIndex);
            label15.Text = sf.ToList()[0].Player.Name;
            label14.Text = "";
            foreach (var item in sf.Skip(1))
            {
                label14.Text += item.Player.Name + "\r\n";
            }

            var pg = lib.entity.PlayerInTeams.Where(i => i.Player.PositionId == 5 && i.SeasonId == seasonId).OrderBy(i => i.StarterIndex);
            label12.Text = pg.ToList()[0].Player.Name;
            label11.Text = "";
            foreach (var item in pg.Skip(1))
            {
                label11.Text += item.Player.Name + "\r\n";
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int seasonId = Convert.ToInt32(cboSeason.SelectedValue);
            loadData(seasonId);
        }
    }
}
