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
    public partial class QLNhanVien : Form
    {
        public QLNhanVien()
        {
            InitializeComponent();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NhanVien frm = new NhanVien();
            frm.Show();
        }

        private void nhómNgườiDùngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NhomNguoiDung frm = new NhomNguoiDung();
            frm.Show();
        }

        private void thêmNgườiDùngVàoNhómToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void quảnLíNhómNgườiDùngToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void phânQuyềnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnThemVaoNhom frm = new btnThemVaoNhom();
            frm.Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
       
        }
    }
}
