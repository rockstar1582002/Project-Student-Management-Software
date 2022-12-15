using Quan_Ly_Sinh_Vien_Project.DAO;
using Quan_Ly_Sinh_Vien_Project.DTO;
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
    public partial class FrmGiaoVien : Form
    {
        BUS.GiaoVien busgv;
        public FrmGiaoVien()
        {
            InitializeComponent();
            busgv = new BUS.GiaoVien();
            getIDMH();
        }
        public void showlistGiaoVien()
        {
            System.Data.DataTable dt = busgv.getds();
            dtgvGiaoVien.DataSource = dt;
        }
        /*  private void getIDGV()
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
        }*/
        private void getIDMH()
        {
            SqlConnection conn = SqlConDB.getconnect();
            string sql = "Select Mamh from Monhoc";
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("Mamh", typeof(int));
            dt.Load(reader);
            cboIDMH.ValueMember = "Mamh";
            cboIDMH.DataSource = dt;
            conn.Close();
        }
        private void getTenMH()
        {
            SqlConnection conn = SqlConDB.getconnect();
            string sql = "Select * from Monhoc where Mamh=" + cboIDMH.SelectedValue.ToString() + "";
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                txtTenMH.Texts = dr["Tenmh"].ToString();
            }
            conn.Close();
        }
        public void Reset()
        {
            txtEmail.Texts = "";
            txtTenGV.Texts = "";
            txtSDT.Texts = "";
            txtDiaChi.Texts = "";
            txtIDGV.Texts = "";
            cboChucVu.Texts = null;
            cboIDMH.Text = "";
        }
        private void btnADD_Click(object sender, EventArgs e)
        {
            DataTable dt = busgv.getds();
            int[] mangid = new int[dt.Rows.Count];
            int id;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                id = int.Parse(dt.Rows[i]["Magv"].ToString());
                mangid[i] = id;
            }
            if ((id = mangid.Max() + 1) < 10)
            {

                string nextid = "00" + id;
                txtIDGV.Texts = nextid.ToString();
            }
            else if ((id = mangid.Max() + 1) < 1000)
            {
                string nextid2 = "0" + id;
                txtIDGV.Texts = nextid2.ToString();
            }
            if (txtTenGV.Texts == "" || txtTenMH.Texts == "" || txtDiaChi.Texts == "" || txtEmail.Texts == ""
               || txtSDT.Texts == "" || cboIDMH.Text == null && cboChucVu.Texts == null)
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
                DTO.GiaoVien gv = new DTO.GiaoVien();
                gv.Magv = int.Parse(txtIDGV.Texts);
                gv.Tengv = txtTenGV.Texts;
                gv.Mamh = int.Parse(cboIDMH.Text);
                gv.Tenmh = txtTenMH.Texts;
                gv.Email = txtEmail.Texts;
                gv.DienThoai = txtSDT.Texts;
                gv.DiaChi = txtDiaChi.Texts;
                gv.Status = cboChucVu.Texts;

                if (busgv.ThemGV(gv))
                {
                    showlistGiaoVien();

                }
                else
                {
                    MessageBox.Show("Co Loi Xay Ra", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

               
            }
            Reset();
        }

        private void FrmGiaoVien_Load(object sender, EventArgs e)
        {
            if (SqlConDB.type == "A")
            {
                btnADD.Enabled = true;
                btnDelete.Enabled = true;
                btnEdit.Enabled = true;
                btnExcel.Enabled = true;
            }
            else if (SqlConDB.type == "U")
            {
                btnADD.Enabled = false;
                btnDelete.Enabled = false;
                btnEdit.Enabled = false;
                btnExcel.Enabled = true;
                btnTimkiem.Enabled = false;
            }
            showlistGiaoVien();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DTO.GiaoVien gv = new DTO.GiaoVien();
            gv.Magv = int.Parse(txtIDGV.Texts);
            if (busgv.XoaGV(gv))
            {
                showlistGiaoVien();
            }
            else
            {
                MessageBox.Show("Co Loi Xay Ra", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Reset();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            DTO.GiaoVien gv = new DTO.GiaoVien();
            gv.Magv = int.Parse(txtIDGV.Texts);
            gv.Tengv = txtTenGV.Texts;
            gv.Mamh = int.Parse(cboIDMH.Text);
            gv.Tenmh = txtTenMH.Texts;
            gv.Email = txtEmail.Texts;
            gv.DienThoai = txtSDT.Texts;
            gv.DiaChi = txtDiaChi.Texts;
            gv.Status = cboChucVu.Texts;

            if (busgv.SuaGV(gv))
            {
                showlistGiaoVien();

            }
            else
            {
                MessageBox.Show("Co Loi Xay Ra", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Reset();
        }

        private void dtgvGiaoVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIDGV.Texts =dtgvGiaoVien.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtTenGV.Texts = dtgvGiaoVien.Rows[e.RowIndex].Cells[1].Value.ToString();

            txtTenMH.Texts = dtgvGiaoVien.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtEmail.Texts = dtgvGiaoVien.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtSDT.Texts = dtgvGiaoVien.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtDiaChi.Texts = dtgvGiaoVien.Rows[e.RowIndex].Cells[5].Value.ToString();
            cboChucVu.Texts = dtgvGiaoVien.Rows[e.RowIndex].Cells[6].Value.ToString();
          
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            Excel.Application app = new Excel.Application();
            Excel.Workbook wb = app.Workbooks.Add();
            Excel.Worksheet ws = null;
            app.Visible = true;
            ws = wb.Sheets["Sheet1"];
            ws = wb.ActiveSheet;
            for (int i = 0; i < dtgvGiaoVien.Columns.Count; i++)
            {
                ws.Cells[1, i + 1] = dtgvGiaoVien.Columns[i].HeaderText;//Lấy data tiêu đề cột
            }
            for (int j = 0; j < dtgvGiaoVien.Rows.Count - 1; j++)
            {
                for (int i = 0; i < dtgvGiaoVien.Columns.Count; i++)//lấy data dòng cột 
                {
                    ws.Cells[j + 2, i + 1] = dtgvGiaoVien.Rows[j].Cells[i].Value.ToString();
                }
            }
            ws.Columns.AutoFit();
        }

        private void cboIDMH_SelectionChangeCommitted(object sender, EventArgs e)
        {
            getTenMH();
        }
    }
}
