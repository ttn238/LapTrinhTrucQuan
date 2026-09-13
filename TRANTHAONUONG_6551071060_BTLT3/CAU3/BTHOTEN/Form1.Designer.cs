namespace NGOCTU
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
            lblHo = new Label();
            lblTen = new Label();
            txtHo = new TextBox();
            txtTen = new TextBox();
            btnHo = new Button();
            btnTen = new Button();
            btnHoTen = new Button();
            btnThoat = new Button();
            lblHoTen = new Label();
            SuspendLayout();
            // 
            // lblHo
            // 
            lblHo.AutoSize = true;
            lblHo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHo.ForeColor = SystemColors.ControlText;
            lblHo.Location = new Point(182, 115);
            lblHo.Name = "lblHo";
            lblHo.Size = new Size(76, 28);
            lblHo.TabIndex = 0;
            lblHo.Text = "Họ lót:";
            // 
            // lblTen
            // 
            lblTen.AutoSize = true;
            lblTen.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTen.Location = new Point(202, 173);
            lblTen.Name = "lblTen";
            lblTen.Size = new Size(56, 28);
            lblTen.TabIndex = 1;
            lblTen.Text = "Tên: ";
            // 
            // txtHo
            // 
            txtHo.Location = new Point(309, 115);
            txtHo.Name = "txtHo";
            txtHo.Size = new Size(307, 27);
            txtHo.TabIndex = 2;
            // 
            // txtTen
            // 
            txtTen.BackColor = Color.LightCoral;
            txtTen.Location = new Point(309, 174);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(307, 27);
            txtTen.TabIndex = 3;
            // 
            // btnHo
            // 
            btnHo.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHo.Location = new Point(75, 265);
            btnHo.Name = "btnHo";
            btnHo.Size = new Size(139, 46);
            btnHo.TabIndex = 4;
            btnHo.Text = "Họ Lót";
            btnHo.UseVisualStyleBackColor = true;
            btnHo.Click += btnHo_Click;
            // 
            // btnTen
            // 
            btnTen.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTen.Location = new Point(290, 265);
            btnTen.Name = "btnTen";
            btnTen.Size = new Size(157, 46);
            btnTen.TabIndex = 5;
            btnTen.Text = "Tên";
            btnTen.UseVisualStyleBackColor = true;
            btnTen.Click += btnTen_Click;
            // 
            // btnHoTen
            // 
            btnHoTen.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHoTen.Location = new Point(549, 265);
            btnHoTen.Name = "btnHoTen";
            btnHoTen.Size = new Size(134, 46);
            btnHoTen.TabIndex = 6;
            btnHoTen.Text = "Họ và Tên";
            btnHoTen.UseVisualStyleBackColor = true;
            btnHoTen.Click += btnHoTen_Click;
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThoat.Location = new Point(249, 351);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(248, 56);
            btnThoat.TabIndex = 7;
            btnThoat.Text = "Thoát Chuong Trình";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += button4_Click;
            // 
            // lblHoTen
            // 
            lblHoTen.BackColor = SystemColors.HotTrack;
            lblHoTen.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHoTen.ForeColor = SystemColors.ButtonHighlight;
            lblHoTen.Location = new Point(1, 2);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(759, 87);
            lblHoTen.TabIndex = 8;
            lblHoTen.TextAlign = ContentAlignment.MiddleCenter;
            lblHoTen.Click += lblHoTen_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(761, 434);
            Controls.Add(lblHoTen);
            Controls.Add(btnThoat);
            Controls.Add(btnHoTen);
            Controls.Add(btnTen);
            Controls.Add(btnHo);
            Controls.Add(txtTen);
            Controls.Add(txtHo);
            Controls.Add(lblTen);
            Controls.Add(lblHo);
            Name = "Form1";
            Text = "Bài Tập Họ Tên ";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHo;
        private Label lblTen;
        private TextBox txtHo;
        private TextBox txtTen;
        private Button btnHo;
        private Button btnTen;
        private Button btnHoTen;
        private Button btnThoat;
        private Label lblHoTen;
    }
}
