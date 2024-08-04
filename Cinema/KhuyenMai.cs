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
            // Kiểm tra nếu các trường cần thiết không được để trống
            if (string.IsNullOrWhiteSpace(txtTieuDe.Text) ||
                string.IsNullOrWhiteSpace(txtGiamGia.Text) ||
                string.IsNullOrWhiteSpace(txtMoTa.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.");
                return;
            }

            // Kiểm tra định dạng của trường giảm giá
            if (!decimal.TryParse(txtGiamGia.Text, out decimal giamGia))
            {
                MessageBox.Show("Giảm giá phải là một số hợp lệ.");
                return;
            }

            // Kiểm tra nếu giảm giá nằm trong phạm vi hợp lệ (ví dụ: từ 0 đến 100)
            if (giamGia < 0 || giamGia > 100)
            {
                MessageBox.Show("Giảm giá phải nằm trong khoảng từ 0 đến 100.");
                return;
            }

            DateTime ngayBatDau = datNgayBatDau.Value;
            DateTime ngayKetThuc = datNgayKetThuc.Value;

            // Kiểm tra nếu ngày bắt đầu và ngày kết thúc hợp lệ
            if (ngayBatDau > ngayKetThuc)
            {
                MessageBox.Show("Ngày bắt đầu phải trước ngày kết thúc.");
                return;
            }

            // Thêm khuyến mãi nếu tất cả dữ liệu nhập hợp lệ
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
            if (txtMaKM.Text == "")
            {
                MessageBox.Show("Vui lòng chọn nội dung cần xóa!");
            }
            else
            {
                dllKM.DeleteKhuyenMai(int.Parse(txtMaKM.Text));
                KhuyenMai_Load(sender, e);
                LamTrongDuLieuNhap();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaKM.Text == "")
            {
                MessageBox.Show("Vui lòng chọn nội dung cần cập nhật!");
            }
            else
            {
                DateTime ngayBatDau = datNgayBatDau.Value;
                DateTime ngayKetThuc = datNgayKetThuc.Value;
                decimal giamGia = Convert.ToDecimal(txtGiamGia.Text);
                dllKM.UpdateKhuyenMai(int.Parse(txtMaKM.Text), txtTieuDe.Text, txtMoTa.Text, giamGia, ngayBatDau, ngayKetThuc);
                KhuyenMai_Load(sender, e);
                MessageBox.Show("Sửa thành công");
                LamTrongDuLieuNhap();
            }
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
