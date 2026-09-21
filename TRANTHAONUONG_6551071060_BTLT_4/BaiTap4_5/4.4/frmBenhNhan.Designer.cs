namespace Chuong4_Bai4_PhongKhamMDI
{
    partial class frmBenhNhan
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblHoTen = new System.Windows.Forms.Label();
            this.lblTuoi = new System.Windows.Forms.Label();
            this.lblTrieuChung = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.numTuoi = new System.Windows.Forms.NumericUpDown();
            this.txtTrieuChung = new System.Windows.Forms.TextBox();
            this.btnLuuTam = new System.Windows.Forms.Button();
            this.lstBenhNhan = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.numTuoi)).BeginInit();
            this.SuspendLayout();
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(15, 18);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(50, 15);
            this.lblHoTen.Text = "Họ tên:";
            // 
            this.lblTuoi.AutoSize = true;
            this.lblTuoi.Location = new System.Drawing.Point(15, 53);
            this.lblTuoi.Name = "lblTuoi";
            this.lblTuoi.Size = new System.Drawing.Size(50, 15);
            this.lblTuoi.Text = "Tuổi:";
            // 
            this.lblTrieuChung.AutoSize = true;
            this.lblTrieuChung.Location = new System.Drawing.Point(15, 88);
            this.lblTrieuChung.Name = "lblTrieuChung";
            this.lblTrieuChung.Size = new System.Drawing.Size(50, 15);
            this.lblTrieuChung.Text = "Triệu chứng:";
            // 
            this.txtHoTen.Location = new System.Drawing.Point(110, 15);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(220, 23);
            this.txtHoTen.TabIndex = 0;
            // 
            this.numTuoi.Location = new System.Drawing.Point(110, 50);
            this.numTuoi.Maximum = new decimal(new int[] { 120, 0, 0, 0 });
            this.numTuoi.Name = "numTuoi";
            this.numTuoi.Size = new System.Drawing.Size(80, 23);
            this.numTuoi.TabIndex = 1;
            // 
            this.txtTrieuChung.Location = new System.Drawing.Point(110, 85);
            this.txtTrieuChung.Name = "txtTrieuChung";
            this.txtTrieuChung.Size = new System.Drawing.Size(220, 23);
            this.txtTrieuChung.TabIndex = 2;
            // 
            this.btnLuuTam.Location = new System.Drawing.Point(110, 120);
            this.btnLuuTam.Name = "btnLuuTam";
            this.btnLuuTam.Size = new System.Drawing.Size(110, 30);
            this.btnLuuTam.TabIndex = 3;
            this.btnLuuTam.Text = "Lưu tạm";
            this.btnLuuTam.UseVisualStyleBackColor = true;
            this.btnLuuTam.Click += new System.EventHandler(this.btnLuuTam_Click);
            // 
            this.lstBenhNhan.FormattingEnabled = true;
            this.lstBenhNhan.ItemHeight = 15;
            this.lstBenhNhan.Location = new System.Drawing.Point(15, 165);
            this.lstBenhNhan.Name = "lstBenhNhan";
            this.lstBenhNhan.Size = new System.Drawing.Size(360, 124);
            this.lstBenhNhan.TabIndex = 4;
            // 
            // frmBenhNhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 306);
            this.Controls.Add(this.lstBenhNhan);
            this.Controls.Add(this.btnLuuTam);
            this.Controls.Add(this.txtTrieuChung);
            this.Controls.Add(this.numTuoi);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.lblTrieuChung);
            this.Controls.Add(this.lblTuoi);
            this.Controls.Add(this.lblHoTen);
            this.Name = "frmBenhNhan";
            this.Text = "Thông tin bệnh nhân";
            ((System.ComponentModel.ISupportInitialize)(this.numTuoi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label lblTuoi;
        private System.Windows.Forms.Label lblTrieuChung;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.NumericUpDown numTuoi;
        private System.Windows.Forms.TextBox txtTrieuChung;
        private System.Windows.Forms.Button btnLuuTam;
        private System.Windows.Forms.ListBox lstBenhNhan;
    }
}
