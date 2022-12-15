using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quan_Ly_Sinh_Vien_Project.DTO;
namespace Quan_Ly_Sinh_Vien_Project.DAO
{
   public class AcessAcc:DataConnection
    {
        public string CheckAcc(Account acc)
        {
            string a = CheckLogin(acc);
            return a;
        }
    }
}
