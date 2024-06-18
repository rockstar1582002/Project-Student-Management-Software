using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quan_Ly_Sinh_Vien_Project.DTO;
using Quan_Ly_Sinh_Vien_Project.DAO;
namespace Quan_Ly_Sinh_Vien_Project.BUS
{
    public class Account
    {
        DataConnection dt;
        AcessAcc ac = new AcessAcc();
        public string CheckLogin(DTO.Account acc)
        {
            if (acc.Username == "")
            {
                return "Ten Tai Khoan Bi trong";
            }
            if (acc.Pass == "")
            {
                return "Mat Khau Bi Trong";
            }
            string a = ac.CheckAcc(acc);
            return a;
        }

        public Account()
        {
            dt = new DataConnection();
        }
        public bool ThemTK(DTO.Account acc)
        {
            return dt.DangKy(acc);
        }
       public bool CheckTK(DTO.Account acc)
        {
            return dt.UserNameCheck(acc);
        }
    /*   public bool CheckGmail(DTO.Account acc)
        {
            return dt.GmailCheck(acc);
        }
       */
    }
}
