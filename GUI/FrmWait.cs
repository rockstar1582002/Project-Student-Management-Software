using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Ly_Sinh_Vien_Project.GUI
{
    public partial class FrmWait : Form
    {
        public FrmWait()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            FrmDangKy dk = new FrmDangKy();
            dk.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            FrmDangNhap dn = new FrmDangNhap();
            dn.Show();
            this.Hide();
        }

        private void FrmWait_Load(object sender, EventArgs e)
        {
            btnTaiKhoan.Enabled = false;
            btnSinhVien.Enabled = false;
            btnMonHoc.Enabled = false;
            btnTruong.Enabled = false;
            btnLop.Enabled = false;
            btnGiangVien.Enabled = false;
            btnBangDiem.Enabled = false;
            btnDangXuat.Enabled = false;

        }
    }
}
