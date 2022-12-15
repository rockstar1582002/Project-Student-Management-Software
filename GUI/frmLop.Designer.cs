
namespace Quan_Ly_Sinh_Vien_Project.GUI
{
    partial class frmLop
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelInFo = new System.Windows.Forms.Panel();
            this.cboIDGV = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGVCN = new Quan_Ly_Sinh_Vien_Project.RJControl.RJTextBoxcs();
            this.cboTenLop = new Quan_Ly_Sinh_Vien_Project.RJControl.RJCombobox();
            this.txtIDLop = new Quan_Ly_Sinh_Vien_Project.RJControl.RJTextBoxcs();
            this.txtGhiChu = new Quan_Ly_Sinh_Vien_Project.RJControl.RJTextBoxcs();
            this.panelData = new System.Windows.Forms.Panel();
            this.dtgvLop = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnExcel = new Quan_Ly_Sinh_Vien_Project.UIConTrol.RJButton2();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEdit = new Quan_Ly_Sinh_Vien_Project.UIConTrol.RJButton2();
            this.btnDelete = new Quan_Ly_Sinh_Vien_Project.UIConTrol.RJButton2();
            this.btnAdd = new Quan_Ly_Sinh_Vien_Project.UIConTrol.RJButton2();
            this.panelInFo.SuspendLayout();
            this.panelData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvLop)).BeginInit();
            this.SuspendLayout();
            // 
            // panelInFo
            // 
            this.panelInFo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelInFo.Controls.Add(this.cboIDGV);
            this.panelInFo.Controls.Add(this.label6);
            this.panelInFo.Controls.Add(this.label5);
            this.panelInFo.Controls.Add(this.label4);
            this.panelInFo.Controls.Add(this.label3);
            this.panelInFo.Controls.Add(this.label2);
            this.panelInFo.Controls.Add(this.txtGVCN);
            this.panelInFo.Controls.Add(this.cboTenLop);
            this.panelInFo.Controls.Add(this.txtIDLop);
            this.panelInFo.Controls.Add(this.txtGhiChu);
            this.panelInFo.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelInFo.Location = new System.Drawing.Point(0, 0);
            this.panelInFo.Name = "panelInFo";
            this.panelInFo.Size = new System.Drawing.Size(406, 450);
            this.panelInFo.TabIndex = 3;
            // 
            // cboIDGV
            // 
            this.cboIDGV.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cboIDGV.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboIDGV.FormattingEnabled = true;
            this.cboIDGV.Location = new System.Drawing.Point(145, 170);
            this.cboIDGV.Name = "cboIDGV";
            this.cboIDGV.Size = new System.Drawing.Size(204, 30);
            this.cboIDGV.TabIndex = 29;
            this.cboIDGV.SelectionChangeCommitted += new System.EventHandler(this.cboIDGV_SelectionChangeCommitted);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(31, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 19);
            this.label6.TabIndex = 28;
            this.label6.Text = "Mã Giáo Viên:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(31, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 19);
            this.label5.TabIndex = 27;
            this.label5.Text = "Tên GVCN:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(31, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 19);
            this.label4.TabIndex = 26;
            this.label4.Text = "Ghi Chú:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(33, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 19);
            this.label3.TabIndex = 23;
            this.label3.Text = "Tên Lớp:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(33, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 19);
            this.label2.TabIndex = 22;
            this.label2.Text = "Mã Lớp:";
            // 
            // txtGVCN
            // 
            this.txtGVCN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.txtGVCN.BorderColor = System.Drawing.Color.Red;
            this.txtGVCN.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtGVCN.BorderRadius = 10;
            this.txtGVCN.BorderSize = 3;
            this.txtGVCN.Enabled = false;
            this.txtGVCN.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGVCN.ForeColor = System.Drawing.Color.White;
            this.txtGVCN.Location = new System.Drawing.Point(142, 207);
            this.txtGVCN.Margin = new System.Windows.Forms.Padding(4);
            this.txtGVCN.Multiline = false;
            this.txtGVCN.Name = "txtGVCN";
            this.txtGVCN.Padding = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.txtGVCN.PasswordChar = false;
            this.txtGVCN.PlaceholderColor = System.Drawing.Color.White;
            this.txtGVCN.PlaceholderText = "";
            this.txtGVCN.Size = new System.Drawing.Size(207, 40);
            this.txtGVCN.TabIndex = 21;
            this.txtGVCN.Texts = "";
            this.txtGVCN.UnderlinedStyle = false;
            // 
            // cboTenLop
            // 
            this.cboTenLop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.cboTenLop.BorderColor = System.Drawing.Color.Red;
            this.cboTenLop.BorderSize = 3;
            this.cboTenLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cboTenLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTenLop.ForeColor = System.Drawing.Color.White;
            this.cboTenLop.IconColor = System.Drawing.Color.Red;
            this.cboTenLop.Items.AddRange(new object[] {
            "A1",
            "A2",
            "B1",
            "B2",
            "C1",
            "C2"});
            this.cboTenLop.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cboTenLop.ListTextColor = System.Drawing.Color.DimGray;
            this.cboTenLop.Location = new System.Drawing.Point(145, 86);
            this.cboTenLop.MinimumSize = new System.Drawing.Size(200, 30);
            this.cboTenLop.Name = "cboTenLop";
            this.cboTenLop.Padding = new System.Windows.Forms.Padding(3);
            this.cboTenLop.Size = new System.Drawing.Size(200, 30);
            this.cboTenLop.TabIndex = 20;
            this.cboTenLop.Texts = "";
            // 
            // txtIDLop
            // 
            this.txtIDLop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.txtIDLop.BorderColor = System.Drawing.Color.Red;
            this.txtIDLop.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtIDLop.BorderRadius = 10;
            this.txtIDLop.BorderSize = 3;
            this.txtIDLop.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDLop.ForeColor = System.Drawing.Color.White;
            this.txtIDLop.Location = new System.Drawing.Point(145, 32);
            this.txtIDLop.Margin = new System.Windows.Forms.Padding(4);
            this.txtIDLop.Multiline = false;
            this.txtIDLop.Name = "txtIDLop";
            this.txtIDLop.Padding = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.txtIDLop.PasswordChar = false;
            this.txtIDLop.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtIDLop.PlaceholderText = "";
            this.txtIDLop.Size = new System.Drawing.Size(203, 40);
            this.txtIDLop.TabIndex = 17;
            this.txtIDLop.Texts = "";
            this.txtIDLop.UnderlinedStyle = false;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.txtGhiChu.BorderColor = System.Drawing.Color.Red;
            this.txtGhiChu.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtGhiChu.BorderRadius = 10;
            this.txtGhiChu.BorderSize = 3;
            this.txtGhiChu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGhiChu.ForeColor = System.Drawing.Color.White;
            this.txtGhiChu.Location = new System.Drawing.Point(142, 123);
            this.txtGhiChu.Margin = new System.Windows.Forms.Padding(4);
            this.txtGhiChu.Multiline = false;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Padding = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.txtGhiChu.PasswordChar = false;
            this.txtGhiChu.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtGhiChu.PlaceholderText = "";
            this.txtGhiChu.Size = new System.Drawing.Size(203, 40);
            this.txtGhiChu.TabIndex = 15;
            this.txtGhiChu.Texts = "";
            this.txtGhiChu.UnderlinedStyle = false;
            // 
            // panelData
            // 
            this.panelData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelData.Controls.Add(this.dtgvLop);
            this.panelData.Controls.Add(this.btnExcel);
            this.panelData.Controls.Add(this.label1);
            this.panelData.Controls.Add(this.btnEdit);
            this.panelData.Controls.Add(this.btnDelete);
            this.panelData.Controls.Add(this.btnAdd);
            this.panelData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelData.Location = new System.Drawing.Point(406, 0);
            this.panelData.Name = "panelData";
            this.panelData.Size = new System.Drawing.Size(715, 450);
            this.panelData.TabIndex = 4;
            // 
            // dtgvLop
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            this.dtgvLop.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Nirmala UI Semilight", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvLop.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dtgvLop.ColumnHeadersHeight = 4;
            this.dtgvLop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvLop.DefaultCellStyle = dataGridViewCellStyle7;
            this.dtgvLop.GridColor = System.Drawing.Color.Red;
            this.dtgvLop.Location = new System.Drawing.Point(6, 56);
            this.dtgvLop.Name = "dtgvLop";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvLop.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dtgvLop.RowHeadersVisible = false;
            this.dtgvLop.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dtgvLop.Size = new System.Drawing.Size(706, 325);
            this.dtgvLop.TabIndex = 25;
            this.dtgvLop.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgvLop.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtgvLop.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtgvLop.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtgvLop.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtgvLop.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dtgvLop.ThemeStyle.GridColor = System.Drawing.Color.Red;
            this.dtgvLop.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtgvLop.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgvLop.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgvLop.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtgvLop.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtgvLop.ThemeStyle.HeaderStyle.Height = 4;
            this.dtgvLop.ThemeStyle.ReadOnly = false;
            this.dtgvLop.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgvLop.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgvLop.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgvLop.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtgvLop.ThemeStyle.RowsStyle.Height = 22;
            this.dtgvLop.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgvLop.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtgvLop.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvLop_CellContentClick);
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
            this.btnExcel.Image = global::Quan_Ly_Sinh_Vien_Project.Properties.Resources.Excel21;
            this.btnExcel.Location = new System.Drawing.Point(287, 403);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(82, 44);
            this.btnExcel.TabIndex = 24;
            this.btnExcel.TextColor = System.Drawing.Color.White;
            this.btnExcel.UseVisualStyleBackColor = false;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            this.btnExcel.MouseLeave += new System.EventHandler(this.btnExcel_MouseLeave);
            this.btnExcel.MouseHover += new System.EventHandler(this.btnExcel_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(117, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 24);
            this.label1.TabIndex = 22;
            this.label1.Text = "Quản Lý Lớp";
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
            this.btnEdit.Image = global::Quan_Ly_Sinh_Vien_Project.Properties.Resources.Edit2;
            this.btnEdit.Location = new System.Drawing.Point(188, 403);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(82, 44);
            this.btnEdit.TabIndex = 20;
            this.btnEdit.TextColor = System.Drawing.Color.White;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.rjButton23_Click);
            this.btnEdit.MouseLeave += new System.EventHandler(this.btnEdit_MouseLeave);
            this.btnEdit.MouseHover += new System.EventHandler(this.btnEdit_MouseHover);
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
            this.btnDelete.Image = global::Quan_Ly_Sinh_Vien_Project.Properties.Resources.DauTru21;
            this.btnDelete.Location = new System.Drawing.Point(91, 403);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(82, 44);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.TextColor = System.Drawing.Color.White;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.rjButton22_Click);
            this.btnDelete.MouseLeave += new System.EventHandler(this.btnDelete_MouseLeave);
            this.btnDelete.MouseHover += new System.EventHandler(this.btnDelete_MouseHover);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnAdd.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnAdd.BorderColor = System.Drawing.Color.Red;
            this.btnAdd.BorderRadius = 20;
            this.btnAdd.BorderSize = 2;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Image = global::Quan_Ly_Sinh_Vien_Project.Properties.Resources.Them21;
            this.btnAdd.Location = new System.Drawing.Point(3, 406);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(82, 44);
            this.btnAdd.TabIndex = 18;
            this.btnAdd.TextColor = System.Drawing.Color.White;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            this.btnAdd.MouseLeave += new System.EventHandler(this.btnAdd_MouseLeave);
            this.btnAdd.MouseHover += new System.EventHandler(this.btnAdd_MouseHover);
            // 
            // frmLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 450);
            this.Controls.Add(this.panelData);
            this.Controls.Add(this.panelInFo);
            this.Name = "frmLop";
            this.Text = "Lop";
            this.Load += new System.EventHandler(this.frmLop_Load);
            this.panelInFo.ResumeLayout(false);
            this.panelInFo.PerformLayout();
            this.panelData.ResumeLayout(false);
            this.panelData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvLop)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelInFo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private RJControl.RJTextBoxcs txtGVCN;
        private RJControl.RJCombobox cboTenLop;
        private RJControl.RJTextBoxcs txtIDLop;
        private RJControl.RJTextBoxcs txtGhiChu;
        private System.Windows.Forms.Panel panelData;
        private UIConTrol.RJButton2 btnExcel;
        private System.Windows.Forms.Label label1;
        private UIConTrol.RJButton2 btnEdit;
        private UIConTrol.RJButton2 btnDelete;
        private UIConTrol.RJButton2 btnAdd;
        private Guna.UI2.WinForms.Guna2DataGridView dtgvLop;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboIDGV;
    }
}