using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Quan_Ly_Sinh_Vien_Project.BUS;
using Quan_Ly_Sinh_Vien_Project.DAO;
using Excel = Microsoft.Office.Interop.Excel;
namespace Quan_Ly_Sinh_Vien_Project.GUI
{
    
    public partial class frmHocPhi : Form
    {
        BUS.HocPhi bushocphi;
        public frmHocPhi()
        {
            InitializeComponent();
            bushocphi = new BUS.HocPhi();
            getIDHS();
            getTenHS();
            getIDLop();
            
        }
        private void getIDHS()
        {
            SqlConnection conn = SqlConDB.getconnect();
            string sql = "Select IDHS from HocSinh";
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("IDHS", typeof(string));
            dt.Load(reader);
            ComboIDHS.ValueMember = "IDHS";
            ComboIDHS.DataSource = dt;
            conn.Close();
        }
        /*private void getTenHS()
        {
            SqlConnection conn = SqlConDB.getconnect();
            string sql = "Select * from dbo.HOCSINH where IDHS=" + combomahs.SelectedValue.ToString() + "";
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                txtTenHS.Texts = dr["TenHS"].ToString();
            }
            conn.Close();
        }
        */
        private void getIDLop()
        {
            SqlConnection conn = SqlConDB.getconnect();
            string sql = "Select Malop from Lop";
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("Malop", typeof(int));
            dt.Load(reader);
            cbIDlop.ValueMember = "Malop";
            cbIDlop.DataSource = dt;
            conn.Close();
        }
        private void getTenHS()
        {
            SqlConnection conn = SqlConDB.getconnect();
            string sql = "Select TenHS from HocSinh";
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("TenHS", typeof(string));
            dt.Load(reader);
            comboTenHS.ValueMember = "TenHS";
            comboTenHS.DataSource = dt;
            conn.Close();
        }
     
    /* private void getTenHS1()
        {
            SqlConnection conn = SqlConDB.getconnect();
            string sql = "Select * from HocSinh where IDHS=" + ComboIDHS.SelectedIndex.ToString() + "";
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                comboTenHS.Texts = dr["TenHS"].ToString();
            }
            conn.Close();
        }
        */
        private void showListHocPhi()
        {
            System.Data.DataTable dt = bushocphi.getdsHocPhi();
            dtgvHP.DataSource = dt;
        }
        private void frmTruong_Load(object sender, EventArgs e)
        {
            if (SqlConDB.type == "A")
            {
                btnAdd.Enabled = true;
                btnDelete.Enabled = true;
                btnEdit.Enabled = true;
                btnExcel.Enabled = true;
                
            }
            else if (SqlConDB.type == "U")
            {
                btnAdd.Enabled = false;
                btnDelete.Enabled = false;
                btnEdit.Enabled = false;
                btnExcel.Enabled = true;
            }
            else if (SqlConDB.type == "U2")
            {
                btnAdd.Enabled = false;
                btnDelete.Enabled = false;
                btnEdit.Enabled = false;
                btnExcel.Enabled = false;
            }
            else if (SqlConDB.type == "U3")
            {
                btnAdd.Enabled = false;
                btnDelete.Enabled = false;
                btnEdit.Enabled = false;
                btnExcel.Enabled = false;
            }
            showListHocPhi();
        }
        public void Reset()
        {
            txtIDHP.Texts = "";
            txtTienHoc.Texts = "";
            txtSotiet.Texts = "";
            cbIDlop.Texts = "";
            comboTenHS.Texts = "";
        }

