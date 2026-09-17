namespace Cau14
{
    partial class Formcapnhat
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
            label1 = new Label();
            txtTen = new TextBox();
            btnCapNhat = new Button();
            btnChuyen = new Button();
            btnTraLai = new Button();
            btnChuyenTatCa = new Button();
            btnTraLaiTatCa = new Button();
            btnXoaLopA = new Button();
            btnkt = new Button();
            btnXoaLopB = new Button();
            menuStrip1 = new MenuStrip();
            cậpNhậtToolStripMenuItem = new ToolStripMenuItem();
            cậpNhậtLớpAToolStripMenuItem = new ToolStripMenuItem();
            cấpNhậtLớpBToolStripMenuItem = new ToolStripMenuItem();
            chuyểnPhầnTửChọnSangLớpAToolStripMenuItem = new ToolStripMenuItem();
            chuyểnPhầnTửChọnSangLơpsBToolStripMenuItem = new ToolStripMenuItem();
            chuyểnHếtDsSangLớpAToolStripMenuItem = new ToolStripMenuItem();
            chuyểnHếtDsSangLớpBToolStripMenuItem = new ToolStripMenuItem();
            xóaDanhSáchLớpAToolStripMenuItem = new ToolStripMenuItem();
            xóaDanhSáchLớpBToolStripMenuItem = new ToolStripMenuItem();
            hệThốngToolStripMenuItem = new ToolStripMenuItem();
            thôngTinToolStripMenuItem = new ToolStripMenuItem();
            kếtThúcToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            tssngay = new ToolStripStatusLabel();
            tssgio = new ToolStripStatusLabel();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            lstLopA = new ListBox();
            lstLopB = new ListBox();
            timer1 = new System.Windows.Forms.Timer(components);
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(49, 56);
            label1.Name = "label1";
            label1.Size = new Size(74, 25);
            label1.TabIndex = 0;
            label1.Text = "Tên SV:";
            // 
            // txtTen
            // 
            txtTen.Location = new Point(182, 56);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(282, 27);
            txtTen.TabIndex = 1;
            // 
            // btnCapNhat
            // 
            btnCapNhat.BackColor = SystemColors.ButtonFace;
            btnCapNhat.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCapNhat.ForeColor = SystemColors.ControlText;
            btnCapNhat.Location = new Point(492, 45);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(123, 44);
            btnCapNhat.TabIndex = 2;
            btnCapNhat.Text = "Cập Nhật ";
            btnCapNhat.UseVisualStyleBackColor = false;
            btnCapNhat.Click += btnCapNhat_Click;
            // 
            // btnChuyen
            // 
            btnChuyen.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnChuyen.Location = new Point(295, 111);
            btnChuyen.Name = "btnChuyen";
            btnChuyen.Size = new Size(72, 56);
            btnChuyen.TabIndex = 4;
            btnChuyen.Text = ">";
            btnChuyen.UseVisualStyleBackColor = true;
            btnChuyen.Click += btnChuyen_Click;
            // 
            // btnTraLai
            // 
            btnTraLai.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTraLai.Location = new Point(295, 182);
            btnTraLai.Name = "btnTraLai";
            btnTraLai.Size = new Size(72, 56);
            btnTraLai.TabIndex = 6;
            btnTraLai.Text = "<";
            btnTraLai.UseVisualStyleBackColor = true;
            btnTraLai.Click += btnTraLai_Click;
            // 
            // btnChuyenTatCa
            // 
            btnChuyenTatCa.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnChuyenTatCa.Location = new Point(295, 253);
            btnChuyenTatCa.Name = "btnChuyenTatCa";
            btnChuyenTatCa.Size = new Size(72, 56);
            btnChuyenTatCa.TabIndex = 5;
            btnChuyenTatCa.Text = ">>";
            btnChuyenTatCa.UseVisualStyleBackColor = true;
            btnChuyenTatCa.Click += btnChuyenTatCa_Click;
            // 
            // btnTraLaiTatCa
            // 
            btnTraLaiTatCa.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTraLaiTatCa.Location = new Point(295, 325);
            btnTraLaiTatCa.Name = "btnTraLaiTatCa";
            btnTraLaiTatCa.Size = new Size(71, 56);
            btnTraLaiTatCa.TabIndex = 7;
            btnTraLaiTatCa.Text = "<<";
            btnTraLaiTatCa.UseVisualStyleBackColor = true;
            btnTraLaiTatCa.Click += btnTraLaiTatCa_Click;
            // 
            // btnXoaLopA
            // 
            btnXoaLopA.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXoaLopA.Location = new Point(49, 400);
            btnXoaLopA.Name = "btnXoaLopA";
            btnXoaLopA.Size = new Size(162, 49);
            btnXoaLopA.TabIndex = 9;
            btnXoaLopA.Text = "Xóa Lớp A ";
            btnXoaLopA.UseVisualStyleBackColor = true;
            btnXoaLopA.Click += btnXoaLopA_Click;
            // 
            // btnkt
            // 
            btnkt.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnkt.Location = new Point(262, 400);
            btnkt.Name = "btnkt";
            btnkt.Size = new Size(142, 49);
            btnkt.TabIndex = 10;
            btnkt.Text = "Kết Thúc";
            btnkt.UseVisualStyleBackColor = true;
            btnkt.Click += btnkt_Click;
            // 
            // btnXoaLopB
            // 
            btnXoaLopB.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXoaLopB.Location = new Point(453, 400);
            btnXoaLopB.Name = "btnXoaLopB";
            btnXoaLopB.Size = new Size(162, 49);
            btnXoaLopB.TabIndex = 11;
            btnXoaLopB.Text = "Xóa Lớp B";
            btnXoaLopB.UseVisualStyleBackColor = true;
            btnXoaLopB.Click += btnXoaLopB_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Aqua;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { cậpNhậtToolStripMenuItem, hệThốngToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(678, 33);
            menuStrip1.TabIndex = 14;
            menuStrip1.Text = "menuStrip1";
            // 
            // cậpNhậtToolStripMenuItem
            // 
            cậpNhậtToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cậpNhậtLớpAToolStripMenuItem, cấpNhậtLớpBToolStripMenuItem, chuyểnPhầnTửChọnSangLớpAToolStripMenuItem, chuyểnPhầnTửChọnSangLơpsBToolStripMenuItem, chuyểnHếtDsSangLớpAToolStripMenuItem, chuyểnHếtDsSangLớpBToolStripMenuItem, xóaDanhSáchLớpAToolStripMenuItem, xóaDanhSáchLớpBToolStripMenuItem });
            cậpNhậtToolStripMenuItem.Font = new Font("Segoe UI", 11F);
            cậpNhậtToolStripMenuItem.Name = "cậpNhậtToolStripMenuItem";
            cậpNhậtToolStripMenuItem.Size = new Size(102, 29);
            cậpNhậtToolStripMenuItem.Text = "Cập nhật";
            cậpNhậtToolStripMenuItem.Click += cậpNhậtToolStripMenuItem_Click;
            // 
            // cậpNhậtLớpAToolStripMenuItem
            // 
            cậpNhậtLớpAToolStripMenuItem.Name = "cậpNhậtLớpAToolStripMenuItem";
            cậpNhậtLớpAToolStripMenuItem.Size = new Size(380, 30);
            cậpNhậtLớpAToolStripMenuItem.Text = "Cập Nhật Lớp  A";
            cậpNhậtLớpAToolStripMenuItem.Click += cậpNhậtLớpAToolStripMenuItem_Click;
            // 
            // cấpNhậtLớpBToolStripMenuItem
            // 
            cấpNhậtLớpBToolStripMenuItem.Name = "cấpNhậtLớpBToolStripMenuItem";
            cấpNhậtLớpBToolStripMenuItem.Size = new Size(380, 30);
            cấpNhậtLớpBToolStripMenuItem.Text = "Cấp Nhật Lớp B";
            cấpNhậtLớpBToolStripMenuItem.Click += cấpNhậtLớpBToolStripMenuItem_Click;
            // 
            // chuyểnPhầnTửChọnSangLớpAToolStripMenuItem
            // 
            chuyểnPhầnTửChọnSangLớpAToolStripMenuItem.Name = "chuyểnPhầnTửChọnSangLớpAToolStripMenuItem";
            chuyểnPhầnTửChọnSangLớpAToolStripMenuItem.Size = new Size(380, 30);
            chuyểnPhầnTửChọnSangLớpAToolStripMenuItem.Text = "Chuyển phần tử chọn sang lớp A";
            chuyểnPhầnTửChọnSangLớpAToolStripMenuItem.Click += chuyểnPhầnTửChọnSangLớpAToolStripMenuItem_Click_1;
            // 
            // chuyểnPhầnTửChọnSangLơpsBToolStripMenuItem
            // 
            chuyểnPhầnTửChọnSangLơpsBToolStripMenuItem.Name = "chuyểnPhầnTửChọnSangLơpsBToolStripMenuItem";
            chuyểnPhầnTửChọnSangLơpsBToolStripMenuItem.Size = new Size(380, 30);
            chuyểnPhầnTửChọnSangLơpsBToolStripMenuItem.Text = "Chuyển phần tử chọn sang lơps B";
            chuyểnPhầnTửChọnSangLơpsBToolStripMenuItem.Click += chuyểnPhầnTửChọnSangLơpsBToolStripMenuItem_Click;
            // 
            // chuyểnHếtDsSangLớpAToolStripMenuItem
            // 
            chuyểnHếtDsSangLớpAToolStripMenuItem.Name = "chuyểnHếtDsSangLớpAToolStripMenuItem";
            chuyểnHếtDsSangLớpAToolStripMenuItem.Size = new Size(380, 30);
            chuyểnHếtDsSangLớpAToolStripMenuItem.Text = "Chuyển hết ds sang lớp A";
            chuyểnHếtDsSangLớpAToolStripMenuItem.Click += chuyểnHếtDsSangLớpAToolStripMenuItem_Click_1;
            // 
            // chuyểnHếtDsSangLớpBToolStripMenuItem
            // 
            chuyểnHếtDsSangLớpBToolStripMenuItem.Name = "chuyểnHếtDsSangLớpBToolStripMenuItem";
            chuyểnHếtDsSangLớpBToolStripMenuItem.Size = new Size(380, 30);
            chuyểnHếtDsSangLớpBToolStripMenuItem.Text = "Chuyển hết ds sang lớp B";
            chuyểnHếtDsSangLớpBToolStripMenuItem.Click += chuyểnHếtDsSangLớpBToolStripMenuItem_Click_1;
            // 
            // xóaDanhSáchLớpAToolStripMenuItem
            // 
            xóaDanhSáchLớpAToolStripMenuItem.Name = "xóaDanhSáchLớpAToolStripMenuItem";
            xóaDanhSáchLớpAToolStripMenuItem.Size = new Size(380, 30);
            xóaDanhSáchLớpAToolStripMenuItem.Text = "Xóa Danh Sách Lớp A";
            xóaDanhSáchLớpAToolStripMenuItem.Click += xóaDanhSáchLớpAToolStripMenuItem_Click_1;
            // 
            // xóaDanhSáchLớpBToolStripMenuItem
            // 
            xóaDanhSáchLớpBToolStripMenuItem.Name = "xóaDanhSáchLớpBToolStripMenuItem";
            xóaDanhSáchLớpBToolStripMenuItem.Size = new Size(380, 30);
            xóaDanhSáchLớpBToolStripMenuItem.Text = "Xóa Danh Sách Lớp B";
            xóaDanhSáchLớpBToolStripMenuItem.Click += xóaDanhSáchLớpBToolStripMenuItem_Click_1;
            // 
            // hệThốngToolStripMenuItem
            // 
            hệThốngToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { thôngTinToolStripMenuItem, kếtThúcToolStripMenuItem });
            hệThốngToolStripMenuItem.Font = new Font("Segoe UI", 11F);
            hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            hệThốngToolStripMenuItem.Size = new Size(109, 29);
            hệThốngToolStripMenuItem.Text = "Hệ thống ";
            hệThốngToolStripMenuItem.Click += hệThốngToolStripMenuItem_Click;
            // 
            // thôngTinToolStripMenuItem
            // 
            thôngTinToolStripMenuItem.Name = "thôngTinToolStripMenuItem";
            thôngTinToolStripMenuItem.Size = new Size(183, 30);
            thôngTinToolStripMenuItem.Text = "Thông Tin";
            thôngTinToolStripMenuItem.Click += thôngTinToolStripMenuItem_Click_1;
            // 
            // kếtThúcToolStripMenuItem
            // 
            kếtThúcToolStripMenuItem.Name = "kếtThúcToolStripMenuItem";
            kếtThúcToolStripMenuItem.Size = new Size(183, 30);
            kếtThúcToolStripMenuItem.Text = "Kết Thúc";
            kếtThúcToolStripMenuItem.Click += kếtThúcToolStripMenuItem_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.BackColor = Color.MediumTurquoise;
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { tssngay, tssgio, toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 484);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(678, 26);
            statusStrip1.TabIndex = 15;
            statusStrip1.Text = "statusStrip1";
            // 
            // tssngay
            // 
            tssngay.Name = "tssngay";
            tssngay.Size = new Size(85, 20);
            tssngay.Text = "11/30/2011";
            // 
            // tssgio
            // 
            tssgio.Name = "tssgio";
            tssgio.Size = new Size(90, 20);
            tssgio.Text = "10:51:56 AM";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(137, 20);
            toolStripStatusLabel1.Text = "Designed by Xavier";
            // 
            // lstLopA
            // 
            lstLopA.FormattingEnabled = true;
            lstLopA.Location = new Point(49, 111);
            lstLopA.Name = "lstLopA";
            lstLopA.SelectionMode = SelectionMode.MultiExtended;
            lstLopA.Size = new Size(205, 264);
            lstLopA.TabIndex = 16;
            // 
            // lstLopB
            // 
            lstLopB.FormattingEnabled = true;
            lstLopB.Location = new Point(417, 111);
            lstLopB.Name = "lstLopB";
            lstLopB.SelectionMode = SelectionMode.MultiExtended;
            lstLopB.Size = new Size(209, 264);
            lstLopB.TabIndex = 17;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // Formcapnhat
            // 
            AcceptButton = btnCapNhat;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(678, 510);
            Controls.Add(lstLopB);
            Controls.Add(lstLopA);
            Controls.Add(statusStrip1);
            Controls.Add(btnXoaLopB);
            Controls.Add(btnkt);
            Controls.Add(btnXoaLopA);
            Controls.Add(btnTraLaiTatCa);
            Controls.Add(btnChuyenTatCa);
            Controls.Add(btnTraLai);
            Controls.Add(btnChuyen);
            Controls.Add(btnCapNhat);
            Controls.Add(txtTen);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            MinimizeBox = false;
            Name = "Formcapnhat";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form cập nhật 2 ListBox";
            FormClosing += Formcapnhat_FormClosing;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtTen;
        private Button btnCapNhat;
        private Button btnChuyen;
        private Button btnTraLai;
        private Button btnChuyenTatCa;
        private Button btnTraLaiTatCa;
        private Button btnXoaLopA;
        private Button btnkt;
        private Button btnXoaLopB;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem cậpNhậtToolStripMenuItem;
        private ToolStripMenuItem hệThốngToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel tssngay;
        private ToolStripStatusLabel tssgio;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ListBox lstLopA;
        private ListBox lstLopB;
        private ToolStripMenuItem cậpNhậtLớpAToolStripMenuItem;
        private ToolStripMenuItem cấpNhậtLớpBToolStripMenuItem;
        private ToolStripMenuItem chuyểnPhầnTửChọnSangLớpAToolStripMenuItem;
        private ToolStripMenuItem chuyểnPhầnTửChọnSangLơpsBToolStripMenuItem;
        private ToolStripMenuItem chuyểnHếtDsSangLớpAToolStripMenuItem;
        private ToolStripMenuItem chuyểnHếtDsSangLớpBToolStripMenuItem;
        private ToolStripMenuItem xóaDanhSáchLớpAToolStripMenuItem;
        private ToolStripMenuItem xóaDanhSáchLớpBToolStripMenuItem;
        private ToolStripMenuItem thôngTinToolStripMenuItem;
        private ToolStripMenuItem kếtThúcToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
    }
}
