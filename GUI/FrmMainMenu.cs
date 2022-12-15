using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Quan_Ly_Sinh_Vien_Project.DTO;
using Quan_Ly_Sinh_Vien_Project.DAO;
using Quan_Ly_Sinh_Vien_Project.BUS;
using System.Data.SqlClient;
using LiveCharts.Wpf;

namespace Quan_Ly_Sinh_Vien_Project.GUI
{
    public partial class FrmMainMenu : Form
    {

        BUS.Diem diem;
        BUS.HocSinh hs;
        BUS.Lop lop;
        BUS.GiaoVien gv;
        BUS.HocPhi bushocphi;
        Boolean flag;

        public FrmMainMenu()
        {

            InitializeComponent();
           
            LoadTheme();
            diem = new BUS.Diem();
            hs = new BUS.HocSinh();
            lop = new BUS.Lop();
            gv = new BUS.GiaoVien();
            bushocphi = new BUS.HocPhi();
            CountStudent();
            CountLop();
            CountGV();
           CountHocPhi();
        }

        private void LoadTheme()
        {
            var theme = WinTheme.GetAccentColor();
            var darkColor = ControlPaint.Dark(theme);
            
        }
        public void CountStudent()
        {
            SqlConnection conn = SqlConDB.getconnect();
            string sql = "Select Count(*) from HocSinh";
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = hs.getds();
            da.Fill(dt);
            lblTongSo.Text = (dt.Rows.Count-1).ToString();
            conn.Close();

        }
        public void CountGV()
        {
            SqlConnection conn = SqlConDB.getconnect();
            string sql = "Select Count(*) from Giaovien";
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = gv.getds();
            da.Fill(dt);
            lblTongSo2.Text = (dt.Rows.Count - 1).ToString();
            conn.Close();
        }
        public void CountLop()
        {
            SqlConnection conn = SqlConDB.getconnect();
            string sql = "Select Count(*) from Lop";
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = lop.getdsLop();
            da.Fill(dt);
            lblTongSo3.Text = (dt.Rows.Count - 1).ToString();
            conn.Close();
        }
        public void CountHocPhi()
        {
            SqlConnection conn = SqlConDB.getconnect();
            string sql = "Select Count(*) from HocPhi";
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = bushocphi.getdsHocPhi();
            da.Fill(dt);
            lblTongSo4.Text = (dt.Rows.Count - 1).ToString();
            conn.Close();
        }
        public void fillChart()
        {
            try
            {
                SqlConnection conn = SqlConDB.getconnect();
                DataTable dt = diem.getdiem();
                string sql = "Select diemTB,XepLoai from Diem";
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                da.Fill(dt);
                chart1.ChartAreas["ChartArea1"].AxisX.Title = "XepLoai";
                chart1.ChartAreas["ChartArea1"].AxisX.TitleForeColor = Color.Gold;
                chart1.ChartAreas["ChartArea1"].AxisY.Title = "DiemTB";
                chart1.ChartAreas["ChartArea1"].AxisY.TitleForeColor = Color.Gold;
                chart1.ChartAreas["ChartArea1"].AxisX.Interval = 1;
               // chart1.Series.Add("DiemTB");
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    chart1.Series["XepLoai"].Points.AddXY(dt.Rows[i]["XepLoai"],dt.Rows[i]["diemTB"]);
                   
                    //, dt.Rows[i]["TenTonGiao"]);
                   //, dt.Rows[i]["TenTonGiao"]);
                }
                conn.Close();
                
                
                
            }
            catch(Exception e)
            {
                throw e;
            }
              
           /* chart1.Series["MarK"].Points.AddXY("Diem15p", 20);
            chart1.Series["MarK"].Points.AddXY("Diem45p", 30);
            chart1.Series["MarK"].Points.AddXY("DiemHK", 40);
           */
            
        }
    
        private Form ChildFormCurrent;
        private void OpenChildForm(Form childform)
        {
            if (ChildFormCurrent != null)
            {
                ChildFormCurrent.Close();
            }
          
            ChildFormCurrent = childform;
            childform.TopLevel = false;
         
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.None;
          
            panelDashBoard.Controls.Add(childform);
             
       panelDashBoard.Tag = childform;
            
            childform.BringToFront();
           
            childform.Show();

        }

