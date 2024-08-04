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
    public partial class KhachHang : Form
    {
        KhachHang_BLL_DAL bllkh = new KhachHang_BLL_DAL();
        public KhachHang()
        {
            InitializeComponent();
            this.Load += KhachHang_Load;
          
            
        }
     

      

        private void KhachHang_Load(object sender, EventArgs e)
        {

            dataGridView1.DataSource = bllkh.LoadKhachHang();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtMaKH.Text == "")
            {
                MessageBox.Show("Vui lòng chọn nội dung cần cập nhật!");
            }
            else
            {
                int makh = Convert.ToInt32(dataGridView1.CurrentRow.Cells["MaKhachHang"].Value);
                bllkh.Load_kh_delete(makh);
                KhachHang_Load(sender, e);
          
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaKH.Text == "")
            {
                MessageBox.Show("Vui lòng chọn nội dung cần cập nhật!");
            }
            else
            {
                int maKH = Convert.ToInt32(txtMaKH.Text);
                bllkh.Load_kh_update(maKH, txtTenKH.Text, txtEmail.Text, txtSDT.Text, txtDiaChi.Text, txtMatKhau.Text);
                KhachHang_Load(sender, e);
                MessageBox.Show("Sửa thành công!");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem dòng hiện tại có hợp lệ không
            if (e.RowIndex >= 0)
            {
                // Lấy dòng hiện tại
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Điền dữ liệu từ dòng vào các TextBox
                txtMaKH.Text = row.Cells["MaKhachHang"].Value.ToString();
                txtTenKH.Text = row.Cells["TenKhachHang"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();
                txtSDT.Text = row.Cells["SoDienThoai"].Value.ToString();
                txtDiaChi.Text = row.Cells["DiaChi"].Value.ToString();
                txtMatKhau.Text = row.Cells["MatKhau"].Value.ToString();
            }
        }

        private void KhachHang_Load_1(object sender, EventArgs e)
        {

        }
    }
}
