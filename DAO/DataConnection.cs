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
            string strconn = "Data Source=LAPTOP-I2IUK1M1\\SQLEXPRESS01;Initial Catalog=ProJect_Quan_Ly_HocSinh;Integrated Security=True";
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
        
    
        public bool DangKy(Account acc)
        {
            string sql = "INSERT INTO dbo.Acc(Username,Pass,Gmail)VALUES(@Username,@Pass,@Gmail)";
            SqlConnection conn = SqlConDB.getconnect();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add("@Username", SqlDbType.NVarChar).Value = acc.Username;
                cmd.Parameters.Add("@Pass", SqlDbType.NVarChar).Value = acc.Pass;
                cmd.Parameters.Add("@Gmail", SqlDbType.NVarChar).Value = acc.Gmail;
                cmd.ExecuteNonQuery();
                conn.Close();
            }catch(Exception)
            {
                return false;
            }
            return true;
        }
       

        public bool UserNameCheck(Account acc)
        {

            SqlConnection con = SqlConDB.getconnect();
            SqlCommand cmd = new SqlCommand("Select count(*) from Acc where Username= @Username", con);
            cmd.Parameters.AddWithValue("@Username", acc.Username);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (dr.HasRows)
                {
                    dr[0].ToString();
                    return true;
                }
                dr.Close();
                con.Close();

            }
           
            return false;
           
        }
       /* public bool GmailCheck(Account acc)
        {
            SqlConnection con = SqlConDB.getconnect();
            SqlCommand cmd = new SqlCommand("Select count(*) from Acc where Gmail= @Gmail", con);
           
            cmd.Parameters.AddWithValue("@Gmail", acc.Gmail);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                if (dr.HasRows)
                {
                    dr[0].ToString();
                    return true;
                }
                dr.Close();
                con.Close();

            }
            return false;
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
                if(reader[0].ToString()=="admin1234")
                {
                   SqlConDB.type = "A";
                   user = reader.GetString(0);
                }
                else 
                {
                     SqlConDB.type = "U";
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
