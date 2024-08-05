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
    public partial class QuanLi : Form
    {
        public QuanLi()
        {
            InitializeComponent();
        }

        private void btnQLNV_Click(object sender, EventArgs e)
        {
            QLNhanVien qLNhanVien = new QLNhanVien();
            qLNhanVien.Show();
        }

        private void btnQLRap_Click(object sender, EventArgs e)
        {
            Form1 rap=new Form1();
            rap.Show(); 
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
