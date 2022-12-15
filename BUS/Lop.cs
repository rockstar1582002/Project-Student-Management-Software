using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Sinh_Vien_Project.BUS
{
    class Lop
    {
        DAO.Lop daolop;
        public Lop()
        {
            daolop = new DAO.Lop();
        }
        public DataTable getdsLop()
        {
            return daolop.getdsLop();
        }
        public bool ThemLop(DTO.Lop lp)
        {
            return daolop.ThemLop(lp) ;
        }
        public bool Xoalop(DTO.Lop lp)
        {
            return daolop.XoaLop(lp);
        }
        public bool Sualop(DTO.Lop lp)
        {
            return daolop.SuaLop(lp);
        }
        
    }
}
