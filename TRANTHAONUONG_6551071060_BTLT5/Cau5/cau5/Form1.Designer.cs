namespace cau5
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Required method for Designer support.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblTenKhach = new Label();
            lblPhim = new Label();
            lblSuatChieu = new Label();
            lblGhe = new Label();
            txtTenKhach = new TextBox();
            cboPhim = new ComboBox();
            cboSuatChieu = new ComboBox();
            txtGheDaChon = new TextBox();
            btnChonGhe = new Button();
            btnDatVe = new Button();
            btnHuy = new Button();
            SuspendLayout();

            // 
            // lblTenKhach
            // 
            lblTenKhach.AutoSize = true;
            lblTenKhach.Location = new Point(40, 40);
            lblTenKhach.Name = "lblTenKhach";
            lblTenKhach.Size = new Size(76, 20);
            lblTenKhach.TabIndex = 0;
            lblTenKhach.Text = "Tên khách";

            // 
            // lblPhim
            // 
            lblPhim.AutoSize = true;
            lblPhim.Location = new Point(40, 90);
            lblPhim.Name = "lblPhim";
            lblPhim.Size = new Size(40, 20);
            lblPhim.TabIndex = 1;
            lblPhim.Text = "Phim";

            // 
            // lblSuatChieu
            // 
            lblSuatChieu.AutoSize = true;
            lblSuatChieu.Location = new Point(40, 140);
            lblSuatChieu.Name = "lblSuatChieu";
            lblSuatChieu.Size = new Size(78, 20);
            lblSuatChieu.TabIndex = 2;
            lblSuatChieu.Text = "Suất chiếu";

            // 
            // lblGhe
            // 
            lblGhe.AutoSize = true;
            lblGhe.Location = new Point(40, 190);
            lblGhe.Name = "lblGhe";
            lblGhe.Size = new Size(34, 20);
            lblGhe.TabIndex = 3;
            lblGhe.Text = "Ghế";

            // 
            // txtTenKhach
            // 
            txtTenKhach.Location = new Point(150, 37);
            txtTenKhach.Name = "txtTenKhach";
            txtTenKhach.Size = new Size(300, 27);
            txtTenKhach.TabIndex = 0;

            // 
            // cboPhim
            // 
            cboPhim.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPhim.FormattingEnabled = true;
            cboPhim.Location = new Point(150, 87);
            cboPhim.Name = "cboPhim";
            cboPhim.Size = new Size(300, 28);
            cboPhim.TabIndex = 1;

            // 
            // cboSuatChieu
            // 
            cboSuatChieu.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSuatChieu.FormattingEnabled = true;
            cboSuatChieu.Location = new Point(150, 137);
            cboSuatChieu.Name = "cboSuatChieu";
            cboSuatChieu.Size = new Size(300, 28);
            cboSuatChieu.TabIndex = 2;

            // 
            // txtGheDaChon
            // 
            txtGheDaChon.Location = new Point(150, 187);
            txtGheDaChon.Name = "txtGheDaChon";
            txtGheDaChon.ReadOnly = true;
            txtGheDaChon.Size = new Size(180, 27);
            txtGheDaChon.TabIndex = 3;

            // 
            // btnChonGhe
            // 
            btnChonGhe.Location = new Point(345, 185);
            btnChonGhe.Name = "btnChonGhe";
            btnChonGhe.Size = new Size(105, 32);
            btnChonGhe.TabIndex = 4;
            btnChonGhe.Text = "Chọn ghế";
            btnChonGhe.UseVisualStyleBackColor = true;
            btnChonGhe.Click += btnChonGhe_Click;

            // 
            // btnDatVe
            // 
            btnDatVe.Location = new Point(150, 250);
            btnDatVe.Name = "btnDatVe";
            btnDatVe.Size = new Size(110, 40);
            btnDatVe.TabIndex = 5;
            btnDatVe.Text = "Đặt vé";
            btnDatVe.UseVisualStyleBackColor = true;
            btnDatVe.Click += btnDatVe_Click;

            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(290, 250);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(110, 40);
            btnHuy.TabIndex = 6;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;

            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 340);
            Controls.Add(btnHuy);
            Controls.Add(btnDatVe);
            Controls.Add(btnChonGhe);
            Controls.Add(txtGheDaChon);
            Controls.Add(cboSuatChieu);
            Controls.Add(cboPhim);
            Controls.Add(txtTenKhach);
            Controls.Add(lblGhe);
            Controls.Add(lblSuatChieu);
            Controls.Add(lblPhim);
            Controls.Add(lblTenKhach);
            Name = "Form1";
            Text = "Ứng dụng bán vé xem phim";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTenKhach;
        private Label lblPhim;
        private Label lblSuatChieu;
        private Label lblGhe;
        private TextBox txtTenKhach;
        private ComboBox cboPhim;
        private ComboBox cboSuatChieu;
        private TextBox txtGheDaChon;
        private Button btnChonGhe;
        private Button btnDatVe;
        private Button btnHuy;
    }
}