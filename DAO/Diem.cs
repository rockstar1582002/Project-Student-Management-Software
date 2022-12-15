using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Sinh_Vien_Project.DAO
{
    class Diem
    {
        SqlConnection conn;
        SqlDataAdapter da;
        SqlCommand sqlcmd;
        public DataTable getdiem()
        {
            string sql = " Select * from Diem";
            conn = SqlConDB.getconnect();
            
            da = new SqlDataAdapter(sql, conn);
            conn.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;

        }

        public bool ThemDiem(DTO.Diem diem)
        {
            string sql = "INSERT INTO dbo.Diem(Makq,Mamh,Tenmh,diemkt15p,diemkt45p,diemhk,diemTB,XepLoai,Hocky) " +
                "VALUES(@Makq,@Mamh,@Tenmh,@diemkt15p,@diemkt45p,@diemhk,@diemTB,@XepLoai,@Hocky)   ";
            conn = SqlConDB.getconnect();
            try
            {
                sqlcmd = new SqlCommand(sql, conn);
                conn.Open();
                sqlcmd.Parameters.Add("@Makq", SqlDbType.NVarChar).Value = diem.Makq;
                sqlcmd.Parameters.Add("@Mamh", SqlDbType.Int).Value = diem.Mamh;
                sqlcmd.Parameters.Add("@Tenmh", SqlDbType.NVarChar).Value = diem.Tenmh;
  
                sqlcmd.Parameters.Add("@diemkt15p", SqlDbType.Float).Value = diem.diemkt15p;
                sqlcmd.Parameters.Add("@diemkt45p", SqlDbType.Float).Value = diem.diemkt45p;
                sqlcmd.Parameters.Add("@diemhk", SqlDbType.Float).Value = diem.diemhk;
                sqlcmd.Parameters.Add("@diemTB", SqlDbType.Float).Value = diem.diemtb;
                sqlcmd.Parameters.Add("@XepLoai", SqlDbType.NVarChar).Value = diem.XepLoai;
                sqlcmd.Parameters.Add("@Hocky", SqlDbType.NVarChar).Value = diem.Hocky;
              sqlcmd.ExecuteNonQuery();
                conn.Close();
            }
            catch(Exception)
            {
                return false;
            }
            return true;
        }
        
        public DataTable TimKiemHSKha()
        {
            string sql = "Select * from dbo.Diem where diemhk<8.0 ";
            SqlConnection conn = SqlConDB.getconnect();
            da = new SqlDataAdapter(sql, conn);
            conn.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public DataTable TimKiemHSTB()
        {
            string sql = "Select * from dbo.Diem where diemhk<6.5 ";
            SqlConnection conn = SqlConDB.getconnect();
            da = new SqlDataAdapter(sql, conn);
            conn.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public DataTable TimKiemHSGioi()
        {
            string sql = "Select * from dbo.Diem where diemhk>=8.0 AND diemkt45p>=9.0 ";
            SqlConnection conn = SqlConDB.getconnect();
            da = new SqlDataAdapter(sql, conn);
            conn.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public DataTable TimKiemHSThiLai()
        {
            string sql = "Select * from dbo.Diem where diemhk<5.0";
            SqlConnection conn = SqlConDB.getconnect();
            da = new SqlDataAdapter(sql, conn);
            conn.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public DataTable TimKiemHS (string diem)
        {
            string sql = "Select * from dbo.Diem where Makq='" + diem + "'";
            SqlConnection conn = SqlConDB.getconnect();
            da = new SqlDataAdapter(sql, conn);
            conn.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public bool XoaDiem(DTO.Diem diem)
        {
            string sql = "Delete dbo.Diem where Makq=@Makq";
            SqlConnection sqlcon = SqlConDB.getconnect();
            try
            {
                sqlcmd = new SqlCommand(sql, sqlcon);
                sqlcon.Open();
                sqlcmd.Parameters.Add("@Makq", SqlDbType.NVarChar).Value = diem.Makq;
                sqlcmd.ExecuteNonQuery();
                sqlcon.Close();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
        public bool SuaDiem(DTO.Diem diem)
        {
            string sql = "UPDATE Diem SET Makq=@Makq, Mamh=@Mamh,Tenmh=@Tenmh,diemkt15p=@diemkt15p,diemkt45p=@diemkt45p,diemhk=@diemhk,diemTB=@diemTB,XepLoai=@XepLoai,Hocky=@Hocky where Makq=@Makq";
            conn = SqlConDB.getconnect();
            try
            {
                sqlcmd = new SqlCommand(sql, conn);
                conn.Open();
                sqlcmd.Parameters.Add("@Makq", SqlDbType.NVarChar).Value = diem.Makq;
                sqlcmd.Parameters.Add("@Mamh", SqlDbType.Int).Value = diem.Mamh;
                sqlcmd.Parameters.Add("@Tenmh", SqlDbType.NVarChar).Value = diem.Tenmh;

                sqlcmd.Parameters.Add("@diemkt15p", SqlDbType.Float).Value = diem.diemkt15p;
                sqlcmd.Parameters.Add("@diemkt45p", SqlDbType.Float).Value = diem.diemkt45p;
                sqlcmd.Parameters.Add("@diemhk", SqlDbType.Float).Value = diem.diemhk;
                sqlcmd.Parameters.Add("@diemTB", SqlDbType.Float).Value = diem.diemtb;
                sqlcmd.Parameters.Add("@XepLoai", SqlDbType.NVarChar).Value = diem.XepLoai;
                sqlcmd.Parameters.Add("@Hocky", SqlDbType.NVarChar).Value = diem.Hocky;
                sqlcmd.ExecuteNonQuery();
                conn.Close();

            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
    }
}
