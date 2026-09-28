namespace cau6
{
    partial class FormGhiChu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Required designer variable.
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
            lblTieuDeForm = new Label();
            lblTieuDe = new Label();
            lblNoiDung = new Label();
            lblMucDoUuTien = new Label();
            txtTieuDe = new TextBox();
            txtNoiDung = new TextBox();
            cboMucDoUuTien = new ComboBox();
            btnLuuGhiChu = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // lblTieuDeForm
            // 
            lblTieuDeForm.AutoSize = true;
            lblTieuDeForm.Location = new Point(15, 15);
            lblTieuDeForm.Name = "lblTieuDeForm";
            lblTieuDeForm.Size = new Size(0, 20);
            lblTieuDeForm.TabIndex = 0;
            lblTieuDeForm.MouseDoubleClick += lblTieuDeForm_MouseDoubleClick;
            // 
            // lblTieuDe
            // 
            lblTieuDe.AutoSize = true;
            lblTieuDe.Location = new Point(15, 20);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(58, 20);
            lblTieuDe.TabIndex = 1;
            lblTieuDe.Text = "Tiêu đề";
            // 
            // lblNoiDung
            // 
            lblNoiDung.AutoSize = true;
            lblNoiDung.Location = new Point(15, 82);
            lblNoiDung.Name = "lblNoiDung";
            lblNoiDung.Size = new Size(71, 20);
            lblNoiDung.TabIndex = 3;
            lblNoiDung.Text = "Nội dung";
            // 
            // lblMucDoUuTien
            // 
            lblMucDoUuTien.AutoSize = true;
            lblMucDoUuTien.Location = new Point(12, 214);
            lblMucDoUuTien.Name = "lblMucDoUuTien";
            lblMucDoUuTien.Size = new Size(59, 20);
            lblMucDoUuTien.TabIndex = 5;
            lblMucDoUuTien.Text = "Priority:";
            // 
            // txtTieuDe
            // 
            txtTieuDe.Location = new Point(15, 43);
            txtTieuDe.Name = "txtTieuDe";
            txtTieuDe.Size = new Size(403, 27);
            txtTieuDe.TabIndex = 2;
            txtTieuDe.TextChanged += txtTieuDe_TextChanged;
            txtTieuDe.Validating += txtTieuDe_Validating;
            txtTieuDe.Validated += txtTieuDe_Validated;
            // 
            // txtNoiDung
            // 
            txtNoiDung.Location = new Point(88, 82);
            txtNoiDung.Multiline = true;
            txtNoiDung.Name = "txtNoiDung";
            txtNoiDung.ScrollBars = ScrollBars.Vertical;
            txtNoiDung.Size = new Size(330, 117);
            txtNoiDung.TabIndex = 4;
            txtNoiDung.TextChanged += txtNoiDung_TextChanged;
            txtNoiDung.KeyPress += txtNoiDung_KeyPress;
            // 
            // cboMucDoUuTien
            // 
            cboMucDoUuTien.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMucDoUuTien.FormattingEnabled = true;
            cboMucDoUuTien.Location = new Point(12, 237);
            cboMucDoUuTien.Name = "cboMucDoUuTien";
            cboMucDoUuTien.Size = new Size(156, 28);
            cboMucDoUuTien.TabIndex = 6;
            cboMucDoUuTien.SelectedIndexChanged += cboMucDoUuTien_SelectedIndexChanged;
            // 
            // btnLuuGhiChu
            // 
            btnLuuGhiChu.Location = new Point(315, 237);
            btnLuuGhiChu.Name = "btnLuuGhiChu";
            btnLuuGhiChu.Size = new Size(90, 35);
            btnLuuGhiChu.TabIndex = 7;
            btnLuuGhiChu.Text = "Lưu";
            btnLuuGhiChu.UseVisualStyleBackColor = true;
            btnLuuGhiChu.Click += btnLuuGhiChu_Click;
            btnLuuGhiChu.MouseEnter += btnLuuGhiChu_MouseEnter;
            btnLuuGhiChu.MouseLeave += btnLuuGhiChu_MouseLeave;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // FormGhiChu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(430, 288);
            Controls.Add(btnLuuGhiChu);
            Controls.Add(cboMucDoUuTien);
            Controls.Add(lblMucDoUuTien);
            Controls.Add(txtNoiDung);
            Controls.Add(lblNoiDung);
            Controls.Add(txtTieuDe);
            Controls.Add(lblTieuDe);
            Controls.Add(lblTieuDeForm);
            KeyPreview = true;
            Name = "FormGhiChu";
            Text = "Ghi chú";
            KeyDown += FormGhiChu_KeyDown;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTieuDeForm;
        private Label lblTieuDe;
        private Label lblNoiDung;
        private Label lblMucDoUuTien;

        private TextBox txtTieuDe;
        private TextBox txtNoiDung;

        private ComboBox cboMucDoUuTien;

        private Button btnLuuGhiChu;

        private ErrorProvider errorProvider1;
    }
}