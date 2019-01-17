using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NBA1
{
    public partial class frmPhotos : Form
    {
        int currentPage = 1;
        int totalPages = 1;
        int numPerPage = 12;
        public frmPhotos()
        {
            InitializeComponent();
        }

        void loadPhotos()
        {
            var photos = lib.entity.Pictures.OrderByDescending(x => x.CreateTime);
            totalPages = (photos.ToList().Count + numPerPage - 1) / numPerPage;
            lblTotalRecord.Text = $"Total {photos.ToList().Count} Photos, {numPerPage} Photos in one page, Total {totalPages} Pages";

            photos = photos.Skip((currentPage - 1) * numPerPage).Take(numPerPage).OrderByDescending(x => x.CreateTime);

            flowLayoutPanel1.Controls.Clear();
            foreach (var photo in photos)
            {
                Shared.ucPhoto p = new Shared.ucPhoto(lib.toImage(photo.Img), photo.Id);
                flowLayoutPanel1.Controls.Add(p);
            }
        }
        private void btnFirst_Click(object sender, EventArgs e)
        {
            currentPage = 1;
            loadPhotos();
            txtPage.Text = currentPage + "";
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                loadPhotos();
                txtPage.Text = currentPage + "";
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currentPage < totalPages)
            {
                currentPage++;
                loadPhotos();
                txtPage.Text = currentPage + "";
            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            currentPage = totalPages;
            loadPhotos();
            txtPage.Text = currentPage + "";
        }

        private void txtPage_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int num = int.Parse(txtPage.Text);
                if (num > totalPages)
                {
                    MessageBox.Show("Page cannot greater than total pages!");
                    return;
                }
                if (num < 1)
                {
                    MessageBox.Show("Page cannot less than 1");
                    return;
                }
                currentPage = num;
                loadPhotos();
            }
            catch (Exception)
            {

            }
        }
        private void btnDownload_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(AppDomain.CurrentDomain.BaseDirectory + @"download"))
            {
                Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + @"download");
            }
            foreach (Shared.ucPhoto photo in flowLayoutPanel1.Controls)
            {
                photo.pictureBox1.Image.Save(AppDomain.CurrentDomain.BaseDirectory + @"download\" + (int)photo.pictureBox1.Tag + ".jpg");
            }
            MessageBox.Show("Your photo is downloaded successfully! The path is " + AppDomain.CurrentDomain.BaseDirectory + @"download\");
        }

        private void frmPhotos_Load(object sender, EventArgs e)
        {
            loadPhotos();
        }
    }
}
