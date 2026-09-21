namespace Chuong4_Bai4_PhongKhamMDI
{
    partial class frmLichHen
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblNgayGio = new System.Windows.Forms.Label();
            this.lblTenBN = new System.Windows.Forms.Label();
            this.dtpNgayHen = new System.Windows.Forms.DateTimePicker();
            this.txtTenBenhNhan = new System.Windows.Forms.TextBox();
            this.btnDatLich = new System.Windows.Forms.Button();
            this.lstLichHen = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            this.lblNgayGio.AutoSize = true;
            this.lblNgayGio.Location = new System.Drawing.Point(15, 18);
            this.lblNgayGio.Name = "lblNgayGio";
            this.lblNgayGio.Size = new System.Drawing.Size(50, 15);
            this.lblNgayGio.Text = "Ngày giờ hẹn:";
            // 
            this.lblTenBN.AutoSize = true;
            this.lblTenBN.Location = new System.Drawing.Point(15, 53);
            this.lblTenBN.Name = "lblTenBN";
            this.lblTenBN.Size = new System.Drawing.Size(50, 15);
            this.lblTenBN.Text = "Tên bệnh nhân:";
            // 
            this.dtpNgayHen.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtpNgayHen.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayHen.Location = new System.Drawing.Point(125, 15);
            this.dtpNgayHen.Name = "dtpNgayHen";
            this.dtpNgayHen.Size = new System.Drawing.Size(220, 23);
            this.dtpNgayHen.TabIndex = 0;
            // 
            this.txtTenBenhNhan.Location = new System.Drawing.Point(125, 50);
            this.txtTenBenhNhan.Name = "txtTenBenhNhan";
            this.txtTenBenhNhan.Size = new System.Drawing.Size(220, 23);
            this.txtTenBenhNhan.TabIndex = 1;
            // 
            this.btnDatLich.Location = new System.Drawing.Point(125, 85);
            this.btnDatLich.Name = "btnDatLich";
            this.btnDatLich.Size = new System.Drawing.Size(110, 30);
            this.btnDatLich.TabIndex = 2;
            this.btnDatLich.Text = "Đặt lịch";
            this.btnDatLich.UseVisualStyleBackColor = true;
            this.btnDatLich.Click += new System.EventHandler(this.btnDatLich_Click);
            // 
            this.lstLichHen.FormattingEnabled = true;
            this.lstLichHen.ItemHeight = 15;
            this.lstLichHen.Location = new System.Drawing.Point(15, 130);
            this.lstLichHen.Name = "lstLichHen";
            this.lstLichHen.Size = new System.Drawing.Size(360, 154);
            this.lstLichHen.TabIndex = 3;
            // 
            // frmLichHen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 301);
            this.Controls.Add(this.lstLichHen);
            this.Controls.Add(this.btnDatLich);
            this.Controls.Add(this.txtTenBenhNhan);
            this.Controls.Add(this.dtpNgayHen);
            this.Controls.Add(this.lblTenBN);
            this.Controls.Add(this.lblNgayGio);
            this.Name = "frmLichHen";
            this.Text = "Đặt lịch hẹn";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblNgayGio;
        private System.Windows.Forms.Label lblTenBN;
        private System.Windows.Forms.DateTimePicker dtpNgayHen;
        private System.Windows.Forms.TextBox txtTenBenhNhan;
        private System.Windows.Forms.Button btnDatLich;
        private System.Windows.Forms.ListBox lstLichHen;
    }
}
