namespace cau5
{
    partial class FormChonGhe
    {
        private System.ComponentModel.IContainer components = null;

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
            pnlGhe = new Panel();
            lblGheDaChon = new Label();
            btnXacNhan = new Button();
            btnBoQua = new Button();
            SuspendLayout();
            // 
            // pnlGhe
            // 
            pnlGhe.BorderStyle = BorderStyle.FixedSingle;
            pnlGhe.Location = new Point(10, 10);
            pnlGhe.Name = "pnlGhe";
            pnlGhe.Size = new Size(256, 133);
            pnlGhe.TabIndex = 0;
            // 
            // lblGheDaChon
            // 
            lblGheDaChon.AutoSize = true;
            lblGheDaChon.Location = new Point(12, 146);
            lblGheDaChon.Name = "lblGheDaChon";
            lblGheDaChon.Size = new Size(84, 20);
            lblGheDaChon.TabIndex = 1;
            lblGheDaChon.Text = "Đang chọn:";
            // 
            // btnXacNhan
            // 
            btnXacNhan.Location = new Point(65, 176);
            btnXacNhan.Name = "btnXacNhan";
            btnXacNhan.Size = new Size(75, 30);
            btnXacNhan.TabIndex = 2;
            btnXacNhan.Text = "Xác nhận";
            btnXacNhan.UseVisualStyleBackColor = true;
            btnXacNhan.Click += btnXacNhan_Click;
            // 
            // btnBoQua
            // 
            btnBoQua.Location = new Point(145, 176);
            btnBoQua.Name = "btnBoQua";
            btnBoQua.Size = new Size(75, 30);
            btnBoQua.TabIndex = 3;
            btnBoQua.Text = "Bỏ qua";
            btnBoQua.UseVisualStyleBackColor = true;
            btnBoQua.Click += btnBoQua_Click;
            // 
            // FormChonGhe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(278, 218);
            Controls.Add(btnBoQua);
            Controls.Add(btnXacNhan);
            Controls.Add(lblGheDaChon);
            Controls.Add(pnlGhe);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormChonGhe";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Chọn ghế";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlGhe;
        private Label lblGheDaChon;
        private Button btnXacNhan;
        private Button btnBoQua;
    }
}