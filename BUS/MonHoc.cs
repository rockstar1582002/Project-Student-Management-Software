using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Sinh_Vien_Project.BUS
{
    class MonHoc
    {
        DAO.MonHoc daomh;
        public MonHoc()
        {
            daomh = new DAO.MonHoc();
        }
        public DataTable getdsMonHoc()
        {
            return daomh.getdsMonHoc();
        }
        public bool ThemMH(DTO.MonHoc mh)
        {
            return daomh.ThemMonHoc(mh);
        }
        public bool XoaMH(DTO.MonHoc mh)
        {
            return daomh.XoaMonHoc(mh);
        }
        public bool SuaMH(DTO.MonHoc mh)
        {
            return daomh.SuaMonHoc(mh);
        }
    }
}
