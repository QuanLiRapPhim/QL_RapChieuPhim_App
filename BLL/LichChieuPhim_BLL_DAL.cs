using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLL
{
    public class LichChieuPhim_BLL_DAL
    {
        ManageCinemaDataContext cinema=new ManageCinemaDataContext();
        public LichChieuPhim_BLL_DAL() { }
        public List<Phim> LoadPhim()
        {
            return cinema.Phims.Select(kh => kh).ToList<Phim>();

        }
        public List<RapChieuPhim> loadRapChieuPhim()
        {
            return cinema.RapChieuPhims.Select(kh => kh).ToList<RapChieuPhim>();
        }
        public List<ManHinhChieu> loadManHinhChieu(int pMaRap)
        {
            return cinema.ManHinhChieus.Where(lp => lp.MaRap == pMaRap).ToList<ManHinhChieu>();
        }

        public List<SuatChieu> loadSuatChieu(int pMaManHinh)
        {
            return cinema.SuatChieus.Where(lp => lp.MaManHinh == pMaManHinh).ToList<SuatChieu>();
        }
        public void InsertSuatChieu(int maPhim, int maManHinh, DateTime thoiGianChieu, int soGheTrong)
        {
            // Tạo một đối tượng SuatChieu mới
            SuatChieu newSuatChieu = new SuatChieu
            {
                MaPhim = maPhim,
                MaManHinh = maManHinh,
                ThoiGianChieu = thoiGianChieu,
                SoGheTrong = soGheTrong
            };

            // Thêm suất chiếu mới vào tập hợp SuatChieus
            cinema.SuatChieus.InsertOnSubmit(newSuatChieu);

            // Lưu thay đổi vào cơ sở dữ liệu
            cinema.SubmitChanges();
        }
        public void DeleteSuatChieu(int maSuatChieu)
        {
            // Tìm suất chiếu cần xóa
            SuatChieu delSuatChieu = cinema.SuatChieus.Where(suatChieu => suatChieu.MaSuatChieu == maSuatChieu).FirstOrDefault();

   
                // Kiểm tra xem suất chiếu có đang được sử dụng trong bảng Ve hay không
                bool isBeingUsedInVe = cinema.Ves.Any(ve => ve.MaSuatChieu == maSuatChieu);

                if (isBeingUsedInVe)
                {
                    // Hiển thị thông báo nếu suất chiếu đang được sử dụng
                    MessageBox.Show("Suất chiếu đang được sử dụng trong bảng Ve!\nVui lòng xóa các bản ghi liên quan trước khi hoàn tất tác vụ!");
                    MessageBox.Show("Xóa không thành công!");
                }
                else
                {
                    // Xóa suất chiếu nếu không có ràng buộc
                    cinema.SuatChieus.DeleteOnSubmit(delSuatChieu);
                    cinema.SubmitChanges();
                    MessageBox.Show("Suất chiếu đã được xóa thành công.");
                }
            

        }

        public void UpdateSuatChieu(int maSuatChieu, int maPhim, int maManHinh, DateTime thoiGianChieu, int soGheTrong)
        {
            // Tìm suất chiếu theo mã suất chiếu
            SuatChieu suatChieuToUpdate = cinema.SuatChieus.SingleOrDefault(sc => sc.MaSuatChieu == maSuatChieu);

            if (suatChieuToUpdate != null)
            {
                // Cập nhật thông tin suất chiếu
                suatChieuToUpdate.MaPhim = maPhim;
                suatChieuToUpdate.MaManHinh = maManHinh;
                suatChieuToUpdate.ThoiGianChieu = thoiGianChieu;
                suatChieuToUpdate.SoGheTrong = soGheTrong;

                // Lưu thay đổi vào cơ sở dữ liệu
                cinema.SubmitChanges();
            }
            else
            {
                throw new Exception("Suất chiếu không tồn tại!");
            }
        }


    }
}
