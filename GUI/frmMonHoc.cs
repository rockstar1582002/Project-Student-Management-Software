using Quan_Ly_Sinh_Vien_Project.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
namespace Quan_Ly_Sinh_Vien_Project.GUI
{
    public partial class frmMonHoc : Form
    {
        BUS.MonHoc busmh;
        public frmMonHoc()
        {
            InitializeComponent();
            busmh = new BUS.MonHoc();
        }
        public void Reset()
        {
            txtIDMonHoc.Texts = "";
            txtTenMonHoc.Texts = "";
        }

        private void rjButton21_Click(object sender, EventArgs e)
        {
            DataTable dt = busmh.getdsMonHoc();

            int[] mangid = new int[dt.Rows.Count];
            int id;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                id = int.Parse(dt.Rows[i]["Mamh"].ToString());
                mangid[i] = id;
            }
            if ((id = mangid.Max() + 1) < 10)
            {
                string nextid = "00" + id;
                txtIDMonHoc.Texts = nextid.ToString();

            }
            if ((id = mangid.Max() + 1) < 100)
            {
                string nextid = "0" + id;
                txtIDMonHoc.Texts = nextid.ToString();
            }
            if ((id = mangid.Max() + 1) < 1000)
            {
                string nextid = "" + id;
               txtIDMonHoc.Texts = nextid.ToString();
            }
            if (txtIDMonHoc.Texts == "" || txtTenMonHoc.Texts == "" || cboTrangThai.Texts == null)
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
                DTO.MonHoc mh = new DTO.MonHoc();
                mh.Mamh = int.Parse(txtIDMonHoc.Texts);
                mh.Tenmh = txtTenMonHoc.Texts;
                mh.Status = cboTrangThai.Texts;

                if (busmh.ThemMH(mh))
                {
                    showlistMonHoc();
                }
                else
                {
                    MessageBox.Show("Co Loi Xay Ra", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
          
            }
            Reset();

        }
        public void showlistMonHoc()
        {
            System.Data.DataTable dt = busmh.getdsMonHoc();
           dtgvMonHoc .DataSource = dt;
        }
        private void frmMonHoc_Load(object sender, EventArgs e)
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
            showlistMonHoc();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DTO.MonHoc mh = new DTO.MonHoc();
            mh.Mamh = int.Parse(txtIDMonHoc.Texts);
            if (busmh.XoaMH(mh))
            {
                showlistMonHoc();
            }
            else
            {
                MessageBox.Show("Co Loi Xay Ra", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            DTO.MonHoc mh = new DTO.MonHoc();
            mh.Mamh = int.Parse(txtIDMonHoc.Texts);
            mh.Tenmh = txtTenMonHoc.Texts;
            mh.Status = cboTrangThai.Texts;
            if (busmh.SuaMH(mh))
            {
                showlistMonHoc();

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
            for (int i = 0; i < dtgvMonHoc.Columns.Count; i++)
            {
                ws.Cells[1, i + 1] = dtgvMonHoc.Columns[i].HeaderText;//Lấy data tiêu đề cột
            }
            for (int j = 0; j < dtgvMonHoc.Rows.Count - 1; j++)
            {
                for (int i = 0; i < dtgvMonHoc.Columns.Count; i++)//lấy data dòng cột 
                {
                    ws.Cells[j + 2, i + 1] = dtgvMonHoc.Rows[j].Cells[i].Value.ToString();
                }
            }
            ws.Columns.AutoFit();
        }
    }
}
