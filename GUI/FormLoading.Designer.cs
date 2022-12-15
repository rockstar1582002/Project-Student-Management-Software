
namespace Quan_Ly_Sinh_Vien_Project.GUI
{
    partial class FormLoading
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
            this.components = new System.ComponentModel.Container();
            this.ProcessBarLoad = new CircularProgressBar.CircularProgressBar();
            this.panelLoading = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lblloading = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timerLoading = new System.Windows.Forms.Timer(this.components);
            this.panelLoading.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProcessBarLoad
            // 
            this.ProcessBarLoad.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.ProcessBarLoad.AnimationSpeed = 500;
            this.ProcessBarLoad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ProcessBarLoad.Font = new System.Drawing.Font("Times New Roman", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProcessBarLoad.ForeColor = System.Drawing.Color.SpringGreen;
            this.ProcessBarLoad.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ProcessBarLoad.InnerMargin = 2;
            this.ProcessBarLoad.InnerWidth = -1;
            this.ProcessBarLoad.Location = new System.Drawing.Point(383, 149);
            this.ProcessBarLoad.MarqueeAnimationSpeed = 2000;
            this.ProcessBarLoad.Name = "ProcessBarLoad";
            this.ProcessBarLoad.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(26)))), ((int)(((byte)(43)))));
            this.ProcessBarLoad.OuterMargin = -25;
            this.ProcessBarLoad.OuterWidth = 26;
            this.ProcessBarLoad.ProgressColor = System.Drawing.Color.MediumOrchid;
            this.ProcessBarLoad.ProgressWidth = 5;
            this.ProcessBarLoad.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.ProcessBarLoad.Size = new System.Drawing.Size(144, 146);
            this.ProcessBarLoad.StartAngle = 270;
            this.ProcessBarLoad.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.ProcessBarLoad.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.ProcessBarLoad.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.ProcessBarLoad.SubscriptText = "";
            this.ProcessBarLoad.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.ProcessBarLoad.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.ProcessBarLoad.SuperscriptText = "";
            this.ProcessBarLoad.TabIndex = 0;
            this.ProcessBarLoad.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.ProcessBarLoad.Value = 68;
            // 
            // panelLoading
            // 
            this.panelLoading.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelLoading.Controls.Add(this.label3);
            this.panelLoading.Controls.Add(this.lblloading);
            this.panelLoading.Controls.Add(this.label1);
            this.panelLoading.Controls.Add(this.ProcessBarLoad);
            this.panelLoading.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLoading.Location = new System.Drawing.Point(0, 0);
            this.panelLoading.Name = "panelLoading";
            this.panelLoading.Size = new System.Drawing.Size(892, 516);
            this.panelLoading.TabIndex = 1;
            this.panelLoading.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLoading_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MediumOrchid;
            this.label3.Location = new System.Drawing.Point(432, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "label3";
            // 
            // lblloading
            // 
            this.lblloading.AutoSize = true;
            this.lblloading.Font = new System.Drawing.Font("Times New Roman", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblloading.ForeColor = System.Drawing.Color.MediumOrchid;
            this.lblloading.Location = new System.Drawing.Point(377, 333);
            this.lblloading.Name = "lblloading";
            this.lblloading.Size = new System.Drawing.Size(131, 31);
            this.lblloading.TabIndex = 2;
            this.lblloading.Text = "Loading...";
            this.lblloading.Click += new System.EventHandler(this.lblloading_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumOrchid;
            this.label1.Location = new System.Drawing.Point(350, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quản Lý Học Sinh";
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timerLoading
            // 
            this.timerLoading.Enabled = true;
           // this.timerLoading.Tick += new System.EventHandler(this.timerLoading_Tick);
            // 
            // FormLoading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 516);
            this.Controls.Add(this.panelLoading);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLoading";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLoading";
            this.Load += new System.EventHandler(this.FormLoading_Load);
            this.panelLoading.ResumeLayout(false);
            this.panelLoading.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CircularProgressBar.CircularProgressBar ProcessBarLoad;
        private System.Windows.Forms.Panel panelLoading;
        private System.Windows.Forms.Label lblloading;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timerLoading;
    }
}