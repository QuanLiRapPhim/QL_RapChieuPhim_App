using BLL;
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
    public partial class TheLoaiPhim : Form
    {
        TheLoaiPhim_BLL_DAL TL_DAL=new TheLoaiPhim_BLL_DAL();
        public TheLoaiPhim()
        {
            InitializeComponent();
        }

        private void TheLoaiPhim_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = TL_DAL.loadTheLoai();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            TL_DAL.InsertTheLoai(txtTenTL.Text);
            TheLoaiPhim_Load(sender, e);
            MessageBox.Show("Thêm thành công!");

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            TL_DAL.UpdateTheLoai(int.Parse(txtMaTL.Text),txtTenTL.Text);
            TheLoaiPhim_Load(sender, e);
            MessageBox.Show("Sửa thành công!");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row= dataGridView1.Rows[e.RowIndex];
                txtMaTL.Text = row.Cells["MaTheLoai"].Value.ToString();
                txtTenTL.Text = row.Cells["TenTheLoai"].Value.ToString();
            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            TL_DAL.DeleteTheLoai(int.Parse(txtMaTL.Text));
            TheLoaiPhim_Load(sender,e);
            MessageBox.Show("Xóa thành công!");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
