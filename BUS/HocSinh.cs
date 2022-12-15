using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Sinh_Vien_Project.BUS
{
    class HocSinh
    {
        DAO.HocSinh daohs;
        public HocSinh()
        {
            daohs = new DAO.HocSinh();
        }
        public DataTable getds()
        {
            return daohs.getdsHocSinh();
        }
        public bool ThemHS(DTO.HocSinh hs)
        {
            return daohs.ThemHS(hs);
        }
        public bool XoaHS(DTO.HocSinh hs)
        {
            return daohs.XoaHS(hs);
        }
        public bool SuaHS(DTO.HocSinh hs)
        {
            return daohs.SuaHS(hs);
        }
        public DataTable TimKiemHS(string sv)
        {
            return daohs.TimKiemHS(sv);
        }
    }
}
