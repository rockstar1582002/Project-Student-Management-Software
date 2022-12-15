
namespace Quan_Ly_Sinh_Vien_Project.GUI
{
    partial class FrmGiaoVien
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelInFo = new System.Windows.Forms.Panel();
            this.cboIDMH = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDiaChi = new Quan_Ly_Sinh_Vien_Project.RJControl.RJTextBoxcs();
            this.label8 = new System.Windows.Forms.Label();
            this.txtIDGV = new Quan_Ly_Sinh_Vien_Project.RJControl.RJTextBoxcs();
            this.txtTenGV = new Quan_Ly_Sinh_Vien_Project.RJControl.RJTextBoxcs();
            this.txtTenMH = new Quan_Ly_Sinh_Vien_Project.RJControl.RJTextBoxcs();
            this.txtSDT = new Quan_Ly_Sinh_Vien_Project.RJControl.RJTextBoxcs();
            this.cboChucVu = new Quan_Ly_Sinh_Vien_Project.RJControl.RJCombobox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEmail = new Quan_Ly_Sinh_Vien_Project.RJControl.RJTextBoxcs();
            this.txtTimkiem = new Quan_Ly_Sinh_Vien_Project.RJControl.RJTextBoxcs();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelData = new System.Windows.Forms.Panel();
            this.dtgvGiaoVien = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnExcel = new Quan_Ly_Sinh_Vien_Project.UIConTrol.RJButton2();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEdit = new Quan_Ly_Sinh_Vien_Project.UIConTrol.RJButton2();
            this.btnDelete = new Quan_Ly_Sinh_Vien_Project.UIConTrol.RJButton2();
            this.btnADD = new Quan_Ly_Sinh_Vien_Project.UIConTrol.RJButton2();
            this.btnTimkiem = new Quan_Ly_Sinh_Vien_Project.UIConTrol.RJButton2();
            this.panelInFo.SuspendLayout();
            this.panelData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvGiaoVien)).BeginInit();
            this.SuspendLayout();
            // 
            // panelInFo
            // 
            this.panelInFo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelInFo.Controls.Add(this.cboIDMH);
            this.panelInFo.Controls.Add(this.label9);
            this.panelInFo.Controls.Add(this.txtDiaChi);
            this.panelInFo.Controls.Add(this.label8);
            this.panelInFo.Controls.Add(this.txtIDGV);
            this.panelInFo.Controls.Add(this.txtTenGV);
            this.panelInFo.Controls.Add(this.txtTenMH);
            this.panelInFo.Controls.Add(this.txtSDT);
            this.panelInFo.Controls.Add(this.cboChucVu);
            this.panelInFo.Controls.Add(this.label7);
            this.panelInFo.Controls.Add(this.txtEmail);
            this.panelInFo.Controls.Add(this.txtTimkiem);
            this.panelInFo.Controls.Add(this.btnTimkiem);
            this.panelInFo.Controls.Add(this.label6);
            this.panelInFo.Controls.Add(this.label5);
            this.panelInFo.Controls.Add(this.label4);
            this.panelInFo.Controls.Add(this.label3);
            this.panelInFo.Controls.Add(this.label2);
            this.panelInFo.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelInFo.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelInFo.Location = new System.Drawing.Point(0, 0);
            this.panelInFo.Name = "panelInFo";
            this.panelInFo.Size = new System.Drawing.Size(406, 472);
            this.panelInFo.TabIndex = 1;
            // 
            // cboIDMH
            // 
            this.cboIDMH.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cboIDMH.FormattingEnabled = true;
            this.cboIDMH.Location = new System.Drawing.Point(147, 105);
            this.cboIDMH.Name = "cboIDMH";
            this.cboIDMH.Size = new System.Drawing.Size(241, 30);
            this.cboIDMH.TabIndex = 48;
            this.cboIDMH.SelectionChangeCommitted += new System.EventHandler(this.cboIDMH_SelectionChangeCommitted);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(35, 121);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 22);
            this.label9.TabIndex = 47;
            this.label9.Text = "Mã MH:";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.txtDiaChi.BorderColor = System.Drawing.Color.Gold;
            this.txtDiaChi.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtDiaChi.BorderRadius = 10;
            this.txtDiaChi.BorderSize = 3;
            this.txtDiaChi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.ForeColor = System.Drawing.Color.White;
            this.txtDiaChi.Location = new System.Drawing.Point(138, 297);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(4);
            this.txtDiaChi.Multiline = false;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Padding = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.txtDiaChi.PasswordChar = false;
            this.txtDiaChi.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtDiaChi.PlaceholderText = "";
            this.txtDiaChi.Size = new System.Drawing.Size(250, 40);
            this.txtDiaChi.TabIndex = 45;
            this.txtDiaChi.Texts = "";
            this.txtDiaChi.UnderlinedStyle = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(33, 315);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 22);
            this.label8.TabIndex = 44;
            this.label8.Text = "Địa Chỉ:";
            // 
            // txtIDGV
            // 
            this.txtIDGV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.txtIDGV.BorderColor = System.Drawing.Color.Gold;
            this.txtIDGV.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtIDGV.BorderRadius = 10;
            this.txtIDGV.BorderSize = 3;
            this.txtIDGV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDGV.ForeColor = System.Drawing.Color.White;
            this.txtIDGV.Location = new System.Drawing.Point(138, 10);
            this.txtIDGV.Margin = new System.Windows.Forms.Padding(4);
            this.txtIDGV.Multiline = false;
            this.txtIDGV.Name = "txtIDGV";
            this.txtIDGV.Padding = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.txtIDGV.PasswordChar = false;
            this.txtIDGV.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtIDGV.PlaceholderText = "";
            this.txtIDGV.Size = new System.Drawing.Size(250, 40);
            this.txtIDGV.TabIndex = 43;
            this.txtIDGV.Texts = "";
            this.txtIDGV.UnderlinedStyle = false;
            // 
            // txtTenGV
            // 
            this.txtTenGV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.txtTenGV.BorderColor = System.Drawing.Color.Gold;
            this.txtTenGV.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtTenGV.BorderRadius = 10;
            this.txtTenGV.BorderSize = 3;
            this.txtTenGV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenGV.ForeColor = System.Drawing.Color.White;
            this.txtTenGV.Location = new System.Drawing.Point(138, 58);
            this.txtTenGV.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenGV.Multiline = false;
            this.txtTenGV.Name = "txtTenGV";
            this.txtTenGV.Padding = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.txtTenGV.PasswordChar = false;
            this.txtTenGV.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtTenGV.PlaceholderText = "";
            this.txtTenGV.Size = new System.Drawing.Size(250, 40);
            this.txtTenGV.TabIndex = 42;
            this.txtTenGV.Texts = "";
            this.txtTenGV.UnderlinedStyle = false;
            // 
            // txtTenMH
            // 
            this.txtTenMH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.txtTenMH.BorderColor = System.Drawing.Color.Gold;
            this.txtTenMH.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtTenMH.BorderRadius = 10;
            this.txtTenMH.BorderSize = 3;
            this.txtTenMH.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenMH.ForeColor = System.Drawing.Color.White;
            this.txtTenMH.Location = new System.Drawing.Point(138, 150);
            this.txtTenMH.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenMH.Multiline = false;
            this.txtTenMH.Name = "txtTenMH";
            this.txtTenMH.Padding = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.txtTenMH.PasswordChar = false;
            this.txtTenMH.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtTenMH.PlaceholderText = "";
            this.txtTenMH.Size = new System.Drawing.Size(250, 40);
            this.txtTenMH.TabIndex = 41;
            this.txtTenMH.Texts = "";
            this.txtTenMH.UnderlinedStyle = false;
            // 
            // txtSDT
            // 
            this.txtSDT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.txtSDT.BorderColor = System.Drawing.Color.Gold;
            this.txtSDT.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtSDT.BorderRadius = 10;
            this.txtSDT.BorderSize = 3;
            this.txtSDT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDT.ForeColor = System.Drawing.Color.White;
            this.txtSDT.Location = new System.Drawing.Point(138, 198);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(4);
            this.txtSDT.Multiline = false;
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Padding = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.txtSDT.PasswordChar = false;
            this.txtSDT.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtSDT.PlaceholderText = "";
            this.txtSDT.Size = new System.Drawing.Size(250, 40);
            this.txtSDT.TabIndex = 40;
            this.txtSDT.Texts = "";
            this.txtSDT.UnderlinedStyle = false;
            // 
            // cboChucVu
            // 
            this.cboChucVu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cboChucVu.BorderColor = System.Drawing.Color.Gold;
            this.cboChucVu.BorderSize = 3;
            this.cboChucVu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cboChucVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cboChucVu.ForeColor = System.Drawing.Color.DimGray;
            this.cboChucVu.IconColor = System.Drawing.Color.Gold;
            this.cboChucVu.Items.AddRange(new object[] {
            "Thỉnh Giảng",
            "Cơ Hữu"});
            this.cboChucVu.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cboChucVu.ListTextColor = System.Drawing.Color.DimGray;
            this.cboChucVu.Location = new System.Drawing.Point(138, 356);
            this.cboChucVu.MinimumSize = new System.Drawing.Size(200, 30);
            this.cboChucVu.Name = "cboChucVu";
            this.cboChucVu.Padding = new System.Windows.Forms.Padding(3);
            this.cboChucVu.Size = new System.Drawing.Size(250, 30);
            this.cboChucVu.TabIndex = 39;
            this.cboChucVu.Texts = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(26, 364);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 22);
            this.label7.TabIndex = 38;
            this.label7.Text = "Chức Vụ:";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.txtEmail.BorderColor = System.Drawing.Color.Gold;
            this.txtEmail.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtEmail.BorderRadius = 10;
            this.txtEmail.BorderSize = 3;
            this.txtEmail.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.White;
            this.txtEmail.Location = new System.Drawing.Point(138, 246);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Multiline = false;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Padding = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.txtEmail.PasswordChar = false;
            this.txtEmail.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtEmail.PlaceholderText = "";
            this.txtEmail.Size = new System.Drawing.Size(250, 40);
            this.txtEmail.TabIndex = 37;
            this.txtEmail.Texts = "";
            this.txtEmail.UnderlinedStyle = false;
            // 
            // txtTimkiem
            // 
            this.txtTimkiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.txtTimkiem.BorderColor = System.Drawing.Color.Gold;
            this.txtTimkiem.BorderFocusColor = System.Drawing.Color.Magenta;
            this.txtTimkiem.BorderRadius = 10;
            this.txtTimkiem.BorderSize = 3;
            this.txtTimkiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimkiem.ForeColor = System.Drawing.Color.White;
            this.txtTimkiem.Location = new System.Drawing.Point(133, 406);
            this.txtTimkiem.Margin = new System.Windows.Forms.Padding(4);
            this.txtTimkiem.Multiline = false;
            this.txtTimkiem.Name = "txtTimkiem";
            this.txtTimkiem.Padding = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.txtTimkiem.PasswordChar = false;
            this.txtTimkiem.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtTimkiem.PlaceholderText = "";
            this.txtTimkiem.Size = new System.Drawing.Size(266, 40);
            this.txtTimkiem.TabIndex = 36;
            this.txtTimkiem.Texts = "";
            this.txtTimkiem.UnderlinedStyle = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(33, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 22);
            this.label6.TabIndex = 28;
            this.label6.Text = "Email:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(33, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 22);
            this.label5.TabIndex = 27;
            this.label5.Text = "Điện Thoại:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(35, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 22);
            this.label4.TabIndex = 22;
            this.label4.Text = "Tên MH:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(35, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 22);
            this.label3.TabIndex = 21;
            this.label3.Text = "Tên GV:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(35, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 22);
            this.label2.TabIndex = 20;
            this.label2.Text = "Mã GV:";
            // 
            // panelData
            // 
            this.panelData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelData.Controls.Add(this.dtgvGiaoVien);
            this.panelData.Controls.Add(this.btnExcel);
            this.panelData.Controls.Add(this.label1);
            this.panelData.Controls.Add(this.btnEdit);
            this.panelData.Controls.Add(this.btnDelete);
            this.panelData.Controls.Add(this.btnADD);
            this.panelData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelData.Location = new System.Drawing.Point(406, 0);
            this.panelData.Name = "panelData";
            this.panelData.Size = new System.Drawing.Size(622, 472);
            this.panelData.TabIndex = 2;
            // 
            // dtgvGiaoVien
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dtgvGiaoVien.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvGiaoVien.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvGiaoVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvGiaoVien.ColumnHeadersHeight = 8;
            this.dtgvGiaoVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Ivory;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvGiaoVien.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvGiaoVien.GridColor = System.Drawing.Color.MediumOrchid;
            this.dtgvGiaoVien.Location = new System.Drawing.Point(6, 37);
            this.dtgvGiaoVien.Name = "dtgvGiaoVien";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvGiaoVien.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgvGiaoVien.RowHeadersVisible = false;
            this.dtgvGiaoVien.RowHeadersWidth = 50;
            this.dtgvGiaoVien.Size = new System.Drawing.Size(604, 363);
            this.dtgvGiaoVien.TabIndex = 24;
            this.dtgvGiaoVien.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgvGiaoVien.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtgvGiaoVien.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtgvGiaoVien.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtgvGiaoVien.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtgvGiaoVien.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.dtgvGiaoVien.ThemeStyle.GridColor = System.Drawing.Color.MediumOrchid;
            this.dtgvGiaoVien.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtgvGiaoVien.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgvGiaoVien.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgvGiaoVien.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtgvGiaoVien.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtgvGiaoVien.ThemeStyle.HeaderStyle.Height = 8;
            this.dtgvGiaoVien.ThemeStyle.ReadOnly = false;
            this.dtgvGiaoVien.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgvGiaoVien.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgvGiaoVien.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgvGiaoVien.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtgvGiaoVien.ThemeStyle.RowsStyle.Height = 22;
            this.dtgvGiaoVien.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgvGiaoVien.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtgvGiaoVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvGiaoVien_CellClick);
            // 
            // btnExcel
            // 
            this.btnExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnExcel.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnExcel.BorderColor = System.Drawing.Color.Lime;
            this.btnExcel.BorderRadius = 20;
            this.btnExcel.BorderSize = 2;
            this.btnExcel.FlatAppearance.BorderSize = 0;
            this.btnExcel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btnExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcel.ForeColor = System.Drawing.Color.White;
            this.btnExcel.Image = global::Quan_Ly_Sinh_Vien_Project.Properties.Resources.Excel2;
            this.btnExcel.Location = new System.Drawing.Point(366, 406);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(82, 44);
            this.btnExcel.TabIndex = 23;
            this.btnExcel.TextColor = System.Drawing.Color.White;
            this.btnExcel.UseVisualStyleBackColor = false;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(117, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 24);
            this.label1.TabIndex = 22;
            this.label1.Text = "Quản Lý Giáo Viên:";
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnEdit.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnEdit.BorderColor = System.Drawing.Color.Yellow;
            this.btnEdit.BorderRadius = 20;
            this.btnEdit.BorderSize = 2;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Image = global::Quan_Ly_Sinh_Vien_Project.Properties.Resources.Edit21;
            this.btnEdit.Location = new System.Drawing.Point(254, 406);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(82, 44);
            this.btnEdit.TabIndex = 20;
            this.btnEdit.TextColor = System.Drawing.Color.White;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnDelete.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnDelete.BorderColor = System.Drawing.Color.Blue;
            this.btnDelete.BorderRadius = 20;
            this.btnDelete.BorderSize = 2;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Image = global::Quan_Ly_Sinh_Vien_Project.Properties.Resources.DauTru2;
            this.btnDelete.Location = new System.Drawing.Point(143, 406);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(82, 44);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.TextColor = System.Drawing.Color.White;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnADD
            // 
            this.btnADD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnADD.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnADD.BorderColor = System.Drawing.Color.Red;
            this.btnADD.BorderRadius = 20;
            this.btnADD.BorderSize = 2;
            this.btnADD.FlatAppearance.BorderSize = 0;
            this.btnADD.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnADD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnADD.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnADD.ForeColor = System.Drawing.Color.White;
            this.btnADD.Image = global::Quan_Ly_Sinh_Vien_Project.Properties.Resources.Them2;
            this.btnADD.Location = new System.Drawing.Point(23, 406);
            this.btnADD.Name = "btnADD";
            this.btnADD.Size = new System.Drawing.Size(82, 44);
            this.btnADD.TabIndex = 18;
            this.btnADD.TextColor = System.Drawing.Color.White;
            this.btnADD.UseVisualStyleBackColor = false;
            this.btnADD.Click += new System.EventHandler(this.btnADD_Click);
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnTimkiem.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnTimkiem.BorderColor = System.Drawing.Color.Gold;
            this.btnTimkiem.BorderRadius = 20;
            this.btnTimkiem.BorderSize = 2;
            this.btnTimkiem.FlatAppearance.BorderSize = 0;
            this.btnTimkiem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
            this.btnTimkiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimkiem.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimkiem.ForeColor = System.Drawing.Color.White;
            this.btnTimkiem.Image = global::Quan_Ly_Sinh_Vien_Project.Properties.Resources.TK21;
            this.btnTimkiem.Location = new System.Drawing.Point(27, 406);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(92, 63);
            this.btnTimkiem.TabIndex = 24;
            this.btnTimkiem.TextColor = System.Drawing.Color.White;
            this.btnTimkiem.UseVisualStyleBackColor = false;
            // 
            // FrmGiaoVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 472);
            this.Controls.Add(this.panelData);
            this.Controls.Add(this.panelInFo);
            this.Name = "FrmGiaoVien";
            this.Text = "FrmGiaoVien";
            this.Load += new System.EventHandler(this.FrmGiaoVien_Load);
            this.panelInFo.ResumeLayout(false);
            this.panelInFo.PerformLayout();
            this.panelData.ResumeLayout(false);
            this.panelData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvGiaoVien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelInFo;
        private RJControl.RJTextBoxcs txtTimkiem;
        private UIConTrol.RJButton2 btnTimkiem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private RJControl.RJCombobox cboChucVu;
        private System.Windows.Forms.Label label7;
        private RJControl.RJTextBoxcs txtEmail;
        private System.Windows.Forms.Panel panelData;
        private Guna.UI2.WinForms.Guna2DataGridView dtgvGiaoVien;
        private UIConTrol.RJButton2 btnExcel;
        private System.Windows.Forms.Label label1;
        private UIConTrol.RJButton2 btnEdit;
        private UIConTrol.RJButton2 btnDelete;
        private UIConTrol.RJButton2 btnADD;
        private RJControl.RJTextBoxcs txtIDGV;
        private RJControl.RJTextBoxcs txtTenGV;
        private RJControl.RJTextBoxcs txtTenMH;
        private RJControl.RJTextBoxcs txtSDT;
        private RJControl.RJTextBoxcs txtDiaChi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboIDMH;
    }
}