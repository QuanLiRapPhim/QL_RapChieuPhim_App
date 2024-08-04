using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLL
{
    public class KhachHang_BLL_DAL
    {
        ManageCinemaDataContext cinema=new ManageCinemaDataContext();
        public KhachHang_BLL_DAL()
        {

        }
        public List<KhachHang> LoadKhachHang()
        {
            return cinema.KhachHangs.Select(kh=>kh).ToList<KhachHang>();
        }


        public void Load_kh_delete(int makh)
        {
            // Tìm khách hàng cần xóa
            KhachHang dm = cinema.KhachHangs.Where(kh => kh.MaKhachHang == makh).FirstOrDefault();

            if (dm == null)
            {
                MessageBox.Show("Khách hàng không tồn tại.");
                return;
            }

            // Kiểm tra sự tồn tại trong các bảng liên quan
            bool hasOrders = cinema.DonHangThucAns.Any(dh => dh.MaKhachHang == makh);
            bool hasReviews = cinema.DanhGiaPhims.Any(dg => dg.MaKhachHang == makh);
            bool hasVe = cinema.Ves.Any(ve => ve.MaKhachHang == makh);

            if (hasOrders || hasReviews || hasVe)
            {
                MessageBox.Show("Không thể xóa khách hàng vì thông tin có liên quan đến Vé, Đánh giá phim hoặc Đơn hàng thức ăn");
            }
            else
            {
                // Xóa khách hàng khỏi tập hợp KhachHangs
                cinema.KhachHangs.DeleteOnSubmit(dm);
                cinema.SubmitChanges();

                MessageBox.Show("Khách hàng đã được xóa thành công.");
            }
        }

        public void Load_kh_update(int makh, string tenKhachHang, string email, string soDienThoai, string diaChi, string matKhau)
        {
            // Tìm khách hàng theo mã khách hàng
            KhachHang khachHang = cinema.KhachHangs.Where(kh => kh.MaKhachHang == makh).FirstOrDefault();

            // Nếu tìm thấy khách hàng, cập nhật thông tin

            if (khachHang != null)
            {
                khachHang.TenKhachHang = tenKhachHang;
                khachHang.Email = email;
                khachHang.SoDienThoai = soDienThoai;
                khachHang.DiaChi = diaChi;
                khachHang.MatKhau = matKhau;

                // Lưu thay đổi vào cơ sở dữ liệu
                cinema.SubmitChanges();
            }
            else
            {
                // Xử lý trường hợp không tìm thấy khách hàng
                Console.WriteLine("Không tìm thấy khách hàng với mã: " + makh);
            }
        }

    }
}
