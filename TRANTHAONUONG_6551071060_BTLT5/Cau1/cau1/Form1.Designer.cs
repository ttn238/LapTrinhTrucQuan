namespace cau6
{
    partial class fdki
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblTieuDe = new Label();
            label1 = new Label();
            lblHoTen = new Label();
            lblSDT = new Label();
            lblEmail = new Label();
            lblXacNhanMK = new Label();
            lblMatKhau = new Label();
            txtHoTen = new TextBox();
            txtSDT = new TextBox();
            txtEmail = new TextBox();
            txtMatKhau = new TextBox();
            txtXacNhanMK = new TextBox();
            btnDangKy = new Button();
            btnHuy = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // lblTieuDe
            // 
            lblTieuDe.AutoSize = true;
            lblTieuDe.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTieuDe.Location = new Point(28, 35);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(338, 41);
            lblTieuDe.TabIndex = 0;
            lblTieuDe.Text = "Đăng kí tài khoản mới ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(41, 90);
            label1.Name = "label1";
            label1.Size = new Size(265, 25);
            label1.TabIndex = 1;
            label1.Text = "Vui lòng nhập đầy đủ thông tin:";
            // 
            // lblHoTen
            // 
            lblHoTen.AutoSize = true;
            lblHoTen.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHoTen.Location = new Point(194, 141);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(66, 23);
            lblHoTen.TabIndex = 2;
            lblHoTen.Text = "Họ tên:";
            // 
            // lblSDT
            // 
            lblSDT.AutoSize = true;
            lblSDT.Font = new Font("Segoe UI", 10F);
            lblSDT.Location = new Point(145, 185);
            lblSDT.Name = "lblSDT";
            lblSDT.Size = new Size(115, 23);
            lblSDT.TabIndex = 2;
            lblSDT.Text = "Số điện thoại:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 10F);
            lblEmail.Location = new Point(205, 229);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(55, 23);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "Email:";
            // 
            // lblXacNhanMK
            // 
            lblXacNhanMK.AutoSize = true;
            lblXacNhanMK.Font = new Font("Segoe UI", 10F);
            lblXacNhanMK.Location = new Point(98, 328);
            lblXacNhanMK.Name = "lblXacNhanMK";
            lblXacNhanMK.Size = new Size(162, 23);
            lblXacNhanMK.TabIndex = 2;
            lblXacNhanMK.Text = "Xác nhận mật khẩu:";
            // 
            // lblMatKhau
            // 
            lblMatKhau.AutoSize = true;
            lblMatKhau.Font = new Font("Segoe UI", 10F);
            lblMatKhau.Location = new Point(174, 277);
            lblMatKhau.Name = "lblMatKhau";
            lblMatKhau.Size = new Size(86, 23);
            lblMatKhau.TabIndex = 2;
            lblMatKhau.Text = "Mật khẩu:";
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(280, 140);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(260, 27);
            txtHoTen.TabIndex = 3;
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(280, 181);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(260, 27);
            txtSDT.TabIndex = 4;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(280, 225);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(260, 27);
            txtEmail.TabIndex = 4;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(280, 273);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.PasswordChar = '*';
            txtMatKhau.Size = new Size(260, 27);
            txtMatKhau.TabIndex = 4;
            // 
            // txtXacNhanMK
            // 
            txtXacNhanMK.Location = new Point(280, 324);
            txtXacNhanMK.Name = "txtXacNhanMK";
            txtXacNhanMK.PasswordChar = '*';
            txtXacNhanMK.Size = new Size(260, 27);
            txtXacNhanMK.TabIndex = 4;
            // 
            // btnDangKy
            // 
            btnDangKy.BackColor = Color.RoyalBlue;
            btnDangKy.ForeColor = SystemColors.ButtonHighlight;
            btnDangKy.Location = new Point(174, 411);
            btnDangKy.Name = "btnDangKy";
            btnDangKy.Size = new Size(130, 47);
            btnDangKy.TabIndex = 5;
            btnDangKy.Text = "Đăng Ký";
            btnDangKy.UseVisualStyleBackColor = false;
            btnDangKy.Click += btnDangKy_Click;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(387, 411);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(129, 47);
            btnHuy.TabIndex = 6;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // fdki
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(645, 504);
            Controls.Add(btnHuy);
            Controls.Add(btnDangKy);
            Controls.Add(txtXacNhanMK);
            Controls.Add(txtMatKhau);
            Controls.Add(txtEmail);
            Controls.Add(txtSDT);
            Controls.Add(txtHoTen);
            Controls.Add(lblMatKhau);
            Controls.Add(lblXacNhanMK);
            Controls.Add(lblEmail);
            Controls.Add(lblSDT);
            Controls.Add(lblHoTen);
            Controls.Add(label1);
            Controls.Add(lblTieuDe);
            Name = "fdki";
            Text = "Đăng ký tài khoản";
            Load += fdki_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTieuDe;
        private Label label1;
        private Label lblHoTen;
        private Label lblSDT;
        private Label lblEmail;
        private Label lblXacNhanMK;
        private Label lblMatKhau; 
        private TextBox txtHoTen;
        private TextBox txtSDT;
        private TextBox txtEmail;
        private TextBox txtMatKhau;
        private TextBox txtXacNhanMK; 
        private Button btnDangKy;
        private Button btnHuy; 
        private ErrorProvider errorProvider1;
    }
}
