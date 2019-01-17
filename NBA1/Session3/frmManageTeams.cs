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
    public partial class frmManageTeams : Form
    {
        public frmManageTeams()
        {
            InitializeComponent();

            var conferences = new Dictionary<int, string>
            {
                {-1,"All" }
            };
            conferences = conferences.Concat(lib.entity.Conferences.ToDictionary(x => x.ConferenceId, x => x.Name)).ToDictionary(x=>x.Key,x=>x.Value);
            lib.fillCombo(conferences, cboConference);

            var divisions = new Dictionary<int, string>
            {
                {-1,"All" }
            };
            divisions = divisions.Concat(lib.entity.Divisions.ToDictionary(x => x.DivisionId, x => x.Name)).ToDictionary(x => x.Key, x => x.Value);
            lib.fillCombo(divisions, cboDivision);

            loadTeams();
        }

        void loadTeams(string teamName = "")
        {
            int conferenceId = Convert.ToInt32(cboConference.SelectedValue);
            int divisionId = Convert.ToInt32(cboDivision.SelectedValue);

            dgvTeams.Rows.Clear();
            var teams = lib.entity.Teams.Select(x=> x);
            if(conferenceId != -1)
            {
                teams = teams.Where(x => x.Division.ConferenceId == conferenceId);
            }
            if (divisionId != -1)
            {
                teams = teams.Where(x => x.DivisionId == divisionId);
            }
            if (!teamName.Equals(""))
            {
                teams = teams.Where(x => x.TeamName.Contains(txtName.Text));
            }

            foreach (var team in teams)
            {
                dgvTeams.Rows.Add(lib.toImage(team.Logo), team.TeamName, team.Division.Conference.Name, team.Division.Name, team.Coach, team.PlayerInTeams.Sum(x => x.Salary));
            }
            lblTotal.Text = "Total teams: " + dgvTeams.Rows.Count;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            loadTeams(txtName.Text);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The feature would be a future add-on to the current system.", "Add new team - Future Add-on");
        }
    }
}
