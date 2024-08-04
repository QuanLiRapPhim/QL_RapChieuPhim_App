using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLL
{
    public class Phim_BLL_DAL
    {
        ManageCinemaDataContext cinema=new ManageCinemaDataContext();
        public Phim_BLL_DAL() { }
        public List<Phim> LoadPhim(int maTheLoai)
        {
            return cinema.Phims
                         .Where(ph => ph.MaTheLoai == maTheLoai) // Filter by MaTheLoai
                         .ToList();
        }
        public List<TheLoai> loadTheLoai()
        {
            return cinema.TheLoais.Select(kh => kh).ToList<TheLoai>();
        }
        public void InsertPhim(string tenPhim, int maTheLoai, string daoDien, int thoiLuong, string tomTat, DateTime ngayKhoiChieu, string hinhAnh)
        {
            // Tạo một đối tượng Phim mới
            Phim newPhim = new Phim
            {
                TenPhim = tenPhim,
                MaTheLoai = maTheLoai,
                DaoDien = daoDien,
                ThoiLuong = thoiLuong,
                TomTat = tomTat,
                NgayKhoiChieu = ngayKhoiChieu,
                HinhAnh = hinhAnh
            };

            // Thêm phim mới vào tập hợp Phims
            cinema.Phims.InsertOnSubmit(newPhim);

            // Lưu thay đổi vào cơ sở dữ liệu
            cinema.SubmitChanges();
        }

        public void Load_phim_delete(int maphim)
        {
            // Tìm phim cần xóa
            Phim delphim = cinema.Phims.Where(phim => phim.MaPhim == maphim).FirstOrDefault();

            if (delphim != null)
            {
                // Kiểm tra xem phim có đang được sử dụng ở bảng DanhGiaPhim hay không
                bool isBeingUsedInDanhGiaPhim = cinema.DanhGiaPhims.Any(danhgia => danhgia.MaPhim == maphim);

                // Kiểm tra xem phim có đang được sử dụng ở bảng SuatChieu hay không
                bool isBeingUsedInSuatChieu = cinema.SuatChieus.Any(suatchieu => suatchieu.MaPhim == maphim);

                if (isBeingUsedInDanhGiaPhim || isBeingUsedInSuatChieu)
                {
                    // Hiển thị thông báo nếu phim đang được sử dụng
                    MessageBox.Show("Phim đang được sử dụng trong DanhGiaPhim hoặc SuatChieu!\nVui lòng xóa các bản ghi liên quan trước khi hoàn tất tác vụ!");
                    MessageBox.Show("Xóa không thành công!");
                }
                else
                {
                    // Xóa phim nếu không có ràng buộc
                    cinema.Phims.DeleteOnSubmit(delphim);
                    cinema.SubmitChanges();
                    MessageBox.Show("Phim đã được xóa thành công.");
                }
            }
            else
            {
                MessageBox.Show("Phim không tồn tại.");
            }
        }

        public void UpdatePhim(int maPhim, string tenPhim, int maTheLoai, string daoDien, int thoiLuong, string tomTat, DateTime ngayKhoiChieu, string hinhAnh)
        {
            // Tìm phim theo mã phim
            Phim phimToUpdate = cinema.Phims.SingleOrDefault(p => p.MaPhim == maPhim);

            if (phimToUpdate != null)
            {
                // Cập nhật thông tin phim
                phimToUpdate.TenPhim = tenPhim;
                phimToUpdate.MaTheLoai = maTheLoai;
                phimToUpdate.DaoDien = daoDien;
                phimToUpdate.ThoiLuong = thoiLuong;
                phimToUpdate.TomTat = tomTat;
                phimToUpdate.NgayKhoiChieu = ngayKhoiChieu;
                phimToUpdate.HinhAnh = hinhAnh;

                // Lưu thay đổi vào cơ sở dữ liệu
                cinema.SubmitChanges();
            }
            else
            {
                throw new Exception("Phim không tồn tại!");
            }
        }


    }
}
