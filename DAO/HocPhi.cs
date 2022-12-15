using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Sinh_Vien_Project.DAO
{
    class HocPhi
    {
        SqlCommand sqlcmd;
        SqlDataAdapter da;
        public HocPhi()
        {

        }
        public DataTable getdsHocPhi()
        {
            string sql = "Select * From HocPhi";
            SqlConnection con = SqlConDB.getconnect();
            da = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;

        }
        public bool ThemHocPhi(DTO.HocPhi hp)
        {
            string sql = "INSERT INTO dbo.HocPhi(MaHP,IDHS,TenHS,Malop,Sotiet,TienHoc,TongTien) VALUES(@MaHP,@IDHS,@TenHS,@Malop,@Sotiet,@TienHoc,@TongTien)";
            SqlConnection sqlconn = SqlConDB.getconnect();
           
            try
            {
                sqlcmd = new SqlCommand(sql, sqlconn);
                sqlconn.Open();
                sqlcmd.Parameters.Add("@MaHP", SqlDbType.NVarChar).Value = hp.MaHP;
                sqlcmd.Parameters.Add("@IDHS", SqlDbType.NVarChar).Value = hp.IDHS;
                sqlcmd.Parameters.Add("@TenHS", SqlDbType.NVarChar).Value = hp.TenHS;
                sqlcmd.Parameters.Add("@Malop", SqlDbType.Int).Value = hp.Malop;
                sqlcmd.Parameters.Add("@Sotiet", SqlDbType.Int).Value = hp.Sotiet;
                sqlcmd.Parameters.Add("@TienHoc", SqlDbType.Float).Value = hp.TienHoc;
                sqlcmd.Parameters.Add("@TongTien", SqlDbType.Float).Value = hp.TongTien;
                
                sqlcmd.ExecuteNonQuery();
                sqlconn.Close();

            }
            catch(Exception)
            {
                return false;
            }
            return true;
        }
        public bool XoaHocPhi(DTO.HocPhi hp)
        {
            string sql = "Delete dbo.HocPhi where MaHP=@MaHP";
            SqlConnection sqlcon = SqlConDB.getconnect();
            try
            {
                sqlcmd = new SqlCommand(sql, sqlcon);
                sqlcon.Open();
                sqlcmd.Parameters.Add("@MaHP", SqlDbType.NVarChar).Value = hp.MaHP;
                sqlcmd.ExecuteNonQuery();
                sqlcon.Close();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
        
        public bool SuaHocPhi(DTO.HocPhi hp)
        {
            string sql = "UPDATE HocPhi SET MaHP=@MaHP, IDHS=@IDHS,TenHS=@TenHS,Malop=@Malop,Sotiet=@Sotiet,TienHoc=@TienHoc,TongTien=@TongTien where MaHP=@MaHP";
            SqlConnection conn = SqlConDB.getconnect();
            try
            {
                sqlcmd = new SqlCommand(sql, conn);
                conn.Open();
                sqlcmd.Parameters.Add("@MaHP", SqlDbType.NVarChar).Value = hp.MaHP;
                sqlcmd.Parameters.Add("@IDHS", SqlDbType.NVarChar).Value = hp.IDHS;
                sqlcmd.Parameters.Add("@TenHS", SqlDbType.NVarChar).Value = hp.TenHS;
                sqlcmd.Parameters.Add("@Malop", SqlDbType.Int).Value = hp.Malop;
                sqlcmd.Parameters.Add("@Sotiet", SqlDbType.Int).Value = hp.Sotiet;
                sqlcmd.Parameters.Add("@TienHoc", SqlDbType.Float).Value = hp.TienHoc;
                sqlcmd.Parameters.Add("@TongTien", SqlDbType.Float).Value = hp.TongTien;
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
