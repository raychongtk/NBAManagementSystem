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
    public partial class frmTeams : Form
    {
        public frmTeams()
        {
            InitializeComponent();

            var teams = lib.entity.Teams.OrderBy(i => i.Division.Name).ThenBy(i => i.TeamName);

            foreach (var team in teams)
            {
                Shared.team ucTeam = new Shared.team(lib.toImage(team.Logo), team.TeamName, team.TeamId);
                switch (team.DivisionId)
                {
                    case 3:
                        flowLayoutPanel1.Controls.Add(ucTeam);
                        break;
                    case 2:
                        flowLayoutPanel2.Controls.Add(ucTeam);
                        break;
                    case 1:
                        flowLayoutPanel3.Controls.Add(ucTeam);
                        break;
                    case 4:
                        flowLayoutPanel4.Controls.Add(ucTeam);
                        break;
                    case 6:
                        flowLayoutPanel5.Controls.Add(ucTeam);
                        break;
                    case 5:
                        flowLayoutPanel6.Controls.Add(ucTeam);
                        break;

                }
            }
        }
    }
}
