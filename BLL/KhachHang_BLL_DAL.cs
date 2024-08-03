using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            KhachHang dm = cinema.KhachHangs.Where(kh => kh.MaKhachHang == makh).FirstOrDefault();
            cinema.KhachHangs.DeleteOnSubmit(dm);
            cinema.SubmitChanges();
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
