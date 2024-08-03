using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            TheLoai delTL=cinema.TheLoais.Where(tl=>tl.MaTheLoai==maTL).FirstOrDefault();
            cinema.TheLoais.DeleteOnSubmit(delTL);
            cinema.SubmitChanges();
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
