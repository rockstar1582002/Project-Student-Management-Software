//using Quan_Ly_Sinh_Vien_Project.GUI;
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
namespace Quan_Ly_Sinh_Vien_Project.GUI
{
    
    public partial class FrmDangNhap : Form
    {
        Boolean flag;
        Account ac = new Account();
        BUS.Account tkbus = new BUS.Account();
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int Leftrect, int Toprect, int rightrect, int bottomrect, int widtheclipse, int heighteclipse
        );
        public FrmDangNhap()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 100, 100));
        }

        private void btnLogin_MouseEnter(object sender, EventArgs e)
        {
            btnLogin.ForeColor = Color.Black;
        }

        private void rjButton21_MouseEnter(object sender, EventArgs e)
        {
            btnEx.ForeColor = Color.Black;
        }

        private void FrmDangNhap_Load(object sender, EventArgs e)
        {
            btnLogin.Enabled = false;
            btnLogin.Enabled = true;
            flag = true;
            timer1.Start();

        }

        private void btnEx_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panelLogin_Paint(object sender, PaintEventArgs e)
        {
           
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            
           FormLoading ld = new FormLoading();

            /*  if ((txtUserName.Texts == "admin") && (txtpassword.Texts == "1234"))
              {
                  lblwarning.Visible = false;
                  btnLogin.Enabled = true;
                  ld.Show();

                  this.Hide();


              }
              else
              {
              lblwarning.Visible = true;
              btnLogin.Enabled = false;
              btnLogin.Enabled = true;




              }
      */
            ac.Username = txtUserName.Texts;
            ac.Pass = txtpassword.Texts;
            string laytaikhoan = tkbus.CheckLogin(ac);
            switch (laytaikhoan)
            {
                case "Ten Tai Khoan Bi trong":
                    lblwarning.Visible = true;
                    return;
                case "Mat Khau Bi Trong":
                    lblwarning.Visible = true;
                    return;
                case "Tai Khoan Hoac Mat Khau Khong Dung":
                    lblwarning.Visible = true;
                    return;
            }
            ld.Show();
            this.Hide();


        }

        private void btnLogin_MouseHover(object sender, EventArgs e)
        {

        }

        private void btnLogin_MouseLeave(object sender, EventArgs e)
        {
            btnLogin.ForeColor = Color.White;
        }

        private void btnEx_MouseHover(object sender, EventArgs e)
        {
            btnEx.ForeColor = Color.Black;
        }

        private void btnEx_MouseLeave(object sender, EventArgs e)
        {
            btnEx.ForeColor = Color.White;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (txtpassword.Texts != null)
            {
                txtpassword.PasswordChar = true;
               
            }
           else if(txtpassword.PasswordChar==true)
            {
                txtpassword.Texts = "\0";
            }

        }

        private void pic1_Click(object sender, EventArgs e)
        {
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
         
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

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
    }
}
