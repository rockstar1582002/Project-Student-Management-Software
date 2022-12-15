
namespace Quan_Ly_Sinh_Vien_Project.GUI
{
    partial class FrmAdmin
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
            this.btnUpload = new Guna.UI2.WinForms.Guna2Button();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.pictureAvatar = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.txtQuyen1 = new Quan_Ly_Sinh_Vien_Project.RJControl.RJTextBoxcs();
            this.label4 = new System.Windows.Forms.Label();
            this.MatKhau = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenDN1 = new Quan_Ly_Sinh_Vien_Project.RJControl.RJTextBoxcs();
            this.txtMatKhau1 = new Quan_Ly_Sinh_Vien_Project.RJControl.RJTextBoxcs();
            this.panelInFo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // panelInFo
            // 
            this.panelInFo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelInFo.Controls.Add(this.btnUpload);
            this.panelInFo.Controls.Add(this.btnSave);
            this.panelInFo.Controls.Add(this.pictureAvatar);
            this.panelInFo.Controls.Add(this.txtQuyen1);
            this.panelInFo.Controls.Add(this.label4);
            this.panelInFo.Controls.Add(this.MatKhau);
            this.panelInFo.Controls.Add(this.label2);
            this.panelInFo.Controls.Add(this.txtTenDN1);
            this.panelInFo.Controls.Add(this.txtMatKhau1);
            this.panelInFo.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelInFo.Location = new System.Drawing.Point(0, 0);
            this.panelInFo.Name = "panelInFo";
            this.panelInFo.Size = new System.Drawing.Size(986, 498);
            this.panelInFo.TabIndex = 3;
            // 
            // btnUpload
            // 
            this.btnUpload.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpload.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpload.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpload.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpload.FillColor = System.Drawing.Color.Red;
            this.btnUpload.Font = new System.Drawing.Font("Stencil", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnUpload.ForeColor = System.Drawing.Color.White;
            this.btnUpload.Location = new System.Drawing.Point(443, 243);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(180, 45);
            this.btnUpload.TabIndex = 24;
            this.btnUpload.Text = "UPLOAD";
            this.btnUpload.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // btnSave
            // 
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.FillColor = System.Drawing.Color.Lime;
            this.btnSave.Font = new System.Drawing.Font("Stencil", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(653, 243);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(180, 45);
            this.btnSave.TabIndex = 25;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.guna2Button1_Click_1);
            // 
            // pictureAvatar
            // 
            this.pictureAvatar.ImageRotate = 0F;
            this.pictureAvatar.Location = new System.Drawing.Point(491, 12);
            this.pictureAvatar.Name = "pictureAvatar";
            this.pictureAvatar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pictureAvatar.Size = new System.Drawing.Size(272, 216);
            this.pictureAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureAvatar.TabIndex = 23;
            this.pictureAvatar.TabStop = false;
            // 
            // txtQuyen1
            // 
            this.txtQuyen1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.txtQuyen1.BorderColor = System.Drawing.Color.LightGray;
            this.txtQuyen1.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtQuyen1.BorderRadius = 10;
            this.txtQuyen1.BorderSize = 3;
            this.txtQuyen1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuyen1.ForeColor = System.Drawing.Color.White;
            this.txtQuyen1.Location = new System.Drawing.Point(154, 168);
            this.txtQuyen1.Margin = new System.Windows.Forms.Padding(4);
            this.txtQuyen1.Multiline = false;
            this.txtQuyen1.Name = "txtQuyen1";
            this.txtQuyen1.Padding = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.txtQuyen1.PasswordChar = false;
            this.txtQuyen1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtQuyen1.PlaceholderText = "";
            this.txtQuyen1.Size = new System.Drawing.Size(224, 40);
            this.txtQuyen1.TabIndex = 22;
            this.txtQuyen1.Texts = "admin";
            this.txtQuyen1.UnderlinedStyle = false;
            this.txtQuyen1._TextChanged += new System.EventHandler(this.txtQuyen1__TextChanged);
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
            // txtTenDN1
            // 
            this.txtTenDN1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.txtTenDN1.BorderColor = System.Drawing.Color.LightGray;
            this.txtTenDN1.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtTenDN1.BorderRadius = 10;
            this.txtTenDN1.BorderSize = 3;
            this.txtTenDN1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDN1.ForeColor = System.Drawing.Color.White;
            this.txtTenDN1.Location = new System.Drawing.Point(152, 52);
            this.txtTenDN1.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenDN1.Multiline = false;
            this.txtTenDN1.Name = "txtTenDN1";
            this.txtTenDN1.Padding = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.txtTenDN1.PasswordChar = false;
            this.txtTenDN1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtTenDN1.PlaceholderText = "";
            this.txtTenDN1.Size = new System.Drawing.Size(224, 40);
            this.txtTenDN1.TabIndex = 17;
            this.txtTenDN1.Texts = "admin1234";
            this.txtTenDN1.UnderlinedStyle = false;
            this.txtTenDN1._TextChanged += new System.EventHandler(this.txtTenDN__TextChanged);
            // 
            // txtMatKhau1
            // 
            this.txtMatKhau1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.txtMatKhau1.BorderColor = System.Drawing.Color.LightGray;
            this.txtMatKhau1.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtMatKhau1.BorderRadius = 10;
            this.txtMatKhau1.BorderSize = 3;
            this.txtMatKhau1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhau1.ForeColor = System.Drawing.Color.White;
            this.txtMatKhau1.Location = new System.Drawing.Point(154, 113);
            this.txtMatKhau1.Margin = new System.Windows.Forms.Padding(4);
            this.txtMatKhau1.Multiline = false;
            this.txtMatKhau1.Name = "txtMatKhau1";
            this.txtMatKhau1.Padding = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.txtMatKhau1.PasswordChar = false;
            this.txtMatKhau1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtMatKhau1.PlaceholderText = "";
            this.txtMatKhau1.Size = new System.Drawing.Size(224, 40);
            this.txtMatKhau1.TabIndex = 15;
            this.txtMatKhau1.Texts = "1234";
            this.txtMatKhau1.UnderlinedStyle = false;
            this.txtMatKhau1._TextChanged += new System.EventHandler(this.txtMatKhau1__TextChanged);
            // 
            // FrmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 498);
            this.Controls.Add(this.panelInFo);
            this.Name = "FrmAdmin";
            this.Text = "FrmAdmin";
            this.Load += new System.EventHandler(this.FrmAdmin_Load);
            this.panelInFo.ResumeLayout(false);
            this.panelInFo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAvatar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelInFo;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pictureAvatar;
        private RJControl.RJTextBoxcs txtQuyen1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label MatKhau;
        private System.Windows.Forms.Label label2;
        private RJControl.RJTextBoxcs txtTenDN1;
        private RJControl.RJTextBoxcs txtMatKhau1;
        private Guna.UI2.WinForms.Guna2Button btnUpload;
        private Guna.UI2.WinForms.Guna2Button btnSave;
    }
}