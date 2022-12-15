using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Sinh_Vien_Project.DAO
{
    class GiaoVien
    {
        SqlCommand sqlcmd;
        SqlDataAdapter da;
        public GiaoVien()
        {

        }
        public DataTable getdsGiaoVien()
        {
            string sql = "Select * From Giaovien";
            SqlConnection con = SqlConDB.getconnect();
            da = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;

        }
        public bool ThemGV(DTO.GiaoVien gv)
        {
            string sql = "INSERT INTO dbo.Giaovien(Magv,Tengv,Mamh,Tenmh,Dienthoai,Email,DiaChi,Status)VALUES(@Magv,@Tengv,@Mamh,@Tenmh,@Dienthoai,@Email,@DiaChi,@Status)";
            SqlConnection sqlcon = SqlConDB.getconnect();
            try
            {
                sqlcmd = new SqlCommand(sql, sqlcon);
                sqlcon.Open();
                sqlcmd.Parameters.Add("@Magv", SqlDbType.Int).Value = gv.Magv;
                sqlcmd.Parameters.Add("@Tengv", SqlDbType.NVarChar).Value = gv.Tengv;
                sqlcmd.Parameters.Add("@Mamh", SqlDbType.Int).Value = gv.Mamh;
                sqlcmd.Parameters.Add("@Tenmh", SqlDbType.NVarChar).Value = gv.Tenmh;
                sqlcmd.Parameters.Add("@Dienthoai", SqlDbType.NVarChar).Value = gv.DienThoai;
                sqlcmd.Parameters.Add("@Email", SqlDbType.NVarChar).Value = gv.Email;
                sqlcmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar).Value = gv.DiaChi;
                sqlcmd.Parameters.Add("@Status", SqlDbType.NVarChar).Value = gv.Status;
                
                sqlcmd.ExecuteNonQuery();
                sqlcon.Close();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
        public bool XoaGV(DTO.GiaoVien gv)
        {
            string sql = "Delete dbo.Giaovien where Magv=@Magv";
            SqlConnection sqlcon = SqlConDB.getconnect();
            try
            {
                sqlcmd = new SqlCommand(sql, sqlcon);
                sqlcon.Open();
                sqlcmd.Parameters.Add("@Magv", SqlDbType.Int).Value = gv.Magv;
                sqlcmd.ExecuteNonQuery();
                sqlcon.Close();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
        public bool SuaGV(DTO.GiaoVien gv)
        {
            string sql = "UPDATE Giaovien SET Magv=@Magv, Tengv=@Tengv,Mamh=@Mamh,Tenmh=@Tenmh,Dienthoai=@Dienthoai,Email=@Email,DiaChi=@Diachi,Status=@Status where Magv=@Magv";
            SqlConnection sqlcon = SqlConDB.getconnect();
            try
            {
                sqlcmd = new SqlCommand(sql, sqlcon);
                sqlcon.Open();
                sqlcmd.Parameters.Add("@Magv", SqlDbType.Int).Value = gv.Magv;
                sqlcmd.Parameters.Add("@Tengv", SqlDbType.NVarChar).Value = gv.Tengv;
                sqlcmd.Parameters.Add("@Mamh", SqlDbType.Int).Value = gv.Mamh;
                sqlcmd.Parameters.Add("@Tenmh", SqlDbType.NVarChar).Value = gv.Tenmh;
                sqlcmd.Parameters.Add("@Dienthoai", SqlDbType.NVarChar).Value = gv.DienThoai;
                sqlcmd.Parameters.Add("@Email", SqlDbType.NVarChar).Value = gv.Email;
                sqlcmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar).Value = gv.DiaChi;
                sqlcmd.Parameters.Add("@Status", SqlDbType.NVarChar).Value = gv.Status;

                sqlcmd.ExecuteNonQuery();
                sqlcon.Close();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
        public DataTable TimKiemGV(int gv)
        {
            string sql = "Select * from dbo.Giaovien where Magv='" + gv + "'";
            SqlConnection conn = SqlConDB.getconnect();
            da = new SqlDataAdapter(sql, conn);
            conn.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
    }
}
