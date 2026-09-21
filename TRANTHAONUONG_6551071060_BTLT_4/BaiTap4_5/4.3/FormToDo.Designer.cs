namespace Chuong4_Bai3_ToDoList
{
    partial class FormToDo
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlTren = new System.Windows.Forms.Panel();
            this.txtCongViecMoi = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.lstCongViec = new System.Windows.Forms.ListBox();
            this.cmsCongViec = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuHoanThanh = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuXoaMot = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuXoaTatCa = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlTren.SuspendLayout();
            this.cmsCongViec.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTren
            // 
            this.pnlTren.Controls.Add(this.btnThem);
            this.pnlTren.Controls.Add(this.txtCongViecMoi);
            this.pnlTren.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTren.Location = new System.Drawing.Point(0, 0);
            this.pnlTren.Name = "pnlTren";
            this.pnlTren.Padding = new System.Windows.Forms.Padding(10);
            this.pnlTren.Size = new System.Drawing.Size(484, 55);
            this.pnlTren.TabIndex = 0;
            // 
            // txtCongViecMoi
            // 
            this.txtCongViecMoi.Location = new System.Drawing.Point(12, 15);
            this.txtCongViecMoi.Name = "txtCongViecMoi";
            this.txtCongViecMoi.PlaceholderText = "Nhập công việc cần làm...";
            this.txtCongViecMoi.Size = new System.Drawing.Size(340, 23);
            this.txtCongViecMoi.TabIndex = 0;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(365, 14);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 26);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // lstCongViec
            // 
            this.lstCongViec.ContextMenuStrip = this.cmsCongViec;
            this.lstCongViec.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstCongViec.FormattingEnabled = true;
            this.lstCongViec.ItemHeight = 15;
            this.lstCongViec.Location = new System.Drawing.Point(0, 55);
            this.lstCongViec.Name = "lstCongViec";
            this.lstCongViec.Size = new System.Drawing.Size(484, 306);
            this.lstCongViec.TabIndex = 1;
            this.lstCongViec.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lstCongViec_MouseDown);
            // 
            // cmsCongViec
            // 
            this.cmsCongViec.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.mnuHoanThanh, this.mnuXoaMot, this.mnuXoaTatCa });
            this.cmsCongViec.Name = "cmsCongViec";
            this.cmsCongViec.Size = new System.Drawing.Size(200, 70);
            // 
            // mnuHoanThanh
            // 
            this.mnuHoanThanh.Name = "mnuHoanThanh";
            this.mnuHoanThanh.Size = new System.Drawing.Size(200, 22);
            this.mnuHoanThanh.Text = "Đánh dấu hoàn thành";
            this.mnuHoanThanh.Click += new System.EventHandler(this.mnuHoanThanh_Click);
            // 
            // mnuXoaMot
            // 
            this.mnuXoaMot.Name = "mnuXoaMot";
            this.mnuXoaMot.Size = new System.Drawing.Size(200, 22);
            this.mnuXoaMot.Text = "Xóa công việc này";
            this.mnuXoaMot.Click += new System.EventHandler(this.mnuXoaMot_Click);
            // 
            // mnuXoaTatCa
            // 
            this.mnuXoaTatCa.Name = "mnuXoaTatCa";
            this.mnuXoaTatCa.Size = new System.Drawing.Size(200, 22);
            this.mnuXoaTatCa.Text = "Xóa tất cả";
            this.mnuXoaTatCa.Click += new System.EventHandler(this.mnuXoaTatCa_Click);
            // 
            // FormToDo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.lstCongViec);
            this.Controls.Add(this.pnlTren);
            this.Name = "FormToDo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách việc cần làm hằng ngày";
            this.pnlTren.ResumeLayout(false);
            this.pnlTren.PerformLayout();
            this.cmsCongViec.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel pnlTren;
        private System.Windows.Forms.TextBox txtCongViecMoi;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ListBox lstCongViec;
        private System.Windows.Forms.ContextMenuStrip cmsCongViec;
        private System.Windows.Forms.ToolStripMenuItem mnuHoanThanh;
        private System.Windows.Forms.ToolStripMenuItem mnuXoaMot;
        private System.Windows.Forms.ToolStripMenuItem mnuXoaTatCa;
    }
}
