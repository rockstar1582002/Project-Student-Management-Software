
namespace Quan_Ly_Sinh_Vien_Project.GUI
{
    partial class frmMonHoc
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
            this.panelInFo = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboTrangThai = new Quan_Ly_Sinh_Vien_Project.RJControl.RJCombobox();
            this.txtIDMonHoc = new Quan_Ly_Sinh_Vien_Project.RJControl.RJTextBoxcs();
            this.txtTenMonHoc = new Quan_Ly_Sinh_Vien_Project.RJControl.RJTextBoxcs();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelData = new System.Windows.Forms.Panel();
            this.dtgvMonHoc = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnExcel = new Quan_Ly_Sinh_Vien_Project.UIConTrol.RJButton2();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEdit = new Quan_Ly_Sinh_Vien_Project.UIConTrol.RJButton2();
            this.btnDelete = new Quan_Ly_Sinh_Vien_Project.UIConTrol.RJButton2();
            this.btnAdd = new Quan_Ly_Sinh_Vien_Project.UIConTrol.RJButton2();
            this.panelInFo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMonHoc)).BeginInit();
            this.SuspendLayout();
            // 
            // panelInFo
            // 
            this.panelInFo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelInFo.Controls.Add(this.label4);
            this.panelInFo.Controls.Add(this.label3);
            this.panelInFo.Controls.Add(this.label2);
            this.panelInFo.Controls.Add(this.cboTrangThai);
            this.panelInFo.Controls.Add(this.txtIDMonHoc);
            this.panelInFo.Controls.Add(this.txtTenMonHoc);
            this.panelInFo.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelInFo.Location = new System.Drawing.Point(0, 0);
            this.panelInFo.Name = "panelInFo";
            this.panelInFo.Size = new System.Drawing.Size(406, 451);
            this.panelInFo.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(40, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 19);
            this.label4.TabIndex = 21;
            this.label4.Text = "Trạng Thái";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(40, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 19);
            this.label3.TabIndex = 20;
            this.label3.Text = "Tên Môn Học:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(40, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 19);
            this.label2.TabIndex = 19;
            this.label2.Text = "Mã Môn Học:";
            // 
            // cboTrangThai
            // 
            this.cboTrangThai.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cboTrangThai.BorderColor = System.Drawing.Color.Aqua;
            this.cboTrangThai.BorderSize = 3;
            this.cboTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cboTrangThai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cboTrangThai.ForeColor = System.Drawing.Color.DimGray;
            this.cboTrangThai.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cboTrangThai.Items.AddRange(new object[] {
            "ON",
            "OFF"});
            this.cboTrangThai.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cboTrangThai.ListTextColor = System.Drawing.Color.DimGray;
            this.cboTrangThai.Location = new System.Drawing.Point(152, 178);
            this.cboTrangThai.MinimumSize = new System.Drawing.Size(200, 30);
            this.cboTrangThai.Name = "cboTrangThai";
            this.cboTrangThai.Padding = new System.Windows.Forms.Padding(3);
            this.cboTrangThai.Size = new System.Drawing.Size(224, 30);
            this.cboTrangThai.TabIndex = 18;
            this.cboTrangThai.Texts = "";
            // 
            // txtIDMonHoc
            // 
            this.txtIDMonHoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.txtIDMonHoc.BorderColor = System.Drawing.Color.Aqua;
            this.txtIDMonHoc.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtIDMonHoc.BorderRadius = 10;
            this.txtIDMonHoc.BorderSize = 3;
            this.txtIDMonHoc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDMonHoc.ForeColor = System.Drawing.Color.White;
            this.txtIDMonHoc.Location = new System.Drawing.Point(152, 52);
            this.txtIDMonHoc.Margin = new System.Windows.Forms.Padding(4);
            this.txtIDMonHoc.Multiline = false;
            this.txtIDMonHoc.Name = "txtIDMonHoc";
            this.txtIDMonHoc.Padding = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.txtIDMonHoc.PasswordChar = false;
            this.txtIDMonHoc.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtIDMonHoc.PlaceholderText = "";
            this.txtIDMonHoc.Size = new System.Drawing.Size(224, 40);
            this.txtIDMonHoc.TabIndex = 17;
            this.txtIDMonHoc.Texts = "";
            this.txtIDMonHoc.UnderlinedStyle = false;
            // 
            // txtTenMonHoc
            // 
            this.txtTenMonHoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.txtTenMonHoc.BorderColor = System.Drawing.Color.Aqua;
            this.txtTenMonHoc.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtTenMonHoc.BorderRadius = 10;
            this.txtTenMonHoc.BorderSize = 3;
            this.txtTenMonHoc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenMonHoc.ForeColor = System.Drawing.Color.White;
            this.txtTenMonHoc.Location = new System.Drawing.Point(152, 113);
            this.txtTenMonHoc.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenMonHoc.Multiline = false;
            this.txtTenMonHoc.Name = "txtTenMonHoc";
            this.txtTenMonHoc.Padding = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.txtTenMonHoc.PasswordChar = false;
            this.txtTenMonHoc.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtTenMonHoc.PlaceholderText = "";
            this.txtTenMonHoc.Size = new System.Drawing.Size(224, 40);
            this.txtTenMonHoc.TabIndex = 15;
            this.txtTenMonHoc.Texts = "";
            this.txtTenMonHoc.UnderlinedStyle = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panelData);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(406, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(673, 451);
            this.panel1.TabIndex = 2;
            // 
            // panelData
            // 
            this.panelData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelData.Controls.Add(this.dtgvMonHoc);
            this.panelData.Controls.Add(this.btnExcel);
            this.panelData.Controls.Add(this.label1);
            this.panelData.Controls.Add(this.btnEdit);
            this.panelData.Controls.Add(this.btnDelete);
            this.panelData.Controls.Add(this.btnAdd);
            this.panelData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelData.Location = new System.Drawing.Point(0, 0);
            this.panelData.Name = "panelData";
            this.panelData.Size = new System.Drawing.Size(673, 451);
            this.panelData.TabIndex = 2;
            // 
            // dtgvMonHoc
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dtgvMonHoc.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvMonHoc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvMonHoc.ColumnHeadersHeight = 4;
            this.dtgvMonHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvMonHoc.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvMonHoc.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgvMonHoc.Location = new System.Drawing.Point(16, 52);
            this.dtgvMonHoc.Name = "dtgvMonHoc";
            this.dtgvMonHoc.RowHeadersVisible = false;
            this.dtgvMonHoc.Size = new System.Drawing.Size(645, 320);
            this.dtgvMonHoc.TabIndex = 25;
            this.dtgvMonHoc.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgvMonHoc.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtgvMonHoc.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtgvMonHoc.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtgvMonHoc.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtgvMonHoc.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dtgvMonHoc.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgvMonHoc.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtgvMonHoc.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgvMonHoc.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgvMonHoc.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtgvMonHoc.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtgvMonHoc.ThemeStyle.HeaderStyle.Height = 4;
            this.dtgvMonHoc.ThemeStyle.ReadOnly = false;
            this.dtgvMonHoc.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgvMonHoc.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgvMonHoc.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgvMonHoc.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtgvMonHoc.ThemeStyle.RowsStyle.Height = 22;
            this.dtgvMonHoc.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgvMonHoc.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
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
            this.btnExcel.Location = new System.Drawing.Point(309, 403);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(82, 44);
            this.btnExcel.TabIndex = 24;
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
            this.label1.Size = new System.Drawing.Size(173, 24);
            this.label1.TabIndex = 22;
            this.label1.Text = "Quản Lý Môn Học";
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
            this.btnEdit.Image = global::Quan_Ly_Sinh_Vien_Project.Properties.Resources.Edit22;
            this.btnEdit.Location = new System.Drawing.Point(214, 403);
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
            this.btnDelete.Image = global::Quan_Ly_Sinh_Vien_Project.Properties.Resources.DauTru22;
            this.btnDelete.Location = new System.Drawing.Point(112, 403);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(82, 44);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.TextColor = System.Drawing.Color.White;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
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
            this.btnAdd.Image = global::Quan_Ly_Sinh_Vien_Project.Properties.Resources.Them22;
            this.btnAdd.Location = new System.Drawing.Point(3, 406);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(82, 44);
            this.btnAdd.TabIndex = 18;
            this.btnAdd.TextColor = System.Drawing.Color.White;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.rjButton21_Click);
            // 
            // frmMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 451);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelInFo);
            this.Name = "frmMonHoc";
            this.Text = "frmMonHoc";
            this.Load += new System.EventHandler(this.frmMonHoc_Load);
            this.panelInFo.ResumeLayout(false);
            this.panelInFo.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panelData.ResumeLayout(false);
            this.panelData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMonHoc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelInFo;
        private RJControl.RJTextBoxcs txtIDMonHoc;
        private RJControl.RJTextBoxcs txtTenMonHoc;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelData;
        private System.Windows.Forms.Label label1;
        private UIConTrol.RJButton2 btnEdit;
        private UIConTrol.RJButton2 btnDelete;
        private UIConTrol.RJButton2 btnAdd;
        private UIConTrol.RJButton2 btnExcel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private RJControl.RJCombobox cboTrangThai;
        private Guna.UI2.WinForms.Guna2DataGridView dtgvMonHoc;
    }
}