        private void btnSinhVien_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmHocSinh());
            lblHome.ForeColor = btnSinhVien.FlatAppearance.MouseOverBackColor;
            lblHome.Text = btnSinhVien.Text;

        }
       

        
        

        private void panelDashBoard_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnMonHoc_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new frmMonHoc());
            lblHome.ForeColor = btnMonHoc.FlatAppearance.MouseOverBackColor;
            lblHome.Text = btnMonHoc.Text;

        }

        private void btnKhoa_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new frmHocPhi());
            lblHome.ForeColor = btnTruong.FlatAppearance.MouseOverBackColor;
            lblHome.Text = btnTruong.Text;

        }

        private void btnSinhVien_MouseHover(object sender, EventArgs e)
        {
            btnSinhVien.ForeColor = Color.Black;
           
        }

        private void btnMonHoc_MouseHover(object sender, EventArgs e)
        {
           
            btnMonHoc.ForeColor = Color.Black;
            
        }

        private void btnLop_MouseHover(object sender, EventArgs e)
        {
            btnLop.ForeColor = Color.Black;
            
        }

       

        private void btnBangDiem_MouseHover(object sender, EventArgs e)
        {
           
            btnBangDiem.ForeColor = Color.Black;
           
        }

        private void btnKhoa_MouseHover(object sender, EventArgs e)
        {
            btnTruong.ForeColor = Color.Black;
        
        }

        private void btnGiangVien_MouseHover(object sender, EventArgs e)
        {
            btnGiangVien.ForeColor = Color.Black;
           
        }

        private void btnDangXuat_MouseHover(object sender, EventArgs e)
        {
            btnDangXuat.ForeColor = Color.Black;
            
        }

        private void btnSinhVien_MouseLeave(object sender, EventArgs e)
        {
            btnSinhVien.ForeColor = Color.White;
        }

        private void btnMonHoc_MouseLeave(object sender, EventArgs e)
        {
            btnMonHoc.ForeColor = Color.White;
        }

        private void btnKhoa_MouseLeave(object sender, EventArgs e)
        {
            btnTruong.ForeColor = Color.White;
        }

        private void btnLop_MouseLeave(object sender, EventArgs e)
        {
            btnLop.ForeColor = Color.White;
        }

        private void btnGiangVien_MouseLeave(object sender, EventArgs e)
        {
            btnGiangVien.ForeColor = Color.White;
        }

        private void btnBangDiem_MouseLeave(object sender, EventArgs e)
        {
            btnBangDiem.ForeColor = Color.White;
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            FrmDangNhap dn = new FrmDangNhap();
            timer1.Start();
            flag = false;
            dn.Show();
            this.Hide();
        }

        private void btnDangXuat_MouseLeave(object sender, EventArgs e)
        {
            btnDangXuat.ForeColor = Color.White;
        }
       
        private void FrmMainMenu_Load(object sender, EventArgs e)
        {
            if(SqlConDB.type=="A")
            {
                btnSinhVien.Visible = true;
                btnSinhVien.Enabled = true;
                
            }
            
          
            flag = true;
            timer1.Start();
            fillChart();
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (ChildFormCurrent != null)
            {
                ChildFormCurrent.Close();
            }
        }

        private void lblHome_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
           
        }

        private void btnLop_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmLop());
            lblHome.ForeColor = btnBangDiem.FlatAppearance.MouseOverBackColor;
            lblHome.Text = btnLop.Text;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
          if(flag)
            {
                if(this.Opacity<=1.0)
                {
                    this.Opacity += 0.07;
                }
                else
                {
                   
                        timer1.Stop();
                }
            }
        }

        private void btnBangDiem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmDiem());
            lblHome.ForeColor = btnBangDiem.FlatAppearance.MouseOverBackColor;
            lblHome.Text = btnBangDiem.Text;
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void panelTitlte_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chart1_Click_1(object sender, EventArgs e)
        {

        }

        private void rjButton21_Click(object sender, EventArgs e)
        {
            if (SqlConDB.type == "A")
            {
                OpenChildForm(new FrmAdmin());
                lblHome.ForeColor = btnTaiKhoan.FlatAppearance.MouseOverBackColor;
                lblHome.Text = btnTaiKhoan.Text;
            }
            if(SqlConDB.type=="U")
            {
                OpenChildForm(new FrmUser());
                lblHome.ForeColor = btnTaiKhoan.FlatAppearance.MouseOverBackColor;
                lblHome.Text = btnTaiKhoan.Text;
            }
            if(SqlConDB.type=="U2")
            {
                OpenChildForm(new FrmUser2());
                lblHome.ForeColor = btnTaiKhoan.FlatAppearance.MouseOverBackColor;
                lblHome.Text = btnTaiKhoan.Text;
            }
            if (SqlConDB.type == "U3")
            {
                OpenChildForm(new FrmUser3());
                lblHome.ForeColor = btnTaiKhoan.FlatAppearance.MouseOverBackColor;
                lblHome.Text = btnTaiKhoan.Text;
            }

        }

        private void btnTaiKhoan_MouseHover(object sender, EventArgs e)
        {
            btnTaiKhoan.ForeColor = Color.Black;
        }

        private void btnTaiKhoan_MouseLeave(object sender, EventArgs e)
        {
            btnTaiKhoan.ForeColor = Color.White;
        }

        private void btnGiangVien_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmGiaoVien());
            lblHome.ForeColor = btnGiangVien.FlatAppearance.MouseOverBackColor;
            lblHome.Text = btnGiangVien.Text;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
