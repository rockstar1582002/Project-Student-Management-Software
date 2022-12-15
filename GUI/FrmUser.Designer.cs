
namespace Quan_Ly_Sinh_Vien_Project.GUI
{
    partial class FrmUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelInFo = new System.Windows.Forms.Panel();
            this.pictureUser = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.txtQuyen = new Quan_Ly_Sinh_Vien_Project.RJControl.RJTextBoxcs();
            this.label4 = new System.Windows.Forms.Label();
            this.MatKhau = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenDN = new Quan_Ly_Sinh_Vien_Project.RJControl.RJTextBoxcs();
            this.txtMatKhau = new Quan_Ly_Sinh_Vien_Project.RJControl.RJTextBoxcs();
            this.panelInFo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureUser)).BeginInit();
            this.SuspendLayout();
            // 
            // panelInFo
            // 
            this.panelInFo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelInFo.Controls.Add(this.pictureUser);
            this.panelInFo.Controls.Add(this.txtQuyen);
            this.panelInFo.Controls.Add(this.label4);
            this.panelInFo.Controls.Add(this.MatKhau);
            this.panelInFo.Controls.Add(this.label2);
            this.panelInFo.Controls.Add(this.txtTenDN);
            this.panelInFo.Controls.Add(this.txtMatKhau);
            this.panelInFo.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelInFo.Location = new System.Drawing.Point(0, 0);
            this.panelInFo.Name = "panelInFo";
            this.panelInFo.Size = new System.Drawing.Size(946, 519);
            this.panelInFo.TabIndex = 2;
            // 
            // pictureUser
            // 
            this.pictureUser.ImageRotate = 0F;
            this.pictureUser.Location = new System.Drawing.Point(491, 12);
            this.pictureUser.Name = "pictureUser";
            this.pictureUser.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pictureUser.Size = new System.Drawing.Size(272, 216);
            this.pictureUser.TabIndex = 23;
            this.pictureUser.TabStop = false;
            // 
            // txtQuyen
            // 
            this.txtQuyen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.txtQuyen.BorderColor = System.Drawing.Color.LightGray;
            this.txtQuyen.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtQuyen.BorderRadius = 10;
            this.txtQuyen.BorderSize = 3;
            this.txtQuyen.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuyen.ForeColor = System.Drawing.Color.White;
            this.txtQuyen.Location = new System.Drawing.Point(154, 168);
            this.txtQuyen.Margin = new System.Windows.Forms.Padding(4);
            this.txtQuyen.Multiline = false;
            this.txtQuyen.Name = "txtQuyen";
            this.txtQuyen.Padding = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.txtQuyen.PasswordChar = false;
            this.txtQuyen.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtQuyen.PlaceholderText = "";
            this.txtQuyen.Size = new System.Drawing.Size(224, 40);
            this.txtQuyen.TabIndex = 22;
            this.txtQuyen.Texts = "user1";
            this.txtQuyen.UnderlinedStyle = false;
            this.txtQuyen._TextChanged += new System.EventHandler(this.txtQuyen__TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(40, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 19);
            this.label4.TabIndex = 21;
            this.label4.Text = "Quyền:";
            // 
            // MatKhau
            // 
            this.MatKhau.AutoSize = true;
            this.MatKhau.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MatKhau.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.MatKhau.Location = new System.Drawing.Point(40, 125);
            this.MatKhau.Name = "MatKhau";
            this.MatKhau.Size = new System.Drawing.Size(83, 19);
            this.MatKhau.TabIndex = 20;
            this.MatKhau.Text = "Mật Khẩu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(40, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 19);
            this.label2.TabIndex = 19;
            this.label2.Text = "Tên DN:";
            // 
            // txtTenDN
            // 
            this.txtTenDN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.txtTenDN.BorderColor = System.Drawing.Color.LightGray;
            this.txtTenDN.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtTenDN.BorderRadius = 10;
            this.txtTenDN.BorderSize = 3;
            this.txtTenDN.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDN.ForeColor = System.Drawing.Color.White;
            this.txtTenDN.Location = new System.Drawing.Point(152, 52);
            this.txtTenDN.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenDN.Multiline = false;
            this.txtTenDN.Name = "txtTenDN";
            this.txtTenDN.Padding = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.txtTenDN.PasswordChar = false;
            this.txtTenDN.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtTenDN.PlaceholderText = "";
            this.txtTenDN.Size = new System.Drawing.Size(224, 40);
            this.txtTenDN.TabIndex = 17;
            this.txtTenDN.Texts = "Chay";
            this.txtTenDN.UnderlinedStyle = false;
            this.txtTenDN._TextChanged += new System.EventHandler(this.rjTextBoxcs7__TextChanged);
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.txtMatKhau.BorderColor = System.Drawing.Color.LightGray;
            this.txtMatKhau.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtMatKhau.BorderRadius = 10;
            this.txtMatKhau.BorderSize = 3;
            this.txtMatKhau.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhau.ForeColor = System.Drawing.Color.White;
            this.txtMatKhau.Location = new System.Drawing.Point(154, 113);
            this.txtMatKhau.Margin = new System.Windows.Forms.Padding(4);
            this.txtMatKhau.Multiline = false;
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Padding = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.txtMatKhau.PasswordChar = false;
            this.txtMatKhau.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtMatKhau.PlaceholderText = "";
            this.txtMatKhau.Size = new System.Drawing.Size(224, 40);
            this.txtMatKhau.TabIndex = 15;
            this.txtMatKhau.Texts = "1234";
            this.txtMatKhau.UnderlinedStyle = false;
            this.txtMatKhau._TextChanged += new System.EventHandler(this.txtMatKhau__TextChanged);
            // 
            // FrmUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 519);
            this.Controls.Add(this.panelInFo);
            this.Name = "FrmUser";
            this.Text = "FrmUser";
            this.Load += new System.EventHandler(this.FrmUser_Load);
            this.panelInFo.ResumeLayout(false);
            this.panelInFo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelInFo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label MatKhau;
        private System.Windows.Forms.Label label2;
        private RJControl.RJTextBoxcs txtTenDN;
        private RJControl.RJTextBoxcs txtMatKhau;
        private RJControl.RJTextBoxcs txtQuyen;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pictureUser;
    }
}