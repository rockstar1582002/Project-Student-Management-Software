using Quan_Ly_Sinh_Vien_Project.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Ly_Sinh_Vien_Project.GUI
{
    public partial class FrmDangKy : Form
    {
        BUS.Account busacc;
        Boolean flag;
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
       (
           int Leftrect, int Toprect, int rightrect, int bottomrect, int widtheclipse, int heighteclipse
       );
        public FrmDangKy()
        {
            InitializeComponent();
            busacc = new BUS.Account();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 100, 100));
        }
        /*   public bool UserNameCheck()
           {

               SqlConnection con = SqlConDB.getconnect();
               SqlCommand cmd = new SqlCommand("Select count(*) from Acc where Username= @Username", con);
               cmd.Parameters.AddWithValue("@Username", txtName.Texts);
               con.Open();
               SqlDataReader dr = cmd.ExecuteReader();
               while (dr.Read())
               {
                   if (dr.HasRows)
                   {
                       dr[0].ToString();
                       return true;
                   }

               }
               return false;
           }*/
        public bool checkValidationgmail(string gm)
        {
            return Regex.IsMatch(gm, @"^[a-zA-Z0-9_.]{3,25}@gmail.com(.vn|)$");
        }
        public bool checkValidationpass(string pa)
        {
            return Regex.IsMatch(pa, "^[a-zA-Z0-9]{6,24}$");
        }
        private void rjButton21_Click(object sender, EventArgs e)
        {
          /*  DTO.Account acc = new DTO.Account();
            string email = txtGmail.Texts;
            string pass1 = txtPassWord.Texts;
            string pass2 = txtRepass.Texts;
            if(email==""||pass1==""||pass2==""||txtName.Texts=="")
            {
                MessageBox.Show("Vui Lòng Điền Đầy Đủ Thông Tin ");
                btnDK.Enabled = false;
                btnDK.Enabled = true;
            }
           else if (  !checkValidationpass(pass1))
            {
                MessageBox.Show("Vui Lòng Nhập Đúng Định Dạng PassWord", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnDK.Enabled = false;
                btnDK.Enabled = true;
            }
            else if (pass1!=pass2)
            {
                MessageBox.Show("Vui Lòng Nhập Pass Giống Nhau", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnDK.Enabled = false;
                btnDK.Enabled = true;
            }
          else  if (!checkValidationgmail(email))
            {
                MessageBox.Show("Vui Lòng Nhập Đúng Định Dạng Email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnDK.Enabled = false;
                btnDK.Enabled = true;
            }
           /* else if(!busacc.CheckGmail(acc))
            {
                MessageBox.Show("Email đã tồn tại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
          /*  else
            {
                FrmDangNhap dn = new FrmDangNhap();
             
                acc.Username = txtName.Texts;
                acc.Pass = txtPassWord.Texts;
                acc.Gmail = txtGmail.Texts;

                if (busacc.ThemTK(acc) && busacc.CheckTK(acc))
                {
                    MessageBox.Show("Đăng Ký Thành Công");
                    dn.Show();
                    this.Hide();
                }

                else
                {
                    MessageBox.Show("tài khoản đã tồn tại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
          */
        }
       
        private void FrmDangKy_Load(object sender, EventArgs e)
        {
            btnDK.Enabled = false;
            btnDK.Enabled = true;
            flag = true;
            timer1.Start();
        }

        private void btnDK_MouseHover(object sender, EventArgs e)
        {
            btnDK.ForeColor = Color.Black;
        }

        private void btnEx_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDK_MouseLeave(object sender, EventArgs e)
        {
            btnDK.ForeColor = Color.White;
        }

        private void btnDK_Click(object sender, EventArgs e)
        {
            DTO.Account acc = new DTO.Account();
            string email = txtGmail.Texts;
            string pass1 = txtPassWord.Texts;
            string pass2 = txtRepass.Texts;
            if (email == "" || pass1 == "" || pass2 == "" || txtName.Texts == "")
            {
                MessageBox.Show("Vui Lòng Điền Đầy Đủ Thông Tin ");
                btnDK.Enabled = false;
                btnDK.Enabled = true;
            }
            else if (!checkValidationpass(pass1))
            {
                MessageBox.Show("Vui Lòng Nhập Đúng Định Dạng PassWord", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnDK.Enabled = false;
                btnDK.Enabled = true;
            }
            else if (pass1 != pass2)
            {
                MessageBox.Show("Vui Lòng Nhập Pass Giống Nhau", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnDK.Enabled = false;
                btnDK.Enabled = true;
            }
            else if (!checkValidationgmail(email))
            {
                MessageBox.Show("Vui Lòng Nhập Đúng Định Dạng Email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnDK.Enabled = false;
                btnDK.Enabled = true;
            }
            /* else if(!busacc.CheckGmail(acc))
             {
                 MessageBox.Show("Email đã tồn tại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }*/
            else
            {
                FrmDangNhap dn = new FrmDangNhap();

                acc.Username = txtName.Texts;
                acc.Pass = txtPassWord.Texts;
                acc.Gmail = txtGmail.Texts;

                if (busacc.ThemTK(acc) && busacc.CheckTK(acc))
                {
                    MessageBox.Show("Đăng Ký Thành Công");
                    dn.Show();
                    this.Hide();
                }

                else
                {
                    MessageBox.Show("tài khoản đã tồn tại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnEx_MouseHover(object sender, EventArgs e)
        {
            btnEx.ForeColor = Color.Black;
        }

        private void btnEx_MouseLeave(object sender, EventArgs e)
        {
            btnEx.ForeColor = Color.White;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (flag)
            {
                if (this.Opacity <= 1.0)
                {
                    this.Opacity += 0.07;
                }
                else
                {
                    timer1.Stop();
                }
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            FrmDangNhap dn = new FrmDangNhap();
            dn.Show();
            this.Hide();
        }
    }
}
