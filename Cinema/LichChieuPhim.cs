using BLL;
using DTO;
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
    
    public partial class LichChieuPhim : Form
    {
        LichChieuPhim_BLL_DAL lichbll=new LichChieuPhim_BLL_DAL();
        public LichChieuPhim()
        {
            InitializeComponent();
        }

       

        private void LichChieuPhim_Load(object sender, EventArgs e)
        {
            cboRap.DataSource = lichbll.loadRapChieuPhim();
            cboRap.DisplayMember = "TenRap";
            cboRap.ValueMember = "MaRap";

            cboPhongChieu.DisplayMember = "MaManHinh";
            cboPhongChieu.ValueMember = "MaManHInh";

            cboPhimChieu.DataSource = lichbll.LoadPhim();
            cboPhimChieu.DisplayMember = "TenPhim";
            cboPhimChieu.ValueMember = "MaPhim";
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //int maRap = (int)cboRap.SelectedValue;
            string selectedValueString = cboRap.SelectedValue.ToString();
            int maRap;

            // Sử dụng int.TryParse để phân tích chuỗi thành số nguyên an toàn
            if (int.TryParse(selectedValueString, out maRap))
            {
                // Gọi phương thức loadManHinhChieu với maRap đã phân tích
                cboPhongChieu.DataSource = lichbll.loadManHinhChieu(maRap);
            }
        }

        private void cboPhongChieu_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValueString = cboPhongChieu.SelectedValue.ToString();
            int maPhong;

            // Sử dụng int.TryParse để phân tích chuỗi thành số nguyên an toàn
            if (int.TryParse(selectedValueString, out maPhong))
            {
                // Gọi phương thức loadManHinhChieu với maRap đã phân tích
                dataGridView1.DataSource = lichbll.loadSuatChieu(maPhong);
            }
        }
        //public void load()
        //{
        //    string maXuatChieu = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        //    dataGridView1.DataSource = lichbll.loadDiem(masv);
        //}
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu bất kỳ trường nào bị để trống
            if (string.IsNullOrWhiteSpace(cboPhimChieu.Text) ||
                string.IsNullOrWhiteSpace(cboPhongChieu.Text) ||
                string.IsNullOrWhiteSpace(txtSoGheTrong.Text))
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin!");
            }
            else
            {
                if (cboPhongChieu.SelectedValue is int phongchieu)
                {
                    if (cboPhimChieu.SelectedValue is int phim)
                    {
                        DateTime ThoiDiemChieu = datThoiDiemChieu.Value;
                        lichbll.InsertSuatChieu(phim, phongchieu, ThoiDiemChieu, int.Parse(txtSoGheTrong.Text));

                        LichChieuPhim_Load(sender, e);
                        LamTrongDuLieuNhap();
                        MessageBox.Show("Thêm thành công!");
                    }

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
                if (txtMaXuat.Text == "")
                {
                    MessageBox.Show("Vui lòng chọn nội dung cần xóa!");
                }
                else
                {
                    lichbll.DeleteSuatChieu(int.Parse(txtMaXuat.Text));
                    LichChieuPhim_Load(sender, e);
                    LamTrongDuLieuNhap();
                  

                }

            
          
        }
       

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Lấy dòng hiện tại
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Điền dữ liệu từ dòng vào các TextBox hoặc điều khiển khác
                txtMaXuat.Text = row.Cells["MaSuatChieu"].Value.ToString();
                cboPhongChieu.SelectedValue = (int)row.Cells["MaManHinh"].Value;
                cboPhimChieu.SelectedValue = (int)row.Cells["MaPhim"].Value;
                datThoiDiemChieu.Value = (DateTime)row.Cells["ThoiGianChieu"].Value;
                txtSoGheTrong.Text = row.Cells["SoGheTrong"].Value.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtMaXuat.Text == "")
            {
                MessageBox.Show("Vui lòng chọn nội dung cần cập nhật!");
            }
            else
            {
                if (cboPhongChieu.SelectedValue is int phongchieu)
                {
                    if (cboPhimChieu.SelectedValue is int phim)
                    {
                        DateTime ThoiDiemChieu = datThoiDiemChieu.Value;
                        lichbll.UpdateSuatChieu(int.Parse(txtMaXuat.Text), phim, phongchieu, ThoiDiemChieu, int.Parse(txtSoGheTrong.Text));

                        LichChieuPhim_Load(sender, e);
                        LamTrongDuLieuNhap();
                        MessageBox.Show("Sửa thành công!");
                    }

                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void LamTrongDuLieuNhap()
        {
            txtMaXuat.Text = "";
            txtSoGheTrong.Text = "";
            cboPhimChieu.Text = "";
            cboPhongChieu.Text = "";
            cboRap.Text = "";
        }
        private void button5_Click(object sender, EventArgs e)
        {
            LamTrongDuLieuNhap();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
