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
namespace Quan_Ly_Sinh_Vien_Project.GUI
{
    public partial class FormLoading : Form
    {
        private string text;
        private int len=0;
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int Leftrect,int Toprect,int rightrect,int bottomrect,int widtheclipse, int heighteclipse
        );
        public FormLoading()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 100, 100));
            ProcessBarLoad.Value = 0;
        }

        private void panelLoading_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormLoading_Load(object sender, EventArgs e)
        {
            timer1.Start();
           
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            FrmMainMenu menu = new FrmMainMenu();
            if(ProcessBarLoad.Value<100)
            {
                ProcessBarLoad.Value += 2;
                label3.Text = ProcessBarLoad.Value.ToString() + "%";
              
               
            }
            else
            {
                
                timer1.Stop();
                menu.Show();
                this.Hide();
            }
           
        }
        /*
        private void timer2_Tick(object sender, EventArgs e)
        {
            try
            {
                if (len < text.Length)
                {
                    lblloading.Text += text.ElementAt(len);
                    len++;
                }
                else
                {
                    timer2.Stop();
                }
            }catch(Exception)
            {
                MessageBox.Show("Error","Please Fill This", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          
        }
        */

        private void bunifuElipse1_TargetControlResized(object sender, EventArgs e)
        {
            
        }

        private void lblloading_Click(object sender, EventArgs e)
        {

        }

       /* private void timerLoading_Tick(object sender, EventArgs e)
        {
            try
            {
                if (len < text.Length)
                {
                    lblloading.Text += text.ElementAt(len);
                    len++;
                }
                else
                {
                    timerLoading.Stop();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error", "Please Fill This", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       */
    }
}
