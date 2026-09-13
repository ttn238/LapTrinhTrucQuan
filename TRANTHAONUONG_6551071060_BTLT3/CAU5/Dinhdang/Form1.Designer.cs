namespace Dinhdang
{
    partial class fdinhdang
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
            btnthoat = new Button();
            lblnhapten = new Label();
            txtNhapten = new TextBox();
            groupBox1 = new GroupBox();
            radioblack = new RadioButton();
            radblue = new RadioButton();
            radgreen = new RadioButton();
            radred = new RadioButton();
            groupBox2 = new GroupBox();
            chgach = new CheckBox();
            cbnghieng = new CheckBox();
            cbdam = new CheckBox();
            lbllaptrinhboi = new Label();
            textBox1 = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // btnthoat
            // 
            btnthoat.BackColor = SystemColors.Control;
            btnthoat.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnthoat.Location = new Point(425, 374);
            btnthoat.Name = "btnthoat";
            btnthoat.Size = new Size(115, 49);
            btnthoat.TabIndex = 0;
            btnthoat.Text = "Thoát ";
            btnthoat.UseVisualStyleBackColor = false;
            btnthoat.Click += btnthoat_Click;
            // 
            // lblnhapten
            // 
            lblnhapten.AutoSize = true;
            lblnhapten.BackColor = SystemColors.ActiveCaptionText;
            lblnhapten.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblnhapten.ForeColor = Color.Lime;
            lblnhapten.Location = new Point(81, 27);
            lblnhapten.Name = "lblnhapten";
            lblnhapten.Size = new Size(93, 25);
            lblnhapten.TabIndex = 1;
            lblnhapten.Text = "Nhập Tên";
            // 
            // txtNhapten
            // 
            txtNhapten.Location = new Point(198, 25);
            txtNhapten.Name = "txtNhapten";
            txtNhapten.Size = new Size(313, 27);
            txtNhapten.TabIndex = 2;
            txtNhapten.TextChanged += txtNhapten_TextChanged;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.GradientActiveCaption;
            groupBox1.Controls.Add(radioblack);
            groupBox1.Controls.Add(radblue);
            groupBox1.Controls.Add(radgreen);
            groupBox1.Controls.Add(radred);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = SystemColors.ActiveCaptionText;
            groupBox1.Location = new Point(35, 96);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(228, 258);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Color";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // radioblack
            // 
            radioblack.AutoSize = true;
            radioblack.Location = new Point(34, 207);
            radioblack.Name = "radioblack";
            radioblack.Size = new Size(84, 32);
            radioblack.TabIndex = 3;
            radioblack.TabStop = true;
            radioblack.Text = "Black";
            radioblack.UseVisualStyleBackColor = true;
            radioblack.CheckedChanged += radioblack_CheckedChanged;
            // 
            // radblue
            // 
            radblue.AutoSize = true;
            radblue.ForeColor = Color.Blue;
            radblue.Location = new Point(34, 154);
            radblue.Name = "radblue";
            radblue.Size = new Size(75, 32);
            radblue.TabIndex = 2;
            radblue.TabStop = true;
            radblue.Text = "Blue";
            radblue.UseVisualStyleBackColor = true;
            radblue.CheckedChanged += radblue_CheckedChanged;
            // 
            // radgreen
            // 
            radgreen.AutoSize = true;
            radgreen.ForeColor = Color.Green;
            radgreen.Location = new Point(29, 99);
            radgreen.Name = "radgreen";
            radgreen.Size = new Size(89, 32);
            radgreen.TabIndex = 1;
            radgreen.TabStop = true;
            radgreen.Text = "Green";
            radgreen.UseVisualStyleBackColor = true;
            radgreen.CheckedChanged += radgreen_CheckedChanged;
            // 
            // radred
            // 
            radred.AutoSize = true;
            radred.Checked = true;
            radred.ForeColor = Color.Red;
            radred.Location = new Point(34, 42);
            radred.Name = "radred";
            radred.Size = new Size(69, 32);
            radred.TabIndex = 0;
            radred.TabStop = true;
            radred.Text = "Red";
            radred.UseVisualStyleBackColor = true;
            radred.CheckedChanged += radred_CheckedChanged;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.PapayaWhip;
            groupBox2.Controls.Add(chgach);
            groupBox2.Controls.Add(cbnghieng);
            groupBox2.Controls.Add(cbdam);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = SystemColors.ActiveBorder;
            groupBox2.Location = new Point(310, 96);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(230, 258);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Font";
            // 
            // chgach
            // 
            chgach.AutoSize = true;
            chgach.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            chgach.ForeColor = Color.Blue;
            chgach.Location = new Point(22, 193);
            chgach.Name = "chgach";
            chgach.Size = new Size(132, 32);
            chgach.TabIndex = 2;
            chgach.Text = "Gạch chân";
            chgach.UseVisualStyleBackColor = true;
            chgach.CheckedChanged += chgach_CheckedChanged;
            // 
            // cbnghieng
            // 
            cbnghieng.AutoSize = true;
            cbnghieng.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            cbnghieng.ForeColor = Color.Blue;
            cbnghieng.Location = new Point(22, 118);
            cbnghieng.Name = "cbnghieng";
            cbnghieng.Size = new Size(161, 32);
            cbnghieng.TabIndex = 1;
            cbnghieng.Text = "Nghiêng Italic";
            cbnghieng.UseVisualStyleBackColor = true;
            cbnghieng.CheckedChanged += cbnghieng_CheckedChanged;
            // 
            // cbdam
            // 
            cbdam.AutoSize = true;
            cbdam.ForeColor = Color.Blue;
            cbdam.Location = new Point(22, 43);
            cbdam.Name = "cbdam";
            cbdam.Size = new Size(127, 32);
            cbdam.TabIndex = 0;
            cbdam.Text = "Đậm Bold";
            cbdam.UseVisualStyleBackColor = true;
            cbdam.CheckedChanged += cbdam_CheckedChanged;
            // 
            // lbllaptrinhboi
            // 
            lbllaptrinhboi.AutoSize = true;
            lbllaptrinhboi.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbllaptrinhboi.ForeColor = Color.SaddleBrown;
            lbllaptrinhboi.Location = new Point(35, 392);
            lbllaptrinhboi.Name = "lbllaptrinhboi";
            lbllaptrinhboi.Size = new Size(120, 23);
            lbllaptrinhboi.TabIndex = 7;
            lbllaptrinhboi.Text = "Lập trình bởi:";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.InactiveBorder;
            textBox1.Location = new Point(177, 388);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(202, 27);
            textBox1.TabIndex = 8;
            textBox1.Text = "\r\n\r\n";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // fdinhdang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 456);
            Controls.Add(textBox1);
            Controls.Add(lbllaptrinhboi);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(txtNhapten);
            Controls.Add(lblnhapten);
            Controls.Add(btnthoat);
            Name = "fdinhdang";
            Text = "Định dạng(Formater)";
            Load += fdinhdang_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnthoat;
        private Label lblnhapten;
        private TextBox txtNhapten;
        private GroupBox groupBox1;
        private RadioButton radgreen;
        private RadioButton radred;
        private RadioButton radioblack;
        private RadioButton radblue;
        private GroupBox groupBox2;
        private CheckBox cbdam;
        private CheckBox cbnghieng;
        private CheckBox chgach;
        private Label lbllaptrinhboi;
        private TextBox textBox1;
    }
}
