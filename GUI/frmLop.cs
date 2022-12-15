using Quan_Ly_Sinh_Vien_Project.DAO;
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
using Excel = Microsoft.Office.Interop.Excel;
namespace Quan_Ly_Sinh_Vien_Project.GUI
{
    public partial class frmLop : Form
    {
        BUS.Lop buslop;
        public frmLop()
        {
            InitializeComponent();
            buslop = new BUS.Lop();
            getIDGV();
        }
        public void showlistLop()
        {
            System.Data.DataTable dt = buslop.getdsLop();
            dtgvLop.DataSource = dt;
        }
        private void getIDGV()
        {
            SqlConnection conn = SqlConDB.getconnect();
            string sql = "Select Magv from Giaovien";
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("Magv", typeof(int));
            dt.Load(reader);
            cboIDGV.ValueMember = "Magv";
            cboIDGV.DataSource = dt;
            conn.Close();
        }
        private void getTen()
        {
            SqlConnection conn = SqlConDB.getconnect();
            string sql = "Select * from Giaovien where Magv="+cboIDGV.SelectedValue.ToString()+"";
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach(DataRow dr in dt.Rows)
            {
                txtGVCN.Texts = dr["Tengv"].ToString();
            }
            conn.Close();
        }
        private void frmLop_Load(object sender, EventArgs e)
        {
            showlistLop();
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
        }
        public void Reset()
        {
            txtIDLop.Texts = "";
            txtGVCN.Texts = "";
            cboIDGV.Text = "";
            txtGhiChu.Texts = "";
            cboIDGV.Text = "";
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            DataTable dt = buslop.getdsLop();
            
            int[] mangid = new int[dt.Rows.Count];
            int id;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                id = int.Parse(dt.Rows[i]["Malop"].ToString());
                mangid[i] = id;
            }
            if ((id = mangid.Max() + 1) < 10)
            {
                string nextid = "00" + id;
                 txtIDLop.Texts = nextid.ToString();

            }
            if ((id = mangid.Max() + 1) < 100)
            {
                string nextid = "0" + id;
                txtIDLop.Texts = nextid.ToString();
            }
            if ((id = mangid.Max() + 1) < 1000)
            {
                string nextid = "" + id;
                txtIDLop.Texts = nextid.ToString();
            }
            if (txtIDLop.Texts == "" || txtGhiChu.Texts == "" || txtGVCN.Texts == "" || cboIDGV.Text == null
             )
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
                DTO.Lop lp = new DTO.Lop();
                lp.Malop = int.Parse(txtIDLop.Texts);
                lp.Tenlop = cboTenLop.Texts;
                lp.ghichu = txtGhiChu.Texts;
                lp.Magv = int.Parse(cboIDGV.Text);
                lp.Tengvcn = txtGVCN.Texts;

                if (buslop.ThemLop(lp))
                {
                    showlistLop();
                }
                else
                {
                    MessageBox.Show("Co Loi Xay Ra", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Reset();
            }

        }

        private void btnAdd_MouseHover(object sender, EventArgs e)
        {
            btnAdd.ForeColor = Color.Black;
        }

        private void btnAdd_MouseLeave(object sender, EventArgs e)
        {
            btnAdd.ForeColor = Color.White;
        }

        private void rjButton22_Click(object sender, EventArgs e)
        {
            DTO.Lop lp = new DTO.Lop();
            lp.Malop = int.Parse(txtIDLop.Texts);
            if (buslop.Xoalop(lp))
            {
                showlistLop();
            }
            else
            {
                MessageBox.Show("Co Loi Xay Ra", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_MouseHover(object sender, EventArgs e)
        {
            btnDelete.ForeColor = Color.Black;
        }

        private void btnDelete_MouseLeave(object sender, EventArgs e)
        {
            btnDelete.ForeColor = Color.White;
        }

        private void rjButton23_Click(object sender, EventArgs e)
        {
            DTO.Lop lp = new DTO.Lop();
            lp.Malop = int.Parse(txtIDLop.Texts);
            lp.Tenlop = cboTenLop.Texts;
            lp.ghichu = txtGhiChu.Texts;
            lp.Magv = int.Parse(cboIDGV.Text);
            lp.Tengvcn = txtGVCN.Texts;

            if (buslop.Sualop(lp))
            {
                showlistLop();
            }
            else
            {
                MessageBox.Show("Co Loi Xay Ra", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void cboIDGV_SelectionChangeCommitted(object sender, EventArgs e)
        {
            getTen();
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            Excel.Application app = new Excel.Application();
            Excel.Workbook wb = app.Workbooks.Add();
            Excel.Worksheet ws = null;
            app.Visible = true;
            ws = wb.Sheets["Sheet1"];
            ws = wb.ActiveSheet;
            for (int i = 0; i < dtgvLop.Columns.Count; i++)
            {
                ws.Cells[1, i + 1] = dtgvLop.Columns[i].HeaderText;//Lấy data tiêu đề cột
            }
            for (int j = 0; j < dtgvLop.Rows.Count - 1; j++)
            {
                for (int i = 0; i < dtgvLop.Columns.Count; i++)//lấy data dòng cột 
                {
                    ws.Cells[j + 2, i + 1] = dtgvLop.Rows[j].Cells[i].Value.ToString();
                }
            }
            ws.Columns.AutoFit();
        }

        private void dtgvLop_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
