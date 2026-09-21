namespace Chuong4_Bai4_PhongKhamMDI
{
    partial class frmParent
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuNghiepVu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThongTinBenhNhan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDatLichHen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCuaSo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.mnuNghiepVu, this.mnuCuaSo });
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MdiWindowListItem = this.mnuCuaSo;   // <<< thuộc tính quan trọng của bài
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(884, 24);
            this.menuStrip1.TabIndex = 0;
            // 
            // mnuNghiepVu
            // 
            this.mnuNghiepVu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.mnuThongTinBenhNhan, this.mnuDatLichHen });
            this.mnuNghiepVu.Name = "mnuNghiepVu";
            this.mnuNghiepVu.Size = new System.Drawing.Size(75, 20);
            this.mnuNghiepVu.Text = "Nghiệp vụ";
            // 
            // mnuThongTinBenhNhan
            // 
            this.mnuThongTinBenhNhan.Name = "mnuThongTinBenhNhan";
            this.mnuThongTinBenhNhan.Size = new System.Drawing.Size(190, 22);
            this.mnuThongTinBenhNhan.Text = "Thông tin bệnh nhân";
            this.mnuThongTinBenhNhan.Click += new System.EventHandler(this.mnuThongTinBenhNhan_Click);
            // 
            // mnuDatLichHen
            // 
            this.mnuDatLichHen.Name = "mnuDatLichHen";
            this.mnuDatLichHen.Size = new System.Drawing.Size(190, 22);
            this.mnuDatLichHen.Text = "Đặt lịch hẹn";
            this.mnuDatLichHen.Click += new System.EventHandler(this.mnuDatLichHen_Click);
            // 
            // mnuCuaSo (menu rỗng - hệ thống tự điền danh sách form con)
            // 
            this.mnuCuaSo.Name = "mnuCuaSo";
            this.mnuCuaSo.Size = new System.Drawing.Size(58, 20);
            this.mnuCuaSo.Text = "Cửa sổ";
            // 
            // frmParent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmParent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm quản lý phòng khám mini";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuNghiepVu;
        private System.Windows.Forms.ToolStripMenuItem mnuThongTinBenhNhan;
        private System.Windows.Forms.ToolStripMenuItem mnuDatLichHen;
        private System.Windows.Forms.ToolStripMenuItem mnuCuaSo;
    }
}
