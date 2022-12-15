using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Sinh_Vien_Project.DAO
{
    class MonHoc
    {
        SqlCommand sqlcmd;
        SqlDataAdapter da;
        SqlConnection conn;
        public MonHoc()
        {

        }
        public DataTable getdsMonHoc()
        {
            string sql = "Select * from MonHoc";
            SqlConnection con = SqlConDB.getconnect();
            da = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;

        }
        public bool ThemMonHoc(DTO.MonHoc mh)
        {
            string sql = "INSERT INTO dbo.Monhoc(Mamh,Tenmh,Status) " +
                "VALUES(@Mamh,@Tenmh,@Status)   ";
            conn = SqlConDB.getconnect();
            try
            {
                sqlcmd = new SqlCommand(sql, conn);
                conn.Open();
                sqlcmd.Parameters.Add("@Mamh", SqlDbType.Int).Value = mh.Mamh;
                sqlcmd.Parameters.Add("@Tenmh", SqlDbType.NVarChar).Value = mh.Tenmh;
                sqlcmd.Parameters.Add("@Status", SqlDbType.NVarChar).Value = mh.Status;
               
                sqlcmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
        public bool XoaMonHoc(DTO.MonHoc mh)
        {
            string sql = "Delete dbo.Monhoc where Mamh=@Mamh";
            SqlConnection sqlcon = SqlConDB.getconnect();
            try
            {
                sqlcmd = new SqlCommand(sql, sqlcon);
                sqlcon.Open();
                sqlcmd.Parameters.Add("@Mamh", SqlDbType.Int).Value = mh.Mamh;
                sqlcmd.ExecuteNonQuery();
                sqlcon.Close();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
        public bool SuaMonHoc(DTO.MonHoc mh)
        {
            string sql = "UPDATE Monhoc SET Mamh=@Mamh, Tenmh=@Tenmh,Status=@Status where Mamh=@Mamh";
            SqlConnection sqlcon = SqlConDB.getconnect();
            try
            {
                sqlcmd = new SqlCommand(sql, sqlcon);
                sqlcon.Open();
                sqlcmd.Parameters.Add("@Mamh", SqlDbType.Int).Value = mh.Mamh;
                sqlcmd.Parameters.Add("@Tenmh", SqlDbType.NVarChar).Value = mh.Tenmh;
                sqlcmd.Parameters.Add("@Status", SqlDbType.NVarChar).Value = mh.Status;
                
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
