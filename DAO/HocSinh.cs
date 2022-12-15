using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Sinh_Vien_Project.DAO
{
   public class HocSinh
    {
       
        SqlCommand sqlcmd;
        SqlDataAdapter da;
        public HocSinh()
        {
          
        }
        public DataTable getdsHocSinh()
        {
            string sql = "Select * From HocSinh";
            SqlConnection con = SqlConDB.getconnect();
            da = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
            
        }
        public bool ThemHS(DTO.HocSinh hs)
        {
            string sql = "INSERT INTO dbo.HOCSINH(IDHS,TenHS,DiaChi,NgaySinh,GioiTinh,TenDanToc,Malop,Tenlop,Makq,TenDN)VALUES(@IDHS,@TenHS,@DiaChi,@NgaySinh,@GioiTinh,@TenDanToc,@Malop,@Tenlop,@Makq,@TenDN)";
            SqlConnection sqlcon = SqlConDB.getconnect();
            try
            {
                sqlcmd = new SqlCommand(sql, sqlcon);
                sqlcon.Open();
                sqlcmd.Parameters.Add("@IDHS", SqlDbType.NVarChar).Value = hs.IDHS;
                sqlcmd.Parameters.Add("@TenHS", SqlDbType.NVarChar).Value = hs.TenHS;
                sqlcmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar).Value = hs.DiaChi;
                sqlcmd.Parameters.Add("@NgaySinh", SqlDbType.NVarChar).Value = hs.NgaySinh.ToShortDateString();
                sqlcmd.Parameters.Add("@GioiTinh", SqlDbType.NVarChar).Value = hs.GioiTinh;
                sqlcmd.Parameters.Add("@TenDanToc", SqlDbType.NVarChar).Value = hs.TenDanToc;
                sqlcmd.Parameters.Add("@Malop", SqlDbType.Int).Value = hs.Malop;
                sqlcmd.Parameters.Add("@Tenlop", SqlDbType.NVarChar).Value = hs.Tenlop;
                sqlcmd.Parameters.Add("@Makq", SqlDbType.NVarChar).Value = hs.Makq;
                sqlcmd.Parameters.Add("@TenDN", SqlDbType.NVarChar).Value = hs.TenDN;


                sqlcmd.ExecuteNonQuery();
                sqlcon.Close();
            }catch(Exception)
            {
                return false;
            }
            return true;
        }
        public bool XoaHS(DTO.HocSinh hs)
        {
            string sql = "Delete dbo.HocSinh where IDHS=@IDHS";
            SqlConnection sqlcon = SqlConDB.getconnect();
            try
            {
                sqlcmd = new SqlCommand(sql, sqlcon);
                sqlcon.Open();
                sqlcmd.Parameters.Add("@IDHS", SqlDbType.NVarChar).Value = hs.IDHS;
                sqlcmd.ExecuteNonQuery();
                sqlcon.Close();
            }catch(Exception)
            {
                return false;
            }
            return true;
        }
        public bool SuaHS(DTO.HocSinh hs)
        {
            string sql = "UPDATE HocSinh SET IDHS=@IDHS, TenHS=@TenHS,DiaChi=@DiaChi,NgaySinh=@NgaySinh,GioiTinh=@GioiTinh,TenDanToc=@TenDanToc,Malop=@Malop,Tenlop=@Tenlop,Makq=@Makq,TenDN=@TenDN where IDHS=@IDHS";
            SqlConnection sqlcon = SqlConDB.getconnect();
            try
            {
                sqlcmd = new SqlCommand(sql, sqlcon);
                sqlcon.Open();
                sqlcmd.Parameters.Add("@IDHS", SqlDbType.NVarChar).Value = hs.IDHS;
                sqlcmd.Parameters.Add("@TenHS", SqlDbType.NVarChar).Value = hs.TenHS;
                sqlcmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar).Value = hs.DiaChi;
                sqlcmd.Parameters.Add("@NgaySinh", SqlDbType.NVarChar).Value = hs.NgaySinh.ToShortDateString();
                sqlcmd.Parameters.Add("@GioiTinh", SqlDbType.NVarChar).Value = hs.GioiTinh;
                sqlcmd.Parameters.Add("@TenDanToc", SqlDbType.NVarChar).Value = hs.TenDanToc;
                sqlcmd.Parameters.Add("@Malop", SqlDbType.Int).Value = hs.Malop;
                sqlcmd.Parameters.Add("@Tenlop", SqlDbType.NVarChar).Value = hs.Tenlop;
                sqlcmd.Parameters.Add("@Makq", SqlDbType.NVarChar).Value = hs.Makq;
                sqlcmd.Parameters.Add("@TenDN", SqlDbType.NVarChar).Value = hs.TenDN;

                sqlcmd.ExecuteNonQuery();
                sqlcon.Close();

            }
            catch(Exception)
            {
                return false;
            }
            return true;
        }
        public DataTable TimKiemHS(string sv)
        {
            string sql = "Select * from dbo.HOCSINH where IDHS='"+sv+"'";
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
