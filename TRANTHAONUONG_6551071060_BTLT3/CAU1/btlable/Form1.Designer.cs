namespace NGOCNGA
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
            fontDialog1 = new FontDialog();
            nhappass = new Label();
            buthienthi = new Button();
            buttiep = new Button();
            butdong = new Button();
            opass = new TextBox();
            ohienthi = new TextBox();
            nhaphienthi = new Label();
            SuspendLayout();
            // 
            // nhappass
            // 
            nhappass.AutoSize = true;
            nhappass.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nhappass.Location = new Point(59, 50);
            nhappass.Name = "nhappass";
            nhappass.Size = new Size(139, 23);
            nhappass.TabIndex = 0;
            nhappass.Text = "Nhập password:";
            nhappass.Click += label1_Click;
            // 
            // buthienthi
            // 
            buthienthi.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buthienthi.Location = new Point(59, 206);
            buthienthi.Name = "buthienthi";
            buthienthi.Size = new Size(98, 39);
            buthienthi.TabIndex = 1;
            buthienthi.Text = "Hiển thị";
            buthienthi.UseVisualStyleBackColor = true;
            buthienthi.Click += buthienthi_Click;
            // 
            // buttiep
            // 
            buttiep.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttiep.Location = new Point(284, 206);
            buttiep.Name = "buttiep";
            buttiep.Size = new Size(98, 39);
            buttiep.TabIndex = 2;
            buttiep.Text = "Tiếp";
            buttiep.UseVisualStyleBackColor = true;
            buttiep.Click += buttiep_Click;
            // 
            // butdong
            // 
            butdong.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            butdong.Location = new Point(517, 206);
            butdong.Name = "butdong";
            butdong.Size = new Size(98, 39);
            butdong.TabIndex = 3;
            butdong.Text = "Đóng";
            butdong.UseVisualStyleBackColor = true;
            butdong.Click += button3_Click;
            // 
            // opass
            // 
            opass.Location = new Point(254, 49);
            opass.Name = "opass";
            opass.PasswordChar = '#';
            opass.Size = new Size(376, 27);
            opass.TabIndex = 4;
            opass.UseSystemPasswordChar = true;
            opass.TextChanged += textBox1_TextChanged;
            // 
            // ohienthi
            // 
            ohienthi.Location = new Point(254, 104);
            ohienthi.Name = "ohienthi";
            ohienthi.Size = new Size(376, 27);
            ohienthi.TabIndex = 5;
            // 
            // nhaphienthi
            // 
            nhaphienthi.AutoSize = true;
            nhaphienthi.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nhaphienthi.Location = new Point(119, 104);
            nhaphienthi.Name = "nhaphienthi";
            nhaphienthi.Size = new Size(79, 23);
            nhaphienthi.TabIndex = 6;
            nhaphienthi.Text = "Hiển thị:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(698, 309);
            Controls.Add(nhaphienthi);
            Controls.Add(ohienthi);
            Controls.Add(opass);
            Controls.Add(butdong);
            Controls.Add(buttiep);
            Controls.Add(buthienthi);
            Controls.Add(nhappass);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontDialog fontDialog1;
        private Label nhappass;
        private Button buthienthi;
        private Button buttiep;
        private Button butdong;
        private TextBox opass;
        private TextBox ohienthi;
        private Label nhaphienthi;
    }
}
