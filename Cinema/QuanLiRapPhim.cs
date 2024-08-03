using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema
{
    public partial class QuanLiRapPhim : Form
    {
        public QuanLiRapPhim()
        {
            InitializeComponent();
        }
        private Form currentFormChild;
        private void openChildform(Form childform)
        {
            if(currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childform;
            childform.TopLevel=false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            panlBody.Controls.Add(childform);
            panlBody.Tag = childform;
            childform.BringToFront();
            childform.Show();
        }

        private void btnTheLoai_Click(object sender, EventArgs e)
        {
            TheLoaiPhim phim=new TheLoaiPhim();
            openChildform(phim);
        }

        private void btnLichChieu_Click(object sender, EventArgs e)
        {
            LichChieuPhim lichChieuPhim = new LichChieuPhim();
            openChildform(lichChieuPhim);
        }

        private void btnPhim_Click(object sender, EventArgs e)
        {
            Phim phim = new Phim();
            openChildform(phim);
        }
    }
}
