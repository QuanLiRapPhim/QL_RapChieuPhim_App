using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLL
{
    public class KhuyenMai_BLL_DAL
    {
        ManageCinemaDataContext cinema = new ManageCinemaDataContext();

        public KhuyenMai_BLL_DAL()
        {

        }
        public List<KhuyenMai> loadKhuyenMai()
        {
            return cinema.KhuyenMais.Select(tl => tl).ToList<KhuyenMai>();
        }
        public void InsertKhuyenMai(string pTieuDe,string pMoTa,decimal pGiamGia,DateTime pNgayBatDau,DateTime pNgayKetThuc)
        {
            KhuyenMai newKM = new KhuyenMai
            {
                TieuDe = pTieuDe,
                MoTa = pMoTa,   
                GiamGia=pGiamGia,
                NgayBatDau=pNgayBatDau,
                NgayKetThuc=pNgayKetThuc,
            };
            cinema.KhuyenMais.InsertOnSubmit(newKM);
            cinema.SubmitChanges();
        }
        public void DeleteKhuyenMai(int maKM)
        {
            // Tìm khuyến mãi cần xóa
            KhuyenMai delKM = cinema.KhuyenMais.Where(km => km.MaKhuyenMai == maKM).FirstOrDefault();

            // Kiểm tra nếu khuyến mãi tồn tại
            if (delKM != null)
            {
                // Kiểm tra xem khuyến mãi có đang được áp dụng không
                bool isApplied = cinema.ApDungKhuyenMais.Any(adkm => adkm.MaKhuyenMai == maKM);

                if (isApplied)
                {
                    MessageBox.Show("Khuyến mãi đang được áp dụng và không thể xóa.");
                }
                else
                {
                    // Xóa khuyến mãi khỏi tập hợp KhuyenMais
                    cinema.KhuyenMais.DeleteOnSubmit(delKM);

                    // Lưu thay đổi vào cơ sở dữ liệu
                    cinema.SubmitChanges();

                    MessageBox.Show("Khuyến mãi đã được xóa thành công.");
                }
            }
            else
            {
                MessageBox.Show("Khuyến mãi không tồn tại.");
            }
        }

        public void UpdateKhuyenMai(int maKM, string tieuDe, string moTa, decimal giamGia, DateTime ngayBatDau, DateTime ngayKetThuc)
        {
            // Tìm khuyến mãi theo mã khuyến mãi
            KhuyenMai khuyenMaiToUpdate = cinema.KhuyenMais.SingleOrDefault(km => km.MaKhuyenMai == maKM);

            if (khuyenMaiToUpdate != null)
            {
                // Cập nhật thông tin khuyến mãi
                khuyenMaiToUpdate.TieuDe = tieuDe;
                khuyenMaiToUpdate.MoTa = moTa;
                khuyenMaiToUpdate.GiamGia = giamGia;
                khuyenMaiToUpdate.NgayBatDau = ngayBatDau;
                khuyenMaiToUpdate.NgayKetThuc = ngayKetThuc;

                // Lưu thay đổi vào cơ sở dữ liệu
                cinema.SubmitChanges();
            }
            else
            {
                MessageBox.Show("Khuyến mãi không tồn tại!");
            }
        }


    }
}
