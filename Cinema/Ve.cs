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
    public partial class Ve : Form
    {
        Ve_BLL_DAL bllVe=new Ve_BLL_DAL();
        public Ve()
        {
            InitializeComponent();
        }
        public void LamMoiDuLieuNhap()
        {
            txtMaVe.Text = "";
            txtMaKH.Text = "";
            txtMaghe.Text = "";
            txtMaXuatChieu.Text = "";
            txtSoGhe.Text = "";
            txtGia.Text = "";
            datNgayDat.Text = "";
        }
        private void Ve_Load(object sender, EventArgs e)
        {
            LamMoiDuLieuNhap();
            dataGridView1.DataSource = bllVe.LoadVe();
        }
        
        private void btnSua_Click(object sender, EventArgs e)
        {
            // Kiểm tra mã vé
            if (string.IsNullOrWhiteSpace(txtMaVe.Text))
            {
                MessageBox.Show("Vui lòng nhập mã vé cần cập nhật!");
                return;
            }

            // Kiểm tra mã khách hàng
            if (string.IsNullOrWhiteSpace(txtMaKH.Text))
            {
                MessageBox.Show("Vui lòng nhập mã khách hàng!");
                return;
            }

            // Kiểm tra mã ghế
            if (string.IsNullOrWhiteSpace(txtMaghe.Text))
            {
                MessageBox.Show("Vui lòng nhập mã ghế!");
                return;
            }

            // Kiểm tra mã xuất chiếu
            if (string.IsNullOrWhiteSpace(txtMaXuatChieu.Text))
            {
                MessageBox.Show("Vui lòng nhập mã xuất chiếu!");
                return;
            }

            // Kiểm tra số ghế
            if (string.IsNullOrWhiteSpace(txtSoGhe.Text))
            {
                MessageBox.Show("Vui lòng nhập số ghế!");
                return;
            }

            // Kiểm tra giá
            if (string.IsNullOrWhiteSpace(txtGia.Text) || !decimal.TryParse(txtGia.Text, out decimal gia))
            {
                MessageBox.Show("Vui lòng nhập giá hợp lệ!");
                return;
            }

            // Kiểm tra ngày đặt
            if (string.IsNullOrWhiteSpace(datNgayDat.Text) || !DateTime.TryParse(datNgayDat.Text, out DateTime ngayDatVe))
            {
                MessageBox.Show("Vui lòng nhập ngày đặt hợp lệ!");
                return;
            }

            // Thực hiện cập nhật vé
            try
            {
                int maVe = int.Parse(txtMaVe.Text);
                int maKhachHang = int.Parse(txtMaKH.Text);
                int maGhe = int.Parse(txtMaghe.Text);
                int maXuatChieu = int.Parse(txtMaXuatChieu.Text);
                string soGhe = txtSoGhe.Text;

                // Cập nhật thông tin vé
                bllVe.Load_Ve_Update(maVe, maXuatChieu, maKhachHang, maGhe, soGhe, gia, ngayDatVe);

                // Tải lại danh sách vé
                Ve_Load(sender,e);

                // Làm mới dữ liệu nhập
                LamMoiDuLieuNhap();

                MessageBox.Show("Cập nhật vé thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có chọn vé cần xóa hay chưa
            if (string.IsNullOrWhiteSpace(txtMaVe.Text))
            {
                MessageBox.Show("Vui lòng chọn vé cần xóa!");
                return;
            }

            // Xác nhận người dùng có muốn xóa vé không
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa vé này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    // Lấy mã vé từ ô nhập liệu
                    int maVe = int.Parse(txtMaVe.Text);

                    // Xóa vé
                    bllVe.Load_ve_delete(maVe);

                    // Tải lại danh sách vé
                    Ve_Load(sender,e);

                    // Làm mới dữ liệu nhập
                    LamMoiDuLieuNhap();

                   
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Lấy dòng hiện tại
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Điền dữ liệu từ dòng vào các TextBox hoặc điều khiển khác với kiểm tra null
                txtMaVe.Text = row.Cells["MaVe"].Value?.ToString() ?? "";
                txtMaKH.Text = row.Cells["MaKhachHang"].Value?.ToString() ?? "";
                txtMaghe.Text = row.Cells["MaGhe"].Value?.ToString() ?? "";
                txtMaXuatChieu.Text = row.Cells["MaSuatChieu"].Value?.ToString() ?? "";
                txtSoGhe.Text = row.Cells["SoGhe"].Value?.ToString() ?? "";
                txtGia.Text = row.Cells["Gia"].Value?.ToString() ?? "";

                // Kiểm tra và gán giá trị cho datNgayDat
                if (row.Cells["NgayDatVe"].Value != null && DateTime.TryParse(row.Cells["NgayDatVe"].Value.ToString(), out DateTime ngayDatVe))
                {
                    datNgayDat.Value = ngayDatVe;
                }
                else
                {
                    datNgayDat.Value = DateTime.Now; // Hoặc giá trị mặc định khác nếu cần
                }
            }
        }

    }
}
