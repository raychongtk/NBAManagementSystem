using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NBA1.Shared
{
    public partial class dgv : DataGridView
    {
        public dgv()
        {
            InitializeComponent();
            this.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft San Serif", 12);
            this.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            this.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
    }
}
