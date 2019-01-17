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
    public partial class frmMatachupList : Form
    {
        public frmMatachupList()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Value = dateTimePicker1.Value.AddDays(1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Value = dateTimePicker1.Value.AddDays(-1);
        }

        void searchMatchup()
        {
            DateTime startDate = dateTimePicker1.Value.Date;
            DateTime endDate = startDate.AddDays(1).Date;

            var matchups = lib.entity.Matchups.Where(i => i.Starttime >= startDate && i.Starttime < endDate);


            if (matchups.Count() == 0)
            {
                MessageBox.Show("No result!");
                return;
            }

            var closeset = lib.entity.Matchups.ToList().OrderBy(x => Math.Abs((DateTime.Now - x.Starttime).TotalMilliseconds)).FirstOrDefault();

            if (closeset != null)
            {
                picTeamAway.Image = lib.toImage(closeset.Team.Logo);
                picTeamHome.Image = lib.toImage(closeset.Team1.Logo);
                lblTeamAway.Text = closeset.Team.TeamName;
                lblTeamHome.Text = closeset.Team1.TeamName;
                lblStartTime.Text = closeset.Starttime.ToString("hh:mm") + " Start";
            }

            flowLayoutPanel1.Controls.Clear();
            foreach (var matchup in matchups)
            {
                Shared.ucMatchup m = new Shared.ucMatchup(matchup.MatchupId);
                flowLayoutPanel1.Controls.Add(m);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            searchMatchup();
        }
    }
}
