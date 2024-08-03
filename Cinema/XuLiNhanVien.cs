using Cinema.DataSetCinemaTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    public class XuLiNhanVien
    {
        public XuLiNhanVien() { }
        public List<string> getMaNhomNguoiDung(string ND)
        {
            List<string> ds_nhom = new List<string>();
           
            NguoiDungNhomNguoiDungTableAdapter adapter=new NguoiDungNhomNguoiDungTableAdapter();
                Cinema.DataSetCinema.NguoiDungNhomNguoiDungDataTable dtkq = adapter.GetDataBy_dk(ND);
            for (int i = 0; i < dtkq.Rows.Count; i++)
            {
                string manhom = dtkq.Rows[i][0].ToString();
                //string manhomString = manhom.ToString();
                ds_nhom.Add(manhom);
            }
            return ds_nhom;
        }
    }
}
