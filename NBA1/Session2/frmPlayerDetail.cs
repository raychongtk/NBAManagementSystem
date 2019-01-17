using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace NBA1
{
    public partial class frmPlayerDetail : Form
    {
        int playerId;
        public frmPlayerDetail(int playerId)
        {
            InitializeComponent();
            this.playerId = playerId;
            var player = lib.entity.PlayerInTeams.FirstOrDefault(x => x.PlayerId == playerId);
            lblName.Text = player.Player.Name;
            lblInfo.Text = $"#{player.ShirtNumber} | {player.Player.Height} | {player.Team.TeamName}";
            lblBorn.Text = player.Player.DateOfBirth.ToString("yyyy-MM-dd");
            lblCollege.Text = player.Player.College;
            lblExp.Text = (DateTime.Today.Year - player.Player.JoinYear.Year) + " Years";
            lblSalary.Text = "$" + player.Salary;
            pictureBox1.Image = lib.toImage(player.Player.Img);
            try
            {
                var ppg = lib.entity.PlayerStatistics.Where(i => i.PlayerId == playerId && i.Matchup.SeasonId == 3).Average(i => i.Point);
                var apg = lib.entity.PlayerStatistics.Where(i => i.PlayerId == playerId && i.Matchup.SeasonId == 3).Average(i => i.Assist);
                var rpg = lib.entity.PlayerStatistics.Where(i => i.PlayerId == playerId && i.Matchup.SeasonId == 3).Average(i => i.Rebound);
                var ppg2 = lib.entity.PlayerStatistics.Where(i => i.PlayerId == playerId && i.Matchup.SeasonId != 3).Average(i => i.Point);
                var apg2 = lib.entity.PlayerStatistics.Where(i => i.PlayerId == playerId && i.Matchup.SeasonId != 3).Average(i => i.Assist);
                var rpg2 = lib.entity.PlayerStatistics.Where(i => i.PlayerId == playerId && i.Matchup.SeasonId != 3).Average(i => i.Rebound);
                lblPPG1.Text = ppg.ToString("f2");
                lblAPG1.Text = apg.ToString("f2");
                lblRPG1.Text = rpg.ToString("f2");
                lblPPG2.Text = ppg2.ToString("f2");
                lblAPG2.Text = apg2.ToString("f2");
                lblRPG2.Text = rpg2.ToString("f2");
            }
            catch (Exception)
            {
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadChart(1);
        }

        void loadChart(int index)
        {
            DateTime startDate = dateTimePicker1.Value.Date;
            DateTime endDate = dateTimePicker2.Value.Date;

            var stats = lib.entity.PlayerStatistics.Where(i => i.PlayerId == playerId && (i.Matchup.Starttime >= startDate && i.Matchup.Starttime < endDate)).GroupBy(g => g.MatchupId)
                .Select(x => new
                {
                    date = x.FirstOrDefault().Matchup.Starttime,
                    points = x.Average(i => i.Point),
                    rebounds = x.Average(i => i.Rebound),
                    assists = x.Average(i => i.Assist),
                    steals = x.Average(i => i.Steal),
                    blocks = x.Average(i => i.Block)
                });

            chart1.Series.Clear();
            chart1.Titles.Clear();
            Series series = new Series();
            series.ChartType = SeriesChartType.Line;
            series.IsVisibleInLegend = false;
            series.BorderWidth = 3;
            foreach (var item in stats)
            {
                series.Points.AddXY(item.date.ToString("M/d"), lib.getProperty(item,index));
            }
            double avg = 0.0;
            string title = "";
            if(index == 1)
            {
                avg = stats.Average(x => x.points);
                title = "Points";
            }
            else if(index == 2)
            {
                avg = stats.Average(x => x.rebounds);
                title = "Rebounds";
            }
            else if (index == 3)
            {
                avg = stats.Average(x => x.assists);
                title = "Assists";
            }
            else if (index == 4)
            {
                avg = stats.Average(x => x.steals);
                title = "Steals";
            }
            else if (index == 5)
            {
                avg = stats.Average(x => x.blocks);
                title = "Blocks";
            }
            label11.Text = "The average of points:" + avg.ToString("f2");
            chart1.Series.Add(series);
            chart1.Titles.Add(title);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            loadChart(1);
            button2.BackColor = Color.DeepSkyBlue;
            button3.BackColor = Color.Gainsboro;
            button4.BackColor = Color.Gainsboro;
            button5.BackColor = Color.Gainsboro;
            button6.BackColor = Color.Gainsboro;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            loadChart(2);
            button3.BackColor = Color.DeepSkyBlue;
            button2.BackColor = Color.Gainsboro;
            button4.BackColor = Color.Gainsboro;
            button5.BackColor = Color.Gainsboro;
            button6.BackColor = Color.Gainsboro;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            loadChart(3);
            button4.BackColor = Color.DeepSkyBlue;
            button3.BackColor = Color.Gainsboro;
            button2.BackColor = Color.Gainsboro;
            button5.BackColor = Color.Gainsboro;
            button6.BackColor = Color.Gainsboro;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            loadChart(4);
            button5.BackColor = Color.DeepSkyBlue;
            button3.BackColor = Color.Gainsboro;
            button4.BackColor = Color.Gainsboro;
            button2.BackColor = Color.Gainsboro;
            button6.BackColor = Color.Gainsboro;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            loadChart(5);
            button6.BackColor = Color.DeepSkyBlue;
            button3.BackColor = Color.Gainsboro;
            button4.BackColor = Color.Gainsboro;
            button5.BackColor = Color.Gainsboro;
            button2.BackColor = Color.Gainsboro;
        }
    }
}
