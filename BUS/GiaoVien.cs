using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Sinh_Vien_Project.BUS
{
    class GiaoVien
    {
        DAO.GiaoVien daogv;
        public GiaoVien()
        {
            daogv = new DAO.GiaoVien();
        }
        public DataTable getds()
        {
            return daogv.getdsGiaoVien();
        }
        public bool ThemGV(DTO.GiaoVien gv)
        {
            return daogv.ThemGV(gv);
        }
        public bool XoaGV(DTO.GiaoVien gv)
        {
            return daogv.XoaGV(gv);
        }
        public bool SuaGV(DTO.GiaoVien gv)
        {
            return daogv.SuaGV(gv);
        }
        public DataTable TimKiemGV(int gv)
        {
            return daogv.TimKiemGV(gv);
        }
    }
}
