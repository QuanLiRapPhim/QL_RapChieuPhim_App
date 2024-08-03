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
using static System.Net.Mime.MediaTypeNames;

namespace Cinema
{
    public partial class Phim : Form
    {
        Phim_BLL_DAL bllphim=new Phim_BLL_DAL();
        public Phim()
        {
            InitializeComponent();
            this.Load += Phim_Load;

        }

        private void Phim_Load(object sender, EventArgs e)
        {
            //dataGridView1.DataSource = bllphim.LoadPhim();
            cboTheLoai.DataSource = bllphim.loadTheLoai();
            cboTheLoai.DisplayMember = "TenTheLoai";
            cboTheLoai.ValueMember = "MaTheLoai";
        }

        private void cboTheLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTheLoai.SelectedValue is int maTheLoai)
            {
                // Tải danh sách phim với mã thể loại đã chọn
                dataGridView1.DataSource = bllphim.LoadPhim(maTheLoai);
            }
        }

        private void btnThemHinhAnh_Click(object sender, EventArgs e)
        {
            // Tạo một hộp thoại chọn tệp tin
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                // Thiết lập bộ lọc để chỉ hiển thị các tệp ảnh
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                openFileDialog.Title = "Chọn ảnh";

                // Hiển thị hộp thoại chọn tệp tin
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Lấy đường dẫn đầy đủ của tệp ảnh được chọn
                    string selectedFilePath = openFileDialog.FileName;

                    // Lấy tên tệp từ đường dẫn
                    string fileName = System.IO.Path.GetFileName(selectedFilePath);

                    // Gán tên tệp vào TextBox txtHinhAnh
                    txtHinhAnh.Text = fileName;

                    // Thực hiện các hành động khác nếu cần, ví dụ: hiển thị ảnh
                    // pictureBox.Image = Image.FromFile(selectedFilePath);
                }
            }
        }

        private void btnThemPhim_Click(object sender, EventArgs e)
        {
            if (cboTheLoai.SelectedValue is int maTheLoai)
            {
                DateTime ngayKhoiChieu = Dat_ngaykhoichieu.Value;
                bllphim.InsertPhim( txtTenPhim.Text, maTheLoai,txtDaoDien.Text,int.Parse(txtThoiLuong.Text),
                    txtTomTat.Text, ngayKhoiChieu, txtHinhAnh.Text);
                Phim_Load(sender, e );
                MessageBox.Show("Thêm thành công!");
            }
        
           
        }

        private void btnXoaPhim_Click(object sender, EventArgs e)
        {
            bllphim.Load_phim_delete(int.Parse(txtMaPhim.Text));
            Phim_Load(sender,e);
            MessageBox.Show("Xóa thành công!");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem dòng hiện tại có hợp lệ không
            if (e.RowIndex >= 0)
            {
                // Lấy dòng hiện tại
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Điền dữ liệu từ dòng vào các TextBox
                txtMaPhim.Text = row.Cells["MaPhim"].Value.ToString();
                txtTenPhim.Text = row.Cells["TenPhim"].Value.ToString();
                cboTheLoai.SelectedValue = (int)row.Cells["MaTheLoai"].Value;
                txtDaoDien.Text = row.Cells["DaoDien"].Value.ToString();
                txtThoiLuong.Text = row.Cells["ThoiLuong"].Value.ToString();
                txtTomTat.Text = row.Cells["TomTat"].Value.ToString();
                Dat_ngaykhoichieu.Value = (DateTime)row.Cells["NgayKhoiChieu"].Value;
                txtHinhAnh.Text = row.Cells["HinhAnh"].Value.ToString();
                
            }
        }

        private void btnSuaPhim_Click(object sender, EventArgs e)
        {
            if (cboTheLoai.SelectedValue is int maTheLoai)
            {
                DateTime ngayKhoiChieu = Dat_ngaykhoichieu.Value;
                bllphim.UpdatePhim(int.Parse(txtMaPhim.Text),txtTenPhim.Text, maTheLoai, txtDaoDien.Text, int.Parse(txtThoiLuong.Text),
                    txtTomTat.Text, ngayKhoiChieu, txtHinhAnh.Text);
                Phim_Load(sender, e);
                MessageBox.Show("Sửa thành công!");
            }
        }

        private void Phim_Load_1(object sender, EventArgs e)
        {

        }
    }
}
