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
    public partial class frmPlayersMain : Form
    {
        int currentPage = 1;
        int totalPages = 1;
        int numPerPage = 10;

        public frmPlayersMain()
        {
            InitializeComponent();

            for (int i = 0; i < 27; i++)
            {
                Button btn = new Button();
                btn.BackColor = Color.FromArgb(105, 149, 194);
                btn.FlatAppearance.BorderSize = 0;
                btn.FlatStyle = FlatStyle.Flat;
                btn.ForeColor = Color.White;
                if (i == 0)
                {
                    btn.Size = new Size(60, 30);
                    btn.Text = "ALL";
                    btn.Click += delegate
                    {
                        foreach (Button button in flowLayoutPanel1.Controls)
                        {
                            button.FlatAppearance.BorderSize = 0;
                        }
                        btn.FlatAppearance.BorderSize = 1;
                        queryPlayers();
                    };
                }
                else
                {
                    btn.Size = new Size(40, 30);
                    btn.Text = Convert.ToString(Convert.ToChar('A' + i - 1));
                    btn.Click += delegate
                    {
                        foreach (Button button in flowLayoutPanel1.Controls)
                        {
                            button.FlatAppearance.BorderSize = 0;
                        }
                        btn.FlatAppearance.BorderSize = 1;
                        queryPlayers(btn.Text);
                    };
                }

                flowLayoutPanel1.Controls.Add(btn);
            }

            var seasons = lib.entity.Seasons.OrderByDescending(x=>x.SeasonId).ToDictionary(x => x.SeasonId, x => x.Name);
            lib.fillCombo(seasons, cboSeason);

            var teams = lib.entity.Teams.ToDictionary(x => x.TeamId, x => x.TeamName);
            lib.fillCombo(teams, cboTeam);
            queryPlayers();
        }

        void queryPlayers(string filter = "ALL", string playerName = "")
        {
            int seasonId = Convert.ToInt32(cboSeason.SelectedValue);
            int teamId = Convert.ToInt32(cboTeam.SelectedValue);

            dgvPlayers.Rows.Clear();
            var players = lib.entity.PlayerInTeams.Where(i => i.SeasonId == seasonId && i.TeamId == teamId).OrderBy(x=>x.ShirtNumber);
            if (!filter.Equals("ALL"))
                players = players.Where(x => x.Player.Name.StartsWith(filter)).OrderBy(x => x.ShirtNumber);
            if(!playerName.Equals(""))
                players = players.Where(x => x.Player.Name.Contains(playerName)).OrderBy(x => x.ShirtNumber);
            lblTotalRecord.Text = $"Total {players.ToList().Count} records, {numPerPage} records in one page";
            totalPages = (players.ToList().Count + numPerPage - 1) / numPerPage;
            players = players.Skip((currentPage - 1) * numPerPage).Take(numPerPage).OrderBy(x => x.ShirtNumber);
            lblTotalPage.Text = $"of {totalPages}";
            foreach (var player in players)
            {
                dgvPlayers.Rows.Add(lib.toImage(player.Player.Img), player.ShirtNumber, player.Player.Name, player.Team.TeamName, player.Player.Position.Abbr, player.Player.Weight, player.Player.Height, (DateTime.Today.Year - player.Player.JoinYear.Year), player.Player.Country.CountryName,player.PlayerId);
            }
        }

        private void cboSeason_SelectedIndexChanged(object sender, EventArgs e)
        {
            queryPlayers();
        }

        private void cboTeam_SelectedIndexChanged(object sender, EventArgs e)
        {
            queryPlayers();
        }

        private void txtPlayerName_TextChanged(object sender, EventArgs e)
        {
            queryPlayers("ALL",txtPlayerName.Text);
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            currentPage = 1;
            queryPlayers();
            txtPage.Text = currentPage+"";
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if(currentPage > 1)
            {
                currentPage--;
                queryPlayers();
                txtPage.Text = currentPage + "";
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if(currentPage < totalPages)
            {
                currentPage++;
                queryPlayers();
                txtPage.Text = currentPage + "";
            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            currentPage = totalPages;
            queryPlayers();
            txtPage.Text = currentPage + "";
        }

        private void txtPage_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int num = int.Parse(txtPage.Text);
                if(num > totalPages)
                {
                    MessageBox.Show("Page cannot greater than total pages!");
                    return;
                }
                if(num < 1)
                {
                    MessageBox.Show("Page cannot less than 1");
                    return;
                }
                currentPage = num;
                queryPlayers();
            }
            catch (Exception)
            {

            }
        }

        private void dgvPlayers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == 0 || e.ColumnIndex == 2)
                {
                    int playerId = Convert.ToInt32(dgvPlayers[9, e.RowIndex].Value);
                    lib.redirect(new frmPlayerDetail(playerId), this);
                }
            }
        }
    }
}
