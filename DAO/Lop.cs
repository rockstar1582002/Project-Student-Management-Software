using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Sinh_Vien_Project.DAO
{
    class Lop
    {
        SqlCommand sqlcmd;
        SqlDataAdapter da;
        public Lop()
        {

        }
        public DataTable getdsLop()
        {
            //string sql = "Select Lop.Malop,Lop.Tenlop,Lop.Ghichu,Lop.Matruong, Truong.Tentruong from Lop inner join Truong on Lop.Matruong=Truong.Matruong";
            string sql = "Select * from Lop";
            SqlConnection con = SqlConDB.getconnect();
            da = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;

        }
        
        public bool ThemLop(DTO.Lop lp)
        {
            string sql = "Insert into dbo.Lop(Malop, Tenlop, Ghichu,Magv,Tengvcn) VALUES(@Malop,@Tenlop,@Ghichu,@Magv,@Tengvcn)";
            SqlConnection sqlconn = SqlConDB.getconnect();
            try
            {

                sqlcmd = new SqlCommand(sql,sqlconn);
                sqlconn.Open();
                sqlcmd.Parameters.Add("@Malop", SqlDbType.Int).Value = lp.Malop;
                sqlcmd.Parameters.Add("@Tenlop", SqlDbType.NVarChar).Value = lp.Tenlop;
                sqlcmd.Parameters.Add("@Ghichu", SqlDbType.NVarChar).Value = lp.ghichu;
                sqlcmd.Parameters.Add("@Magv", SqlDbType.Int).Value = lp.Magv;
                sqlcmd.Parameters.Add("@Tengvcn", SqlDbType.NVarChar).Value = lp.Tengvcn;
              
                sqlcmd.ExecuteNonQuery();
                sqlconn.Close();
            }
            catch(Exception)
            {
                return false;
            }
            return true;
        }
        public bool XoaLop(DTO.Lop lp)
        {
            string sql = "Delete dbo.LOP where Malop=@Malop";
            SqlConnection sqlcon = SqlConDB.getconnect();
            try
            {
                sqlcmd = new SqlCommand(sql, sqlcon);
                sqlcon.Open();
                sqlcmd.Parameters.Add("@Malop", SqlDbType.Int).Value = lp.Malop;
                sqlcmd.ExecuteNonQuery();
                sqlcon.Close();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
        public bool SuaLop(DTO.Lop lp)
        {
            string sql = "UPDATE Lop SET Malop=@Malop, Tenlop=@Tenlop,Ghichu=@Ghichu,Magv=@Magv,Tengvcn=@Tengvcn where Malop=@Malop";
            SqlConnection sqlcon = SqlConDB.getconnect();
            try
            {
                sqlcmd = new SqlCommand(sql, sqlcon);
                sqlcon.Open();
                sqlcmd.Parameters.Add("@Malop", SqlDbType.Int).Value = lp.Malop;
                sqlcmd.Parameters.Add("@Tenlop", SqlDbType.NVarChar).Value = lp.Tenlop;
                sqlcmd.Parameters.Add("@Ghichu", SqlDbType.NVarChar).Value = lp.ghichu;
                sqlcmd.Parameters.Add("@Magv", SqlDbType.Int).Value = lp.Magv;
                sqlcmd.Parameters.Add("@Tengvcn", SqlDbType.NVarChar).Value = lp.Tengvcn;


                sqlcmd.ExecuteNonQuery();
                sqlcon.Close();

            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
    }
}
