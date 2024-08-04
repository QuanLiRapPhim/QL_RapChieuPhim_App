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
            // Kiểm tra nếu bất kỳ trường nào bị để trống
            if (string.IsNullOrWhiteSpace(txtTenTL.Text))
            {
                MessageBox.Show("Vui lòng nhập tên thể loại!");
            }
            else
            {
                try
                {
                    // Thêm thể loại vào cơ sở dữ liệu
                    TL_DAL.InsertTheLoai(txtTenTL.Text);

                    // Tải lại dữ liệu thể loại phim và làm trống dữ liệu nhập
                    TheLoaiPhim_Load(sender, e);
                    LamTrongDuLieuNhap();

                    // Hiển thị thông báo thêm thành công
                    MessageBox.Show("Thêm thể loại thành công!");
                }
                catch (Exception ex)
                {
                    // Xử lý ngoại lệ chung và hiển thị thông báo lỗi
                    MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
                }
            }
        }


        private void btnSua_Click(object sender, EventArgs e)
        {

            if (txtMaTL.Text == "")
            {
                MessageBox.Show("Vui lòng chọn nội dung cần xóa!");
            }
            else
            {
                TL_DAL.UpdateTheLoai(int.Parse(txtMaTL.Text), txtTenTL.Text);
                TheLoaiPhim_Load(sender, e);
                LamTrongDuLieuNhap();
                MessageBox.Show("Sửa thành công!");
            }
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
            //
            if (txtTenTL.Text == "")
            {
                MessageBox.Show("Vui lòng chọn nội dung cần xóa!");
            }
            else
            {
                TL_DAL.DeleteTheLoai(int.Parse(txtMaTL.Text));
                TheLoaiPhim_Load(sender, e);
                LamTrongDuLieuNhap();
            }
          
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void LamTrongDuLieuNhap()
        {
            txtMaTL.Text = "";
            txtTenTL.Text = "";
        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            LamTrongDuLieuNhap();
        }
    }
}
