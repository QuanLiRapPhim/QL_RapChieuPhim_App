using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;
namespace Cinema
{
    public partial class Form1 : Form
    {

        XuLiNhanVien NguoiDung=new XuLiNhanVien();
  
        string _TenDangNhap;
        public string TenDangNhap
        {
            get { return _TenDangNhap; }
            set { _TenDangNhap = value;}
        }
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
      
           // this.btnQLNhanVien.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
                List<string> nhomND =NguoiDung.getMaNhomNguoiDung(_TenDangNhap);

            //    foreach (string item in nhomND)
            //    {
            //        DataTable dsQuyen = NguoiDung.GetMaManHinh(item);
            //        foreach (DataRow mh in dsQuyen.Rows)
            //        {
            //            FindMenuPhanQuyen(this.menuStrip1.Items,mh[0].ToString(), Convert.ToBoolean(mh[1].ToString()));
            //        }
            //}

        }

        private void btnQLNhanVien_Click(object sender, EventArgs e)
        {
            QLNhanVien qlnv=new QLNhanVien();
            qlnv.Show();
        }

        private void btnQLKhachHang_Click(object sender, EventArgs e)
        {
            KhachHang khachHang = new KhachHang();
            khachHang.Show();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
            //DangNhap dn=new DangNhap();
            //dn.Show();
            
        }

        private void btnQLLoaiPhim_Click(object sender, EventArgs e)
        {
            this.Dispose();
            TheLoaiPhim dn = new TheLoaiPhim();
            dn.Show();
        }

        private void btnQLPhim_Click(object sender, EventArgs e)
        {
            Phim phim = new Phim();
            phim.Show();
        }

        private void btnQLLichChieuPhim_Click(object sender, EventArgs e)
        {
            LichChieuPhim ph=new LichChieuPhim();
            ph.Show();
        }

        private void btnQLKhuyenMai_Click(object sender, EventArgs e)
        {
            KhuyenMai khuyenMai = new KhuyenMai();
            khuyenMai.Show();
        }

        private void btnQLThucAn_Click(object sender, EventArgs e)
        {
            QuanLiRapPhim ph=new QuanLiRapPhim();
            ph.Show();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
           
           
        }

        private void btnQLVe_Click(object sender, EventArgs e)
        {
            QuanLiRapPhim quanLiRapPhim = new QuanLiRapPhim();
            quanLiRapPhim.Show();
        }

        private void btnQLVe_Click_1(object sender, EventArgs e)
        {
            Ve ve = new Ve();
            ve.Show();
        }

        private void btnTroGiup_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Liên hệ 0933888777 để được giúp đỡ","Trợ giúp", MessageBoxButtons.OK, MessageBoxIcon.Question);

        }

        private void btnGioiThieu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đây là ứng dụng được thiết kế và thực hiện bởi nhóm.\n" +
                " - Ứng dụng quản lý rạp chiếu phim thông minh giúp đơn giản hóa mọi hoạt động từ bán vé, quản lý lịch chiếu đến báo cáo.\n" +
                " - Với giao diện trực quan và dễ sử dụng, ứng dụng sẽ giúp tiết kiệm thời gian và nâng cao hiệu quả quản lý rạp chiếu phim.",
            "Giới thiệu về ứng dụng", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
