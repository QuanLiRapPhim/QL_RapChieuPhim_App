using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLL
{
    public class Ve_BLL_DAL
    {
        ManageCinemaDataContext cinema=new ManageCinemaDataContext();
        public Ve_BLL_DAL()
        {

        }
        public List<Ve> LoadVe()
        {
            return cinema.Ves.Select(ve=>ve).ToList<Ve>();
        }
        public void Load_ve_delete(int pmave)
        {
            // Tìm vé cần xóa
            Ve ve = cinema.Ves.Where(v => v.MaVe == pmave).FirstOrDefault();

            if (ve == null)
            {
                MessageBox.Show("Vé không tồn tại.");
                return;
            }

            // Kiểm tra sự tồn tại của vé trong các bảng liên quan
            bool hasAppliedDiscounts = cinema.ApDungKhuyenMais.Any(adkm => adkm.MaVe == pmave);
            bool hasPayments = cinema.ThanhToans.Any(tt => tt.MaVe == pmave);

            if (hasAppliedDiscounts || hasPayments)
            {
                MessageBox.Show("Không thể xóa vé vì thông tin có liên quan đến thông tin Thanh toán.");
            }
            else
            {
                // Xóa vé khỏi tập hợp Ves
                cinema.Ves.DeleteOnSubmit(ve);
                cinema.SubmitChanges();

                MessageBox.Show("Vé đã được xóa thành công.");
            }
        }
        public void Load_Ve_Update(int pmave, int maSuatChieu, int maKhachHang, int maGhe, string soGhe, decimal gia, DateTime ngayDatVe)
        {
            // Tìm vé theo mã vé
            Ve ve = cinema.Ves.Where(v => v.MaVe == pmave).FirstOrDefault();

            // Nếu tìm thấy vé, cập nhật thông tin
            if (ve != null)
            {
                ve.MaSuatChieu = maSuatChieu;
                ve.MaKhachHang = maKhachHang;
                ve.MaGhe = maGhe;
                ve.SoGhe = soGhe;
                ve.Gia = gia;
                ve.NgayDatVe = ngayDatVe;

                // Lưu thay đổi vào cơ sở dữ liệu
                cinema.SubmitChanges();
            }
            else
            {
                // Xử lý trường hợp không tìm thấy vé
                Console.WriteLine("Không tìm thấy vé với mã: " + pmave);
            }
        }



    }
}
