using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quan_Ly_Sinh_Vien_Project.DTO;
namespace Quan_Ly_Sinh_Vien_Project.DAO
{
    public class SqlConDB
    {
        public static SqlConnection getconnect()
        {
            string strconn = "Data Source=DESKTOP-UOLK6O3\\SQLEXPRESS01;Initial Catalog=ProJect_Quan_Ly_HocSinh;Integrated Security=True";
            SqlConnection conn = new SqlConnection(strconn);
            return conn;
           
        }
        public static string type;

    }
  public  class DataConnection
    {
        //Cách Kết Nối DB Thứ 2 
        /* string conn = null;

         public DataConnection()
         {
             conn = "Data Source=DESKTOP-UOLK6O3\\SQLEXPRESS01;Initial Catalog=ProJect_Quan_Ly_HocSinh;Integrated Security=True";
         }
         public  SqlConnection getconnect()
         {
             return new SqlConnection(conn);
         }
        */
       public static string CheckLogin(Account acc)
        {
         
            string user = null;
            SqlConnection conn = SqlConDB.getconnect();
            conn.Open();
            SqlCommand cmd = new SqlCommand("proc_logic", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@UserName ", acc.Username);
            cmd.Parameters.AddWithValue("@Pass", acc.Pass);
           
            cmd.Connection = conn;
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                if(reader[2].ToString()=="admin")
                {
                   SqlConDB.type = "A";
                   user = reader.GetString(0);
                }
                else if(reader[2].ToString()=="user1")
                {
                     SqlConDB.type = "U";
                    user = reader.GetString(0);
                }
                else if(reader[2].ToString()=="user2")
                {
                    SqlConDB.type = "U2";
                    user = reader.GetString(0);
                }
                else if(reader[2].ToString()=="user3")
                {
                    SqlConDB.type = "U3";
                    user = reader.GetString(0);
                }
                reader.Close();
                conn.Close();
            }
            else
            {
                return "Tai Khoan Hoac Mat Khau Khong Dung";
            }
            return user;
            
        }
            
    }
    
   
}
