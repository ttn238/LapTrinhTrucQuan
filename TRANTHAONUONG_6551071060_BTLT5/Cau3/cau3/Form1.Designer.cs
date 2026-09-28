namespace cau3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
            components = new System.ComponentModel.Container();
            lblMaHS = new Label();
            lblHoTen = new Label();
            lblToan = new Label();
            lblVan = new Label();
            lblAnh = new Label();
            txtMaHS = new TextBox();
            txtHoTen = new TextBox();
            txtToan = new TextBox();
            txtVan = new TextBox();
            txtAnh = new TextBox();
            btnLuu = new Button();
            btnXoaTrang = new Button();
            lstDanhSach = new ListBox();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // lblMaHS
            // 
            lblMaHS.AutoSize = true;
            lblMaHS.Font = new Font("Segoe UI", 10F);
            lblMaHS.Location = new Point(23, 42);
            lblMaHS.Name = "lblMaHS";
            lblMaHS.Size = new Size(103, 23);
            lblMaHS.TabIndex = 0;
            lblMaHS.Text = "Mã học sinh";
            // 
            // lblHoTen
            // 
            lblHoTen.AutoSize = true;
            lblHoTen.Font = new Font("Segoe UI", 10F);
            lblHoTen.Location = new Point(222, 42);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(62, 23);
            lblHoTen.TabIndex = 0;
            lblHoTen.Text = "Họ tên";
            // 
            // lblToan
            // 
            lblToan.AutoSize = true;
            lblToan.Font = new Font("Segoe UI", 10F);
            lblToan.Location = new Point(422, 42);
            lblToan.Name = "lblToan";
            lblToan.Size = new Size(46, 23);
            lblToan.TabIndex = 0;
            lblToan.Text = "Toán";
            // 
            // lblVan
            // 
            lblVan.AutoSize = true;
            lblVan.Font = new Font("Segoe UI", 10F);
            lblVan.Location = new Point(534, 42);
            lblVan.Name = "lblVan";
            lblVan.Size = new Size(39, 23);
            lblVan.TabIndex = 0;
            lblVan.Text = "Văn";
            // 
            // lblAnh
            // 
            lblAnh.AutoSize = true;
            lblAnh.Font = new Font("Segoe UI", 10F);
            lblAnh.Location = new Point(651, 42);
            lblAnh.Name = "lblAnh";
            lblAnh.Size = new Size(41, 23);
            lblAnh.TabIndex = 0;
            lblAnh.Text = "Anh";
            // 
            // txtMaHS
            // 
            txtMaHS.Location = new Point(12, 77);
            txtMaHS.Name = "txtMaHS";
            txtMaHS.Size = new Size(120, 27);
            txtMaHS.TabIndex = 0;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(168, 77);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(176, 27);
            txtHoTen.TabIndex = 1;
            // 
            // txtToan
            // 
            txtToan.Location = new Point(408, 77);
            txtToan.Name = "txtToan";
            txtToan.Size = new Size(76, 27);
            txtToan.TabIndex = 2;
            txtToan.Enter += txtToan_Enter;
            // 
            // txtVan
            // 
            txtVan.Location = new Point(519, 77);
            txtVan.Name = "txtVan";
            txtVan.Size = new Size(76, 27);
            txtVan.TabIndex = 3;
            txtVan.Enter += txtVan_Enter;
            // 
            // txtAnh
            // 
            txtAnh.Location = new Point(634, 77);
            txtAnh.Name = "txtAnh";
            txtAnh.Size = new Size(76, 27);
            txtAnh.TabIndex = 4;
            txtAnh.Enter += txtAnh_Enter;
            // 
            // btnLuu
            // 
            btnLuu.BackColor = Color.ForestGreen;
            btnLuu.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLuu.Location = new Point(12, 127);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(120, 35);
            btnLuu.TabIndex = 5;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnXoaTrang
            // 
            btnXoaTrang.BackColor = SystemColors.ActiveBorder;
            btnXoaTrang.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXoaTrang.Location = new Point(161, 127);
            btnXoaTrang.Name = "btnXoaTrang";
            btnXoaTrang.Size = new Size(123, 35);
            btnXoaTrang.TabIndex = 6;
            btnXoaTrang.Text = "Xóa trắng";
            btnXoaTrang.UseVisualStyleBackColor = false;
            btnXoaTrang.Click += btnXoaTrang_Click;
            // 
            // lstDanhSach
            // 
            lstDanhSach.FormattingEnabled = true;
            lstDanhSach.Location = new Point(12, 180);
            lstDanhSach.Name = "lstDanhSach";
            lstDanhSach.Size = new Size(707, 264);
            lstDanhSach.TabIndex = 7;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(731, 465);
            Controls.Add(lstDanhSach);
            Controls.Add(btnXoaTrang);
            Controls.Add(btnLuu);
            Controls.Add(txtAnh);
            Controls.Add(txtVan);
            Controls.Add(txtToan);
            Controls.Add(txtHoTen);
            Controls.Add(txtMaHS);
            Controls.Add(lblAnh);
            Controls.Add(lblVan);
            Controls.Add(lblToan);
            Controls.Add(lblHoTen);
            Controls.Add(lblMaHS);
            Name = "Form1";
            Text = "Form nhập điểm học sinh";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMaHS;
        private Label lblHoTen;
        private Label lblToan;
        private Label lblVan;
        private Label lblAnh;
        private TextBox txtMaHS;
        private TextBox txtHoTen;
        private TextBox txtToan;
        private TextBox txtVan;
        private TextBox txtAnh;
        private Button btnLuu;
        private Button btnXoaTrang;
        private ListBox lstDanhSach;
        private ErrorProvider errorProvider1;
    }
}
