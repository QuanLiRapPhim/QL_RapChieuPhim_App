using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLL
{
    public class TheLoaiPhim_BLL_DAL
    {
        ManageCinemaDataContext cinema = new ManageCinemaDataContext();

        public TheLoaiPhim_BLL_DAL()
        {
            
        }
        public List<TheLoai> loadTheLoai()
        {
            return cinema.TheLoais.Select(tl=>tl).ToList<TheLoai>();
        }
        public void InsertTheLoai(string pTentheLoai)
        {
            TheLoai newTL = new TheLoai
            {
                TenTheLoai = pTentheLoai
            };
            cinema.TheLoais.InsertOnSubmit(newTL);
            cinema.SubmitChanges();
        }
        public void DeleteTheLoai(int maTL)
        {
            // Tìm thể loại cần xóa
            TheLoai delTL = cinema.TheLoais.Where(tl => tl.MaTheLoai == maTL).FirstOrDefault();
           
                // Kiểm tra xem thể loại có đang được sử dụng ở bảng Phim hay không
                bool isBeingUsed = cinema.Phims.Any(phim => phim.MaTheLoai == maTL);

                if (isBeingUsed)
                {
                    // Hiển thị thông báo nếu thể loại đang được sử dụng
                    MessageBox.Show("Thể loại đang được sử dụng bởi Phim!\n Vui lòng xóa Phim trước khi hoàn tất tác vụ!");
                MessageBox.Show("Xóa không thành công!");
                }
                else
                {
                    // Xóa thể loại nếu không có ràng buộc
                    cinema.TheLoais.DeleteOnSubmit(delTL);
                    cinema.SubmitChanges();
                    MessageBox.Show("Thể loại đã được xóa thành công.");
                }
           
        }

        public void UpdateTheLoai(int maTL,string TenTL)
        {
            TheLoai TheLoaiToUpdate=cinema.TheLoais.SingleOrDefault(tl => tl.MaTheLoai == maTL);
            if(TheLoaiToUpdate != null)
            {
                TheLoaiToUpdate.TenTheLoai = TenTL;
                cinema.SubmitChanges();
            }
            else
            {
                throw new Exception("Thể loại không tồn tại!");
            }
        }
        
    }
}
