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
    public partial class DangNhap : Form
    {
        NhanVien CauHinh = new NhanVien();
        public DangNhap()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTaiKhoan.Text.Trim()))
            {
                MessageBox.Show("Không được bỏ trống" + lblTaiKhoan.Text.ToLower());
                this.txtTaiKhoan.Focus();
                return;
            }
            if (string.IsNullOrEmpty(this.txtMatKhau.Text))
            {
                MessageBox.Show("Không được bỏ trống" + lblMatKhau.Text.ToLower());
                this.txtMatKhau.Focus();
                return;
            }
            ProcessLogin();
            //int kq = CauHinh.Check_Config(); //hàm Check_Config() thuộc Class QL_NguoiDung
            //if (CauHinh.Check_Config() == 0)
            //{
            //    ProcessLogin();// Cấu hình phù hợp xử lý đăng nhập
            //}
            //if (CauHinh.Check_Config() == 1)
            //{
            //    MessageBox.Show("Chuỗi cấu hình không tồn tại");// Xử lý cấu hình
            //    //ProcessConfig();
            //}
            //if (CauHinh.Check_Config() == 2)
            //{
            //    MessageBox.Show("Chuỗi cấu hình không phù hợp");// Xử lý cấu hình
            //    //ProcessConfig();
            //}
           
        }
        public void ProcessLogin()
        {
            var (result, userGroup) = CauHinh.Check_User(txtTaiKhoan.Text, txtMatKhau.Text);

            if (result == 100)
            {
                MessageBox.Show("Sai " + lblTaiKhoan.Text + " Hoặc " + lblMatKhau.Text);
                return;
            }
            else if (result == 200)
            {
                MessageBox.Show("Tài khoản bị khóa");
                return;
            }

            if (Program.frm_mainForm == null || Program.frm_mainForm.IsDisposed)
            {

                // Set GroupBox1 visibility based on user group
                if (userGroup == 1)
                {
                   // Program.frm_mainForm.
                   QuanLi quanLi = new QuanLi();
                    quanLi.Show();
                }
                else if (userGroup == 2)
                {
                   // Program.frm_mainForm.GroupBox1.Visible = false;
                   Form1 form1 = new Form1();
                    form1.Show();   
                }
            }


        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
