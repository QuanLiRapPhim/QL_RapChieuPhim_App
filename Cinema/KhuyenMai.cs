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
    public partial class KhuyenMai : Form
    {
        KhuyenMai_BLL_DAL dllKM=new KhuyenMai_BLL_DAL();
        public KhuyenMai()
        {
            InitializeComponent();
        }
        public void LamTrongDuLieuNhap()
        {
            txtTieuDe.Text = "";
            txtGiamGia.Text = "";
            txtMoTa.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DateTime ngayBatDau = datNgayBatDau.Value;
            DateTime ngayKetThuc=datNgayKetThuc.Value;
            decimal giamGia = Convert.ToDecimal(txtGiamGia.Text);
            dllKM.InsertKhuyenMai(txtTieuDe.Text, txtMoTa.Text, giamGia, ngayBatDau, ngayKetThuc);
            KhuyenMai_Load(sender, e);
            MessageBox.Show("Thêm thành công!");
            LamTrongDuLieuNhap();
        }
        
        private void KhuyenMai_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource= dllKM.loadKhuyenMai();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtMaKM.Text = row.Cells["MaKhuyenMai"].Value.ToString();
                txtTieuDe.Text = row.Cells["TieuDe"].Value.ToString();
                txtMoTa.Text = row.Cells["MoTa"].Value.ToString();

                // Chuyển đổi giá trị GiamGia sang chuỗi
                decimal giamGia = (decimal)row.Cells["GiamGia"].Value;
                txtGiamGia.Text = giamGia.ToString();

                datNgayBatDau.Value = (DateTime)row.Cells["NgayBatDau"].Value;
                datNgayKetThuc.Value = (DateTime)row.Cells["NgayKetThuc"].Value;
            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            dllKM.DeleteKhuyenMai(int.Parse(txtMaKM.Text));
            KhuyenMai_Load(sender, e);
            MessageBox.Show("Xóa thành công");
            LamTrongDuLieuNhap();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DateTime ngayBatDau = datNgayBatDau.Value;
            DateTime ngayKetThuc = datNgayKetThuc.Value;
            decimal giamGia = Convert.ToDecimal(txtGiamGia.Text);
            dllKM.UpdateKhuyenMai(int.Parse(txtMaKM.Text),txtTieuDe.Text, txtMoTa.Text, giamGia, ngayBatDau, ngayKetThuc);
            KhuyenMai_Load(sender, e);
            MessageBox.Show("Sửa thành công");
            LamTrongDuLieuNhap();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            LamTrongDuLieuNhap();
        }
    }
}
