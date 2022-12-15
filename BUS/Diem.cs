using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Sinh_Vien_Project.BUS
{
    class Diem
    {
        DAO.Diem daodiem;
        public Diem()
        {
            daodiem = new DAO.Diem();
        }
        public DataTable getdiem()
        {
            return daodiem.getdiem();
        }
        public bool ThemDiem(DTO.Diem diem)
        {
            return daodiem.ThemDiem(diem);
        }
        public bool XoaDiem(DTO.Diem diem)
        {
            return daodiem.XoaDiem(diem);
        }
        public bool SuaDiem(DTO.Diem diem)
        {
            return daodiem.SuaDiem(diem);
        }
        public DataTable TimKiemHSKha()
        {
            return daodiem.TimKiemHSKha();
        }
        public DataTable TimKiemHSTB()
        {
            return daodiem.TimKiemHSTB();
        }
        public DataTable TimKiemHSGioi()
        {
            return daodiem.TimKiemHSGioi();
        }
        public DataTable TimKiemHSThiLai()
        {
            return daodiem.TimKiemHSThiLai();
        }
        public DataTable TimKiem(string diem)
        {
            return daodiem.TimKiemHS(diem);
        }
    }
}
