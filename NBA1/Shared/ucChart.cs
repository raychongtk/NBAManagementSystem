using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NBA1.Shared
{
    public partial class ucChart : UserControl
    {
        public ucChart(Image img, string playerName)
        {
            InitializeComponent();
            picIcon.Image = img;
            lblPlayer.Text = playerName;
        }
    }
}
