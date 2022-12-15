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
using System.Data.SqlClient;
using System.IO;


namespace Quan_Ly_Sinh_Vien_Project.GUI
{
    public partial class FrmAdmin : Form
    {
        public FrmAdmin()
        {
            InitializeComponent();
        }
        string imglocation = "";
        public string GetValueUser
        {
            get
            {

                return pictureAvatar.Image.ToString();
            }
        }
        private void txtTenDN__TextChanged(object sender, EventArgs e)
        {
            txtTenDN1.Texts = "admin1234";
        }

        private void txtMatKhau1__TextChanged(object sender, EventArgs e)
        {
            txtMatKhau1.Texts = "1234";
        }

        private void txtQuyen1__TextChanged(object sender, EventArgs e)
        {
            txtQuyen1.Texts = "Admin";
        }
        SqlConnection conn = SqlConDB.getconnect();
       
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();
            openfile.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";

            if(openfile.ShowDialog()==DialogResult.OK)
            {
                imglocation = openfile.FileName.ToString();
                pictureAvatar.ImageLocation = imglocation;
            }
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            /*  byte[] images = null;
              FileStream filestream = new FileStream(imglocation, FileMode.Open, FileAccess.Read);
              BinaryReader reader = new BinaryReader(filestream);
              images = reader.ReadBytes((int)filestream.Length);
            */
            File.Copy(imglocation,Path.Combine(@"E:\QuanLyHocSinh\Resources\",Path.GetFileName(imglocation)),true);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmAdmin_Load(object sender, EventArgs e)
        {
           
               
                pictureAvatar.ImageLocation = imglocation;
            
        }
    }
}