        private void rjButton21_Click(object sender, EventArgs e)
        {
            DataTable dt = bushocphi.getdsHocPhi();
            int[] mangid = new int[dt.Rows.Count];
            int id;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                id = int.Parse(dt.Rows[i]["MaHP"].ToString().Remove(0, 2));
                mangid[i] = id;
            }
            if ((id = mangid.Max() + 1) < 10) 
            {

                string nextid = "HP0" + id;
                txtIDHP.Texts = nextid.ToString();
            }
            else if ((id = mangid.Max() + 1) < 1000)
            {
                string nextid2 = "HP" + id;
                txtIDHP.Texts = nextid2.ToString();
            }
            if (txtIDHP.Texts == "" || txtSotiet.Texts == "" || txtTienHoc.Texts == ""
              || cbIDlop.Texts == "" || comboTenHS.Texts == null)
            {
                MessageBox.Show("Khong Duoc bo Trong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnAdd.Enabled = false;
                btnAdd.Enabled = true;
                btnDelete.Enabled = false;
                btnDelete.Enabled = true;
                btnEdit.Enabled = false;
                btnEdit.Enabled = true;
                btnExcel.Enabled = false;
                btnExcel.Enabled = true;
            }
            else
            {
                DTO.HocPhi lp = new DTO.HocPhi();

                /* DTO.Diem diem = new DTO.Diem();


                    diem.Makq = txtIDKQ.Texts;
                    diem.Mamh = txtIDMH.Texts;
                    diem.IDHS = txtIDHS.Texts;
                float a = diem.diemkt15p = float.Parse(txtDiem15p.Texts);
                float b = diem.diemkt45p = float.Parse(txtDiem45p.Texts);
                float c = diem.diemhk = float.Parse(txtDiemHK.Texts);
                diem.diemtb = ((a * 1 + b * 2 + c * 3) / 6);
                 txtTB.Texts = diem.diemtb.ToString();
                diem.Hocky = cboHocKi.Texts;
                diem.Malop = Convert.ToInt32(txtMalop.Texts);
               diemtb.ToString();*/
                lp.MaHP = txtIDHP.Texts;
                lp.IDHS = ComboIDHS.Texts;
                lp.TenHS = comboTenHS.Texts;
                lp.Malop = int.Parse(cbIDlop.Texts);
                float sotiet = lp.Sotiet = int.Parse(txtSotiet.Texts);
                float TienHoc = lp.TienHoc = float.Parse(txtTienHoc.Texts);
                lp.TongTien = (sotiet * TienHoc);
                txtTongTien.Texts = lp.TongTien.ToString();
                /* lp.Sotiet = int.Parse(txtSotiet.Texts);
                 lp.TienHoc = float.Parse(txtTienHoc.Texts);

                 lp.TongTien = float.Parse(txtTongTien.Texts);*/

                if (bushocphi.ThemHocPhi(lp))
                {
                    showListHocPhi();
                }
                else
                {
                    MessageBox.Show("Co Loi Xay Ra", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            Reset();
        }

      

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DTO.HocPhi hp = new DTO.HocPhi();
            hp.MaHP = txtIDHP.Texts;
            if (bushocphi.XoaHocPhi(hp))
            {
                showListHocPhi();
            }
            else
            {
                MessageBox.Show("Co Loi Xay Ra", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            DTO.HocPhi lp = new DTO.HocPhi();
            lp.MaHP = txtIDHP.Texts;
            lp.IDHS = ComboIDHS.Texts;
            lp.TenHS = comboTenHS.Texts;
            lp.Malop = int.Parse(cbIDlop.Texts);
            float sotiet = lp.Sotiet = int.Parse(txtSotiet.Texts);
            float TienHoc = lp.TienHoc = float.Parse(txtTienHoc.Texts);
            lp.TongTien = (sotiet * TienHoc);
            txtTongTien.Texts = lp.TongTien.ToString();
            if (bushocphi.SuaHocPhi(lp))
            {
                showListHocPhi();

            }
            else
            {
                MessageBox.Show("Co Loi Xay Ra", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            Excel.Application app = new Excel.Application();
            Excel.Workbook wb = app.Workbooks.Add();
            Excel.Worksheet ws = null;
            app.Visible = true;
            ws = wb.Sheets["Sheet1"];
            ws = wb.ActiveSheet;
            for (int i = 0; i < dtgvHP.Columns.Count; i++)
            {
                ws.Cells[1, i + 1] = dtgvHP.Columns[i].HeaderText;//Lấy data tiêu đề cột
            }
            for (int j = 0; j < dtgvHP.Rows.Count - 1; j++)
            {
                for (int i = 0; i < dtgvHP.Columns.Count; i++)//lấy data dòng cột 
                {
                    ws.Cells[j + 2, i + 1] = dtgvHP.Rows[j].Cells[i].Value.ToString();
                }
            }
            ws.Columns.AutoFit();
        }

        /* private void ComboIDHS_OnSelectedIndexChanged(object sender, EventArgs e)
         {
             getTenHS1();
         }
        */
        /*   private void CboIDHS_SelectionChangeCommitted(object sender, EventArgs e)
           {
               getTenHS1();
           }*/

        /*rivate void CboIDHS_SelectionChangeCommitted_1(object sender, EventArgs e)
        {
            getTenHS1();
        }

        private void comboTenHS_OnSelectedIndexChanged(object sender, EventArgs e)
        {

        }
        */
    }
}
