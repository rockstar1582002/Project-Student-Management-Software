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
    public partial class FrmDiem : Form
    {
        float diemtb;
        BUS.Diem busdiem;

        public FrmDiem()
        {
            InitializeComponent();
            busdiem = new BUS.Diem();
           // getIDHS();
            getIDMH();
        }
       /* private void getIDHS()
        {
            SqlConnection conn = SqlConDB.getconnect();
            string sql = "Select IDHS from HocSinh";
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("IDHS", typeof(string));
            dt.Load(reader);
            combomahs.ValueMember = "IDHS";
            combomahs.DataSource = dt;
            conn.Close();
        }
       */
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
            cboIDMonhoc.ValueMember = "Mamh";
            cboIDMonhoc.DataSource = dt;
            conn.Close();
        }
        private void getTenMH()
        {
            SqlConnection conn = SqlConDB.getconnect();
            string sql = "Select * from Monhoc where Mamh=" + cboIDMonhoc.SelectedValue.ToString() + "";
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

        private void FrmDiem_Load(object sender, EventArgs e)
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
            }
            else if (SqlConDB.type == "U2")
            {
                btnADD.Enabled = false;
                btnDelete.Enabled = false;
                btnEdit.Enabled = false;
                btnExcel.Enabled = false;
            }
            else if (SqlConDB.type == "U3")
            {
                btnADD.Enabled = false;
                btnDelete.Enabled = false;
                btnEdit.Enabled = false;
                btnExcel.Enabled = false;
            }
            showlistDiem();
        }

        private void panelInFo_Paint(object sender, PaintEventArgs e)
        {

        }
        public void showlistDiem()
        {
            System.Data.DataTable dt = busdiem.getdiem();
            dtgvDiem.DataSource = dt;
          
        }
        public void Reset()
        {
            txtIDKQ.Texts = "";
            cboIDMonhoc.Text = "";
            txtTenMH.Texts = "";
            txtDiem15p.Texts = "";
            txtDiem45p.Texts = "";
            txtDiemHK.Texts = "";
            txtTB.Texts = "";
            cboIDMonhoc.Text = "";
            txtXepLoai.Texts = "";
        }
        private void btnADD_Click(object sender, EventArgs e)
        {
            DataTable dt = busdiem.getdiem();
            int[] mangid = new int[dt.Rows.Count];
            int id;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                id = int.Parse(dt.Rows[i]["Makq"].ToString().Remove(0, 2));
                mangid[i] = id;
            }
            if ((id = mangid.Max() + 1) < 10)
            {

                string nextid = "KQ0" + id;
                txtIDKQ.Texts = nextid.ToString();
            }
            else if ((id = mangid.Max() + 1) < 1000)
            {
                string nextid2 = "KQ" + id;
                txtIDKQ.Texts = nextid2.ToString();
            }
            if (txtTenMH.Texts==""||txtDiem15p.Texts==""||txtDiem15p.Texts==""||txtDiem45p.Texts==""||txtDiemHK.Texts=="")
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
                else {
                        DTO.Diem diem = new DTO.Diem();


                        diem.Makq = txtIDKQ.Texts;
                        diem.Mamh = int.Parse(cboIDMonhoc.Text);
                        diem.Tenmh = txtTenMH.Texts;

                        float a = diem.diemkt15p = float.Parse(txtDiem15p.Texts);
                        float b = diem.diemkt45p = float.Parse(txtDiem45p.Texts);
                        float c = diem.diemhk = float.Parse(txtDiemHK.Texts);
                        diem.diemtb = ((a * 1 + b * 2 + c * 3) / 6);
                        txtTB.Texts = diem.diemtb.ToString();
                        if (diem.diemtb > 8.0)
                        {
                            diem.XepLoai = "Giỏi";
                            txtXepLoai.Texts = diem.XepLoai.ToString();
                        }
                        else if (diem.diemtb < 8.0 && diem.diemtb >= 6.5)
                        {
                            diem.XepLoai = "Khá";
                            txtXepLoai.Texts = diem.XepLoai.ToString();
                        }
                        else
                        {
                            diem.XepLoai = "Trung Bình";
                            txtXepLoai.Texts = diem.XepLoai.ToString();
                        }
                        diem.Hocky = cboHocKi.Texts;

                        diemtb.ToString();
                        if (busdiem.ThemDiem(diem))
                        {
                            showlistDiem();

                        }
                        else
                        {
                            MessageBox.Show("Co loi xay ra ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
            Reset();
        }

        private void dtgvDiem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIDKQ.Texts = dtgvDiem.Rows[e.RowIndex].Cells[0].Value.ToString();
            cboIDMonhoc.Text = dtgvDiem.Rows[e.RowIndex].Cells[1].Value.ToString();

           txtTB.Texts = dtgvDiem.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtDiem15p.Texts = dtgvDiem.Rows[e.RowIndex].Cells[3].Value.ToString();
              txtDiem45p.Texts = dtgvDiem.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtDiemHK.Texts = dtgvDiem.Rows[e.RowIndex].Cells[5].Value.ToString();
             cboHocKi.Texts = dtgvDiem.Rows[e.RowIndex].Cells[8].Value.ToString();
            txtTenMH.Texts = dtgvDiem.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtXepLoai.Texts = dtgvDiem.Rows[e.RowIndex].Cells[7].Value.ToString();
          
        }

        private void dtgvDiem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void rjButton21_Click(object sender, DataGridViewCellEventArgs e)
        {
         
            
        }

        private void btnDiemTB_Click(object sender, EventArgs e)
        {
            /*DTO.Diem diem = new DTO.Diem();

            float a = diem.diemkt15p = float.Parse(txtDiem15p.Texts);
            float b = diem.diemkt45p = float.Parse(txtDiem45p.Texts);
            float c = diem.diemhk = float.Parse(txtDiemHK.Texts);


            diemtb = ((a * 1 + b * 2 + c * 3) / 6);
            txtTB.Texts = diemtb.ToString();*/

        }

        private void btnKha_Click(object sender, EventArgs e)
        {
           
            DataTable dt = busdiem.TimKiemHSKha();
           
              dtgvDiem.DataSource = dt;
            
           
                
            
        }

        private void btnTB_Click(object sender, EventArgs e)
        {

            DataTable dt = busdiem.TimKiemHSTB();

            dtgvDiem.DataSource = dt;
        }

        private void btnHSG_Click(object sender, EventArgs e)
        {
            DataTable dt = busdiem.TimKiemHSGioi();

            dtgvDiem.DataSource = dt;
        }

        private void btnThiLai_Click(object sender, EventArgs e)
        {
            DataTable dt = busdiem.TimKiemHSThiLai();

            dtgvDiem.DataSource = dt;
        }

        private void rjButton21_Click(object sender, EventArgs e)
        {
            showlistDiem();
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            DTO.Diem diem = new DTO.Diem();
            diem.Makq = txtIDKQ.Texts;
            string value = (txtTimkiem.Texts);
            if (!string.IsNullOrEmpty(value))
            {
                DataTable dt = busdiem.TimKiem(value);
                dtgvDiem.DataSource = dt;
            }
            else
            {
                showlistDiem();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DTO.Diem diem = new DTO.Diem();
            diem.Makq = txtIDKQ.Texts;
            if (busdiem.XoaDiem(diem))
            {
                showlistDiem();
            }
            else
            {
                MessageBox.Show("Co Loi Xay Ra", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            DTO.Diem diem = new DTO.Diem();
            diem.Makq = txtIDKQ.Texts;
            diem.Mamh = int.Parse(cboIDMonhoc.Text);
            diem.Tenmh = txtTenMH.Texts;
        
            diem.diemkt15p = float.Parse(txtDiem15p.Texts);
            diem.diemkt45p = float.Parse(txtDiem45p.Texts);
            diem.diemhk = float.Parse(txtDiemHK.Texts);
            diem.diemtb = float.Parse(txtTB.Texts);
            diem.XepLoai = txtXepLoai.Texts;
            diem.Hocky = cboHocKi.Texts;
           
           
            if (busdiem.SuaDiem(diem))
            {
                showlistDiem();

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
            for (int i = 0; i < dtgvDiem.Columns.Count; i++)
            {
                ws.Cells[1, i + 1] = dtgvDiem.Columns[i].HeaderText;//Lấy data tiêu đề cột
            }
            for (int j = 0; j < dtgvDiem.Rows.Count - 1; j++)
            {
                for (int i = 0; i < dtgvDiem.Columns.Count; i++)//lấy data dòng cột 
                {
                    ws.Cells[j + 2, i + 1] = dtgvDiem.Rows[j].Cells[i].Value.ToString();
                }
            }
            ws.Columns.AutoFit();
        }

        private void txtTB__TextChanged(object sender, EventArgs e)
        {
            /* double DIEMTHI, DIEMTB, DIEMTK;

             if (txtDiemTB.Text == "")
             {
                 this.txtDiemTB.Text = "0";
                 DIEMTHI = double.Parse(this.txtDiemThi1.Text);

                 //Tính điểm TK
                 DIEMTK = (0.3 * 0 + 0.7 * DIEMTHI);
                 this.txtDiemTK.Text = Convert.ToString(DIEMTK);
             }
             else if (txtDiemThi1.Text == "")
             {
                 this.txtDiemThi1.Text = "0";
                 DIEMTB = double.Parse(this.txtDiemTB.Text);

                 //Tính điểm TK
                 DIEMTK = (0.3 * DIEMTB + 0.7 * 0);
                 this.txtDiemTK.Text = Convert.ToString(DIEMTK);
             }

             else
             {
                 DIEMTHI = double.Parse(this.txtDiemThi1.Text);
                 DIEMTB = double.Parse(this.txtDiemTB.Text);
                 //Tính điểm TK
                 DIEMTK = (0.3 * DIEMTB + 0.7 * DIEMTHI);
                 this.txtDiemTK.Text = Convert.ToString(DIEMTK);
             }
            */
            double DIEMKT15, DIEMKT45, DIEMhk, DIEMTB;
            DIEMKT15 = double.Parse(txtDiem15p.Texts);
            DIEMKT45 = double.Parse(txtDiem45p.Texts);
            DIEMhk = double.Parse(txtDiemHK.Texts);
            DIEMTB = (0.2 * DIEMKT45 + 0.1 * DIEMKT15 +0.7*DIEMhk );
            this.txtTB.Texts = Convert.ToString(DIEMTB);
        }

        private void cboIDMonhoc_SelectionChangeCommitted(object sender, EventArgs e)
        {
            getTenMH();
        }

        private void btnReset_MouseHover(object sender, EventArgs e)
        {
            btnReset.ForeColor = Color.Black;
        }

        private void btnReset_MouseLeave(object sender, EventArgs e)
        {
            btnReset.ForeColor = Color.White;
        }
    }
}
