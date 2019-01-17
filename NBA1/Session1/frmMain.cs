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
    public partial class frmMain : Form
    {
        int currentPage = 1;
        int totalPages = 1;
        int numOfPage = 3;
        public frmMain()
        {
            InitializeComponent();
            loadImages();
        }

        public void loadImages()
        {
            var pics = lib.entity.Pictures.OrderByDescending(x => x.CreateTime).Skip((currentPage - 1) * numOfPage).Take(numOfPage);
            int picCount = lib.entity.Pictures.Count();
            totalPages = (picCount + numOfPage - 1) / numOfPage;
            pictureBox2.Image = lib.toImage(pics.ToList()[0]?.Img);
            pictureBox3.Image = lib.toImage(pics.ToList()[1]?.Img);
            pictureBox4.Image = lib.toImage(pics.ToList()[2]?.Img);
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                loadImages();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currentPage < totalPages)
            {
                currentPage++;
                loadImages();
            }
        }

        private void btnVisitor_Click(object sender, EventArgs e)
        {
            lib.redirect(new frmVisitor(), this);
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            lib.redirect(new frmLogin(), this);
        }
    }
}
