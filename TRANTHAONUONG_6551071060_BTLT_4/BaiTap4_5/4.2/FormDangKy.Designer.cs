namespace Chuong4_Bai2_GymDangKy
{
    partial class FormDangKy
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.lblSDT = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.lblGoiTap = new System.Windows.Forms.Label();
            this.lblSoBuoi = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.cboGoiTap = new System.Windows.Forms.ComboBox();
            this.numSoBuoiTuan = new System.Windows.Forms.NumericUpDown();
            this.btnDangKy = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numSoBuoiTuan)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(25, 28);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(50, 15);
            this.lblHoTen.TabIndex = 0;
            this.lblHoTen.Text = "Họ tên:";
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Location = new System.Drawing.Point(25, 63);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(50, 15);
            this.lblSDT.TabIndex = 2;
            this.lblSDT.Text = "Số điện thoại:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(25, 98);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(50, 15);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "Email:";
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Location = new System.Drawing.Point(25, 133);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(50, 15);
            this.lblNgaySinh.TabIndex = 6;
            this.lblNgaySinh.Text = "Ngày sinh:";
            // 
            // lblGoiTap
            // 
            this.lblGoiTap.AutoSize = true;
            this.lblGoiTap.Location = new System.Drawing.Point(25, 168);
            this.lblGoiTap.Name = "lblGoiTap";
            this.lblGoiTap.Size = new System.Drawing.Size(50, 15);
            this.lblGoiTap.TabIndex = 8;
            this.lblGoiTap.Text = "Gói tập:";
            // 
            // lblSoBuoi
            // 
            this.lblSoBuoi.AutoSize = true;
            this.lblSoBuoi.Location = new System.Drawing.Point(25, 203);
            this.lblSoBuoi.Name = "lblSoBuoi";
            this.lblSoBuoi.Size = new System.Drawing.Size(50, 15);
            this.lblSoBuoi.TabIndex = 10;
            this.lblSoBuoi.Text = "Số buổi/tuần:";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(140, 25);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(230, 23);
            this.txtHoTen.TabIndex = 1;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(140, 60);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(230, 23);
            this.txtSDT.TabIndex = 3;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(140, 95);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(230, 23);
            this.txtEmail.TabIndex = 5;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinh.Location = new System.Drawing.Point(140, 130);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(230, 23);
            this.dtpNgaySinh.TabIndex = 7;
            // 
            // cboGoiTap
            // 
            this.cboGoiTap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGoiTap.FormattingEnabled = true;
            this.cboGoiTap.Items.AddRange(new object[] { "Basic", "VIP", "Premium" });
            this.cboGoiTap.Location = new System.Drawing.Point(140, 165);
            this.cboGoiTap.Name = "cboGoiTap";
            this.cboGoiTap.Size = new System.Drawing.Size(230, 23);
            this.cboGoiTap.TabIndex = 9;
            // 
            // numSoBuoiTuan
            // 
            this.numSoBuoiTuan.Location = new System.Drawing.Point(140, 200);
            this.numSoBuoiTuan.Maximum = new decimal(new int[] { 7, 0, 0, 0 });
            this.numSoBuoiTuan.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.numSoBuoiTuan.Name = "numSoBuoiTuan";
            this.numSoBuoiTuan.Size = new System.Drawing.Size(80, 23);
            this.numSoBuoiTuan.TabIndex = 11;
            this.numSoBuoiTuan.Value = new decimal(new int[] { 3, 0, 0, 0 });
            // 
            // btnDangKy
            // 
            this.btnDangKy.Location = new System.Drawing.Point(140, 240);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(120, 34);
            this.btnDangKy.TabIndex = 12;
            this.btnDangKy.Text = "Đăng ký";
            this.btnDangKy.UseVisualStyleBackColor = true;
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
            // 
            // FormDangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 301);
            this.Controls.Add(this.btnDangKy);
            this.Controls.Add(this.numSoBuoiTuan);
            this.Controls.Add(this.cboGoiTap);
            this.Controls.Add(this.dtpNgaySinh);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.lblSoBuoi);
            this.Controls.Add(this.lblGoiTap);
            this.Controls.Add(this.lblNgaySinh);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblSDT);
            this.Controls.Add(this.lblHoTen);
            this.Name = "FormDangKy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng ký hội viên - Gym FitLife";
            ((System.ComponentModel.ISupportInitialize)(this.numSoBuoiTuan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.Label lblGoiTap;
        private System.Windows.Forms.Label lblSoBuoi;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.ComboBox cboGoiTap;
        private System.Windows.Forms.NumericUpDown numSoBuoiTuan;
        private System.Windows.Forms.Button btnDangKy;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
