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
    public partial class FrmUser : Form
    {
        public FrmUser()
        {
            InitializeComponent();
        }

        private void rjTextBoxcs7__TextChanged(object sender, EventArgs e)
        {
            txtTenDN.Texts = "User1234";
        }

        private void txtMatKhau__TextChanged(object sender, EventArgs e)
        {
            txtMatKhau.Texts = "1234";
        }

        private void txtQuyen__TextChanged(object sender, EventArgs e)
        {
            txtQuyen.Texts = "User";
        }

        private void FrmUser_Load(object sender, EventArgs e)
        {
         
            
        }
    }
}
