using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Quan_Ly_Sinh_Vien_Project.DTO;
using Quan_Ly_Sinh_Vien_Project.DAO;
using Quan_Ly_Sinh_Vien_Project.BUS;
using Excel=Microsoft.Office.Interop.Excel;
using System.Data.SqlClient;

namespace Quan_Ly_Sinh_Vien_Project.GUI
{
    public partial class frmHocSinh : Form
    {
        BUS.HocSinh bushocsinh;
        public frmHocSinh()
        {
            InitializeComponent();
            bushocsinh = new BUS.HocSinh();
            getTDN();
            getIDLop();
            getDiem();
        }
        
       private void getTDN()
        {
            SqlConnection conn = SqlConDB.getconnect();
            string sql = "Select TenDN from Acc ";
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("TenDN", typeof(string));
            dt.Load(reader);
            CboTenDN.ValueMember = "TenDN";
            CboTenDN.DataSource = dt;
            conn.Close();
        }
        private void getDiem()
        {
            SqlConnection conn = SqlConDB.getconnect();
            string sql = "Select Makq from Diem ";
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("Makq", typeof(string));
            dt.Load(reader);
            cboMakq.ValueMember = "Makq";
            cboMakq.DataSource = dt;
            conn.Close();
        }

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
           cboIDLop .ValueMember = "Malop";
            cboIDLop.DataSource = dt;
            conn.Close();
        }
        private void getTenLop()
        {
            SqlConnection conn = SqlConDB.getconnect();
            string sql = "Select * from Lop where Malop=" + cboIDLop.SelectedValue.ToString() + "";
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                txtTenLop.Texts = dr["Tenlop"].ToString();
            }
            conn.Close();
        }
        private void rjRadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void rjButton21_MouseHover(object sender, EventArgs e)
        {
            btnADD.ForeColor = Color.Black;
           
        }

        private void btnADD_MouseLeave(object sender, EventArgs e)
        {
            btnADD.ForeColor = Color.White;

        }

        private void btnDelete_MouseHover(object sender, EventArgs e)
        {
            btnDelete.ForeColor = Color.Black;
            
        }

        private void btnDelete_MouseLeave(object sender, EventArgs e)
        {
            btnDelete.ForeColor = Color.White;
        }

        private void btnEdit_MouseHover(object sender, EventArgs e)
        {
            btnEdit.ForeColor = Color.Black;
           
        }

        private void btnEdit_MouseLeave(object sender, EventArgs e)
        {
            btnEdit.ForeColor = Color.White;
        }

        private void btnExcel_MouseHover(object sender, EventArgs e)
        {
            btnExcel.ForeColor = Color.Black;
          
        }

        private void btnExcel_MouseLeave(object sender, EventArgs e)
        {
            btnExcel.ForeColor = Color.White;
        }
        public void showlistHocSinh()
        {
            System.Data.DataTable dt = bushocsinh.getds();
            dtgvHocSinh.DataSource=dt;
        }

        private void frmHocSinh_Load(object sender, EventArgs e)
        {
            if(SqlConDB.type=="A")
            {
                btnADD.Enabled = true;
                btnDelete.Enabled = true;
                btnEdit.Enabled = true;
                btnExcel.Enabled = true;
            }
            else if(SqlConDB.type=="U")
            {
                btnADD.Enabled = false;
                btnDelete.Enabled = false;
                btnEdit.Enabled = false;
                btnExcel.Enabled = false;
            }
            else if(SqlConDB.type=="U2")
            {
                btnADD.Enabled = false;
                btnDelete.Enabled = false;
                btnEdit.Enabled = false;
                btnExcel.Enabled = false;
            }
            else if(SqlConDB.type=="U3")
            {
                btnADD.Enabled = false;
                btnDelete.Enabled = false;
                btnEdit.Enabled = false;
                btnExcel.Enabled = false;
            }
            showlistHocSinh();
        }
        private void Reset()
        {
            txtIDHS.Texts = "";
            txtTenHS.Texts = "";
            txtMaDanToc.Texts = "";
            txtDiaChi.Texts = "";
            cboIDLop.Text = "";
            cboMakq.Text = "";
            CboTenDN.Text = "";
        }
       
        private void btnADD_Click(object sender, EventArgs e)
        {
            DataTable dt = bushocsinh.getds();
            int[] mangid = new int[dt.Rows.Count];
            int id;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                id = int.Parse(dt.Rows[i]["IDHS"].ToString().Remove(0, 2));
                mangid[i] = id;
            }
            if ((id = mangid.Max() + 1) < 10)
            {

                string nextid = "HS0" + id;
                txtIDHS.Texts = nextid.ToString();
            }
            else if ((id = mangid.Max() + 1) < 1000)
            {
                string nextid2 = "HS" + id;
                txtIDHS.Texts = nextid2.ToString();
            }
            /* int count = 0;
             count = dtgvHocSinh.Rows.Count;
             string chuoi1 = "";
             int chuoi2 = 0;

             chuoi1 = Convert.ToString(dtgvHocSinh.Rows[count - 2].Cells[0].Value);
             chuoi2 = Convert.ToInt32(chuoi1.Remove(0, 2));
             if (chuoi2 + 1 < 10)
                txtIDHS.Texts = "HS0" + (chuoi2 + 1).ToString();
             else if (chuoi2 + 1 < 100)
                txtIDHS.Texts = "HS" + (chuoi2 + 1).ToString();
            */
            if (txtTenHS.Texts == "" || txtMaDanToc.Texts == "" || txtDiaChi.Texts == "" || dtpNgaySinh.Value == null
                || txtMaDanToc.Texts == "" || radioNam == null && radioNu == null)
            {
                MessageBox.Show("Khong Duoc bo Trong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnADD.Enabled = false;
                btnADD.Enabled = true;
                btnDelete.Enabled = false;
                btnDelete.Enabled = true;
                btnEdit.Enabled = false;
                btnEdit.Enabled = true;
                btnExcel.Enabled = false;
                btnExcel.Enabled = true;
            }
            else
            {
                DTO.HocSinh hs = new DTO.HocSinh();
                hs.IDHS = txtIDHS.Texts;
                hs.TenHS = txtTenHS.Texts;
                hs.DiaChi = txtDiaChi.Texts;
                hs.NgaySinh = dtpNgaySinh.Value;

                hs.GioiTinh = (radioNam.Checked ? radioNam.Text : radioNu.Text);
                hs.TenDanToc = txtMaDanToc.Texts;
                hs.Malop = int.Parse(cboIDLop.Text);
                hs.Tenlop = txtTenLop.Texts;
                hs.Makq = cboMakq.Text;
                hs.TenDN = CboTenDN.Text;

                if (bushocsinh.ThemHS(hs))
                {
                    showlistHocSinh();

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
            DTO.HocSinh hs = new DTO.HocSinh();
             hs.IDHS = txtIDHS.Texts;
            if(bushocsinh.XoaHS(hs))
            {
                showlistHocSinh();
            }
            else
            {
                MessageBox.Show("Co Loi Xay Ra", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Reset();

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            DTO.HocSinh hs = new DTO.HocSinh();
            hs.IDHS = txtIDHS.Texts;
            hs.TenHS = txtTenHS.Texts;
            hs.DiaChi = txtDiaChi.Texts;
            hs.NgaySinh = dtpNgaySinh.Value;
          
            hs.GioiTinh = (radioNam.Checked ? radioNam.Text : radioNu.Text);
            hs.TenDanToc = txtMaDanToc.Texts;
            hs.Malop = int.Parse(cboIDLop.Text);
            hs.Tenlop = txtTenLop.Texts;
            hs.Makq = cboMakq.Text;
            hs.TenDN = CboTenDN.Text;

            if (bushocsinh.SuaHS(hs))
            {
                showlistHocSinh();

            }
            else
            {
                MessageBox.Show("Co Loi Xay Ra", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Reset();
        }

      /*  private void dtgvHocSinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
         
            txtIDHS.Texts = dtgvHocSinh.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtTenHS.Texts = dtgvHocSinh.Rows[e.RowIndex].Cells[1].Value.ToString();
            
            txtDiaChi.Texts = dtgvHocSinh.Rows[e.RowIndex].Cells[2].Value.ToString();
           
            txtMaDanToc.Texts = dtgvHocSinh.Rows[e.RowIndex].Cells[3].Value.ToString();
             cbmaTonGiao.Texts = dtgvHocSinh.Rows[e.RowIndex].Cells[4].Value.ToString();
            dtpNgaySinh.Text = dtgvHocSinh.Rows[e.RowIndex].Cells[5].ToString();
           
           

        }*/
        /*
        private void xuatfileEx(string path)
        {
            Excel.Application app = new Excel.Application();
            app.Application.Workbooks.Add(Type.Missing);
           
            for(int i=0;i<=dtgvHocSinh.Columns.Count+1;i++)
            {
                app.Cells[1, i+1] = dtgvHocSinh.Columns[i].HeaderText;//Lay data cua Header
            }
            for(int i=0;i<dtgvHocSinh.Rows.Count;i++)
            {
                for(int j=0;j<dtgvHocSinh.Columns.Count;j++)
                {
                    app.Cells[i + 2, j + 1] = dtgvHocSinh.Rows[i].Cells[j].Value.ToString();//Lay data tu bang gom cac hang va cot
                }
            }
            app.Columns.AutoFit();
            app.ActiveWorkbook.SaveCopyAs(path);
            app.ActiveWorkbook.Saved = true;

        }
        */
        private void btnExcel_Click(object sender, EventArgs e)
        {
            Excel.Application app = new Excel.Application();
            Excel.Workbook wb = app.Workbooks.Add();
            Excel.Worksheet ws = null;
            app.Visible = true;
            ws = wb.Sheets["Sheet1"];
            ws = wb.ActiveSheet;
            for(int i=0;i<dtgvHocSinh.Columns.Count;i++)
            {
                ws.Cells[1, i + 1] = dtgvHocSinh.Columns[i].HeaderText;//Lấy data tiêu đề cột
            }
            for(int j=0;j<dtgvHocSinh.Rows.Count-1;j++)
            {
                for(int i=0;i<dtgvHocSinh.Columns.Count;i++)//lấy data dòng cột 
                {
                    ws.Cells[j + 2, i + 1] = dtgvHocSinh.Rows[j].Cells[i].Value.ToString();
                }
            }
            ws.Columns.AutoFit();
           /* dtgvHocSinh.SelectAll();
            DataObject copydt = dtgvHocSinh.GetClipboardContent();
            if (copydt != null)
                Clipboard.SetDataObject(copydt);
            Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
            app.Visible = true;
            Microsoft.Office.Interop.Excel.Workbook xlWbook;
            Microsoft.Office.Interop.Excel.Worksheet xlsheet;
            object misedt = System.Reflection.Missing.Value;
            xlWbook = app.Workbooks.Add(misedt);
            xlsheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWbook.Worksheets.get_Item(1);
            Microsoft.Office.Interop.Excel.Range xlr = (Microsoft.Office.Interop.Excel.Range)xlsheet.Cells[1, 1];
            xlr.Select();
            xlsheet.PasteSpecial(xlr, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing,  true);*/
           /* SaveFileDialog dia = new SaveFileDialog();
            dia.Title = "Export Excel";
            dia.Filter = "Excel (*.xlsx)|*.xlsx| Excel 2016 (*.xls)|*.xls";
            if(dia.ShowDialog()==DialogResult.OK)
            {
                try
                {
                    xuatfileEx(dia.FileName);
                    MessageBox.Show("Xuat File OK");

                }catch(Exception ex)
                {
                    MessageBox.Show("Xuat File Fail"+ex.Message);
                }
            }
           */
        }

        private void rjButton21_MouseHover_1(object sender, EventArgs e)
        {
            btnTimkiem.ForeColor = Color.Black;
        }

        private void btnTimkiem_MouseLeave(object sender, EventArgs e)
        {
            btnTimkiem.ForeColor = Color.White;
        }

        private void rjTextBoxcs1__TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            DTO.HocSinh hs = new DTO.HocSinh();
            hs.IDHS = txtIDHS.Texts;
            string value = (txtTimkiem.Texts);
            if(!string.IsNullOrEmpty(value))
            {
                DataTable dt = bushocsinh.TimKiemHS(value);
                dtgvHocSinh.DataSource = dt;
            }
            else
            {
                showlistHocSinh();
            }
        }

        private void dtgvHocSinh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtgvHocSinh_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtIDHS.Texts = dtgvHocSinh.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtTenHS.Texts = dtgvHocSinh.Rows[e.RowIndex].Cells[1].Value.ToString();

            txtDiaChi.Texts = dtgvHocSinh.Rows[e.RowIndex].Cells[2].Value.ToString();

            txtMaDanToc.Texts = dtgvHocSinh.Rows[e.RowIndex].Cells[3].Value.ToString();
           
           
        }

        private void txtQuyen__TextChanged(object sender, EventArgs e)
        {
           
        }

        private void cboTenDN_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
        }

        private void radioNu_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cboIDLop_SelectionChangeCommitted(object sender, EventArgs e)
        {
            getTenLop();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {

        }

        /*private void cboTenDN_SelectionChangeCommitted(object sender, EventArgs e)
        {
            getTenQuyen();
        }
        */
    }
}
