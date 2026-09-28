namespace cau6
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Required method for Designer support.
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
            menuStrip1 = new MenuStrip();
            tệpToolStripMenuItem = new ToolStripMenuItem();
            moGhiChuMoiToolStripMenuItem = new ToolStripMenuItem();
            sapXepCuaSoToolStripMenuItem = new ToolStripMenuItem();
            thoatToolStripMenuItem = new ToolStripMenuItem();
            cửaSổToolStripMenuItem = new ToolStripMenuItem();
            xepTangToolStripMenuItem = new ToolStripMenuItem();
            xepNgangToolStripMenuItem = new ToolStripMenuItem();
            xepDocToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();

            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] {
                tệpToolStripMenuItem,
                cửaSổToolStripMenuItem
            });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(900, 28);
            menuStrip1.TabIndex = 0;

            // 
            // tệpToolStripMenuItem
            // 
            tệpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] {
                moGhiChuMoiToolStripMenuItem,
                sapXepCuaSoToolStripMenuItem,
                thoatToolStripMenuItem
            });
            tệpToolStripMenuItem.Name = "tệpToolStripMenuItem";
            tệpToolStripMenuItem.Size = new Size(47, 24);
            tệpToolStripMenuItem.Text = "Tệp";

            // 
            // moGhiChuMoiToolStripMenuItem
            // 
            moGhiChuMoiToolStripMenuItem.Name = "moGhiChuMoiToolStripMenuItem";
            moGhiChuMoiToolStripMenuItem.Size = new Size(220, 26);
            moGhiChuMoiToolStripMenuItem.Text = "Mở ghi chú mới";
            moGhiChuMoiToolStripMenuItem.Click += moGhiChuMoiToolStripMenuItem_Click;

            // 
            // sapXepCuaSoToolStripMenuItem
            // 
            sapXepCuaSoToolStripMenuItem.Name = "sapXepCuaSoToolStripMenuItem";
            sapXepCuaSoToolStripMenuItem.Size = new Size(220, 26);
            sapXepCuaSoToolStripMenuItem.Text = "Sắp xếp cửa sổ";

            // 
            // thoatToolStripMenuItem
            // 
            thoatToolStripMenuItem.Name = "thoatToolStripMenuItem";
            thoatToolStripMenuItem.Size = new Size(220, 26);
            thoatToolStripMenuItem.Text = "Thoát";
            thoatToolStripMenuItem.Click += thoatToolStripMenuItem_Click;

            // 
            // cửaSổToolStripMenuItem
            // 
            cửaSổToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] {
                xepTangToolStripMenuItem,
                xepNgangToolStripMenuItem,
                xepDocToolStripMenuItem
            });
            cửaSổToolStripMenuItem.Name = "cửaSổToolStripMenuItem";
            cửaSổToolStripMenuItem.Size = new Size(67, 24);
            cửaSổToolStripMenuItem.Text = "Cửa sổ";

            // 
            // xepTangToolStripMenuItem
            // 
            xepTangToolStripMenuItem.Name = "xepTangToolStripMenuItem";
            xepTangToolStripMenuItem.Size = new Size(160, 26);
            xepTangToolStripMenuItem.Text = "Xếp tầng";
            xepTangToolStripMenuItem.Click += xepTangToolStripMenuItem_Click;

            // 
            // xepNgangToolStripMenuItem
            // 
            xepNgangToolStripMenuItem.Name = "xepNgangToolStripMenuItem";
            xepNgangToolStripMenuItem.Size = new Size(160, 26);
            xepNgangToolStripMenuItem.Text = "Xếp ngang";
            xepNgangToolStripMenuItem.Click += xepNgangToolStripMenuItem_Click;

            // 
            // xepDocToolStripMenuItem
            // 
            xepDocToolStripMenuItem.Name = "xepDocToolStripMenuItem";
            xepDocToolStripMenuItem.Size = new Size(160, 26);
            xepDocToolStripMenuItem.Text = "Xếp dọc";
            xepDocToolStripMenuItem.Click += xepDocToolStripMenuItem_Click;

            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] {
                toolStripStatusLabel1
            });
            statusStrip1.Location = new Point(0, 528);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(900, 26);
            statusStrip1.TabIndex = 1;

            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(150, 20);
            toolStripStatusLabel1.Text = "Số ghi chú đang mở: 0";

            // 
            // Form1
            // 
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 580);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            Name = "Form1";
            Text = "Quản lý ghi chú công việc";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem tệpToolStripMenuItem;
        private ToolStripMenuItem moGhiChuMoiToolStripMenuItem;
        private ToolStripMenuItem sapXepCuaSoToolStripMenuItem;
        private ToolStripMenuItem thoatToolStripMenuItem;
        private ToolStripMenuItem cửaSổToolStripMenuItem;
        private ToolStripMenuItem xepTangToolStripMenuItem;
        private ToolStripMenuItem xepNgangToolStripMenuItem;
        private ToolStripMenuItem xepDocToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
    }
}
