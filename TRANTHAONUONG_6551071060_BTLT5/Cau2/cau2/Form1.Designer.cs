namespace cau2
{
    partial class FormDatPhong
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
            lblhoten = new Label();
            txtHoTen = new TextBox();
            lblCCCD = new Label();
            txtCCCD = new TextBox();
            lblngaynhanphong = new Label();
            lbltraphong = new Label();
            lblnguoilon = new Label();
            lbltreem = new Label();
            txtNgayNhan = new TextBox();
            txtNgayTra = new TextBox();
            txtSoNguoiLon = new TextBox();
            txtSoTreEm = new TextBox();
            btnDatPhong = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // lblhoten
            // 
            lblhoten.AutoSize = true;
            lblhoten.Font = new Font("Segoe UI", 10F);
            lblhoten.Location = new Point(203, 17);
            lblhoten.Name = "lblhoten";
            lblhoten.Size = new Size(62, 23);
            lblhoten.TabIndex = 0;
            lblhoten.Text = "Họ tên";
            // 
            // txtHoTen
            // 
            txtHoTen.BackColor = Color.White;
            txtHoTen.Location = new Point(203, 43);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(285, 27);
            txtHoTen.TabIndex = 1;
            // 
            // lblCCCD
            // 
            lblCCCD.AutoSize = true;
            lblCCCD.Font = new Font("Segoe UI", 10F);
            lblCCCD.Location = new Point(203, 89);
            lblCCCD.Name = "lblCCCD";
            lblCCCD.Size = new Size(79, 23);
            lblCCCD.TabIndex = 0;
            lblCCCD.Text = "Số CCCD";
            // 
            // txtCCCD
            // 
            txtCCCD.BackColor = Color.White;
            txtCCCD.Location = new Point(203, 115);
            txtCCCD.Name = "txtCCCD";
            txtCCCD.Size = new Size(285, 27);
            txtCCCD.TabIndex = 1;
            // 
            // lblngaynhanphong
            // 
            lblngaynhanphong.AutoSize = true;
            lblngaynhanphong.Font = new Font("Segoe UI", 10F);
            lblngaynhanphong.Location = new Point(203, 163);
            lblngaynhanphong.Name = "lblngaynhanphong";
            lblngaynhanphong.Size = new Size(149, 23);
            lblngaynhanphong.TabIndex = 0;
            lblngaynhanphong.Text = "Ngày nhận phòng";
            // 
            // lbltraphong
            // 
            lbltraphong.AutoSize = true;
            lbltraphong.Font = new Font("Segoe UI", 10F);
            lbltraphong.Location = new Point(203, 238);
            lbltraphong.Name = "lbltraphong";
            lbltraphong.Size = new Size(131, 23);
            lbltraphong.TabIndex = 0;
            lbltraphong.Text = "Ngày trả phòng";
            // 
            // lblnguoilon
            // 
            lblnguoilon.AutoSize = true;
            lblnguoilon.Font = new Font("Segoe UI", 10F);
            lblnguoilon.Location = new Point(203, 310);
            lblnguoilon.Name = "lblnguoilon";
            lblnguoilon.Size = new Size(107, 23);
            lblnguoilon.TabIndex = 0;
            lblnguoilon.Text = "Số người lớn";
            // 
            // lbltreem
            // 
            lbltreem.AutoSize = true;
            lbltreem.Font = new Font("Segoe UI", 10F);
            lbltreem.Location = new Point(203, 385);
            lbltreem.Name = "lbltreem";
            lbltreem.Size = new Size(84, 23);
            lbltreem.TabIndex = 0;
            lbltreem.Text = "Số trẻ em";
            // 
            // txtNgayNhan
            // 
            txtNgayNhan.BackColor = Color.White;
            txtNgayNhan.Location = new Point(203, 189);
            txtNgayNhan.Name = "txtNgayNhan";
            txtNgayNhan.Size = new Size(285, 27);
            txtNgayNhan.TabIndex = 1;
            // 
            // txtNgayTra
            // 
            txtNgayTra.BackColor = Color.White;
            txtNgayTra.Location = new Point(203, 264);
            txtNgayTra.Name = "txtNgayTra";
            txtNgayTra.Size = new Size(285, 27);
            txtNgayTra.TabIndex = 1;
            // 
            // txtSoNguoiLon
            // 
            txtSoNguoiLon.BackColor = Color.White;
            txtSoNguoiLon.Location = new Point(203, 336);
            txtSoNguoiLon.Name = "txtSoNguoiLon";
            txtSoNguoiLon.Size = new Size(285, 27);
            txtSoNguoiLon.TabIndex = 1;
            // 
            // txtSoTreEm
            // 
            txtSoTreEm.BackColor = Color.White;
            txtSoTreEm.Location = new Point(203, 411);
            txtSoTreEm.Name = "txtSoTreEm";
            txtSoTreEm.Size = new Size(285, 27);
            txtSoTreEm.TabIndex = 1;
            // 
            // btnDatPhong
            // 
            btnDatPhong.BackColor = Color.SteelBlue;
            btnDatPhong.CausesValidation = false;
            btnDatPhong.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDatPhong.ForeColor = SystemColors.ButtonHighlight;
            btnDatPhong.Location = new Point(203, 463);
            btnDatPhong.Name = "btnDatPhong";
            btnDatPhong.Size = new Size(285, 55);
            btnDatPhong.TabIndex = 2;
            btnDatPhong.Text = "Đặt phòng";
            btnDatPhong.UseVisualStyleBackColor = false;
            btnDatPhong.Click += btnDatPhong_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // FormDatPhong
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Honeydew;
            ClientSize = new Size(728, 533);
            Controls.Add(btnDatPhong);
            Controls.Add(txtSoTreEm);
            Controls.Add(txtSoNguoiLon);
            Controls.Add(txtNgayTra);
            Controls.Add(txtNgayNhan);
            Controls.Add(txtCCCD);
            Controls.Add(txtHoTen);
            Controls.Add(lbltreem);
            Controls.Add(lblnguoilon);
            Controls.Add(lbltraphong);
            Controls.Add(lblngaynhanphong);
            Controls.Add(lblCCCD);
            Controls.Add(lblhoten);
            Name = "FormDatPhong";
            Text = "Đặt phòng khách sạn";
            Load += FormDatPhong_Load_1;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblhoten;
        private TextBox txtHoTen;
        private Label lblCCCD;
        private TextBox txtCCCD;
        private Label lblngaynhanphong;
        private Label lbltraphong;
        private Label lblnguoilon;
        private Label lbltreem;
        private TextBox txtNgayNhan;
        private TextBox txtNgayTra;
        private TextBox txtSoNguoiLon;
        private TextBox txtSoTreEm;
        private Button btnDatPhong;
        private ErrorProvider errorProvider1;
    }
}