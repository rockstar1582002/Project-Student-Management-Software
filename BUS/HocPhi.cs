using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Sinh_Vien_Project.BUS
{
    class HocPhi
    {
        DAO.HocPhi daoHocPhi;
        public HocPhi()
        {
            daoHocPhi = new DAO.HocPhi();
        }
        public DataTable getdsHocPhi()
        {
            return daoHocPhi.getdsHocPhi();
        }
        public bool ThemHocPhi(DTO.HocPhi hp)
        {
            return daoHocPhi.ThemHocPhi(hp);
        }
        public bool XoaHocPhi(DTO.HocPhi hp)
        {
            return daoHocPhi.XoaHocPhi(hp);
        }
        public bool SuaHocPhi(DTO.HocPhi hp)
        {
            return daoHocPhi.SuaHocPhi(hp);
        }
    }
}
