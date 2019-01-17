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
    public partial class frmManagePlayers : Form
    {
        public frmManagePlayers()
        {
            InitializeComponent();

            var positions = new Dictionary<int, string>
            {
                {-1,"All" }
            };
            positions = positions.Concat(lib.entity.Positions.ToDictionary(x => x.PositionId, x => x.Name)).ToDictionary(x=>x.Key,x=>x.Value);
            lib.fillCombo(positions, cboPosition);

            var countries = new Dictionary<string, string>
            {
                {"All","All" }
            };
            countries = countries.Concat(lib.entity.Countries.ToDictionary(x => x.CountryCode, x => x.CountryName)).ToDictionary(x => x.Key, x => x.Value);
            lib.fillCombo(countries, cboCountry);

            loadPlayers();
        }

        void loadPlayers(string playerName = "")
        {
            int posId = Convert.ToInt32(cboPosition.SelectedValue);
            string countryCode = Convert.ToString(cboCountry.SelectedValue);

            dgvPlayers.Rows.Clear();
            var players = lib.entity.Players.Select(x=> x);
            if(posId != -1)
            {
                players = players.Where(x => x.PositionId == posId);
            }
            if (countryCode != "All")
            {
                players = players.Where(x => x.CountryCode.Equals(countryCode));
            }
            if (!playerName.Equals(""))
            {
                players = players.Where(x => x.Name.Contains(txtName.Text));
            }

            foreach (var player in players)
            {
                dgvPlayers.Rows.Add(player.Name, player.Position.Name, player.JoinYear.ToString("yyyy-MM-dd"), player.Height, player.Weight, player.DateOfBirth.ToString("yyyy-MM-dd"), player.College, player.Country.CountryName);
            }
            lblTotal.Text = "Total players: " + dgvPlayers.Rows.Count;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            loadPlayers(txtName.Text);
        }
    }
}
