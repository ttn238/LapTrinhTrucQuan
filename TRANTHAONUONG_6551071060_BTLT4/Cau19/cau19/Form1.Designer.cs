namespace cau19
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            emufile = new ToolStripMenuItem();
            emuedit = new ToolStripMenuItem();
            fomatToolStripMenuItem = new ToolStripMenuItem();
            emufomat = new ToolStripMenuItem();
            emuhelp = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            emuNew = new ToolStripButton();
            emuOpen = new ToolStripButton();
            emuSave = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            emuCut = new ToolStripButton();
            emuCopy = new ToolStripButton();
            emupaste = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            emuquaylai = new ToolStripButton();
            emutiep = new ToolStripButton();
            statusStrip1 = new StatusStrip();
            lblTime = new ToolStripStatusLabel();
            lblDate = new ToolStripStatusLabel();
            rtbText = new RichTextBox();
            timer1 = new System.Windows.Forms.Timer(components);
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ActiveCaption;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { emufile, emuedit, emufomat, emuhelp });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(671, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // emufile
            // 
            emufile.Name = "emufile";
            emufile.Size = new Size(50, 24);
            emufile.Text = "File ";
            // 
            // emuedit
            // 
            emuedit.DropDownItems.AddRange(new ToolStripItem[] { fomatToolStripMenuItem });
            emuedit.Name = "emuedit";
            emuedit.Size = new Size(49, 24);
            emuedit.Text = "Edit";
            // 
            // fomatToolStripMenuItem
            // 
            fomatToolStripMenuItem.Name = "fomatToolStripMenuItem";
            fomatToolStripMenuItem.Size = new Size(83, 26);
            // 
            // emufomat
            // 
            emufomat.Name = "emufomat";
            emufomat.Size = new Size(65, 24);
            emufomat.Text = "Fomat";
            // 
            // emuhelp
            // 
            emuhelp.Name = "emuhelp";
            emuhelp.Size = new Size(55, 24);
            emuhelp.Text = "Help";
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = Color.PaleTurquoise;
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { emuNew, emuOpen, emuSave, toolStripSeparator1, emuCut, emuCopy, emupaste, toolStripSeparator2, emuquaylai, emutiep });
            toolStrip1.Location = new Point(0, 28);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(671, 27);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // emuNew
            // 
            emuNew.DisplayStyle = ToolStripItemDisplayStyle.Image;
            emuNew.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            emuNew.Image = (Image)resources.GetObject("emuNew.Image");
            emuNew.ImageTransparentColor = Color.Magenta;
            emuNew.Name = "emuNew";
            emuNew.Size = new Size(29, 24);
            emuNew.Text = "New";
            emuNew.Click += emuNew_Click;
            // 
            // emuOpen
            // 
            emuOpen.DisplayStyle = ToolStripItemDisplayStyle.Image;
            emuOpen.Image = (Image)resources.GetObject("emuOpen.Image");
            emuOpen.ImageTransparentColor = Color.Magenta;
            emuOpen.Name = "emuOpen";
            emuOpen.Size = new Size(29, 24);
            emuOpen.Text = "Open";
            emuOpen.Click += emuOpen_Click;
            // 
            // emuSave
            // 
            emuSave.DisplayStyle = ToolStripItemDisplayStyle.Image;
            emuSave.Image = (Image)resources.GetObject("emuSave.Image");
            emuSave.ImageTransparentColor = Color.Magenta;
            emuSave.Name = "emuSave";
            emuSave.Size = new Size(29, 24);
            emuSave.Text = "Save";
            emuSave.Click += emuSave_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 27);
            // 
            // emuCut
            // 
            emuCut.DisplayStyle = ToolStripItemDisplayStyle.Image;
            emuCut.Image = (Image)resources.GetObject("emuCut.Image");
            emuCut.ImageTransparentColor = Color.Magenta;
            emuCut.Name = "emuCut";
            emuCut.Size = new Size(29, 24);
            emuCut.Text = "Cut";
            emuCut.Click += emuCut_Click;
            // 
            // emuCopy
            // 
            emuCopy.DisplayStyle = ToolStripItemDisplayStyle.Image;
            emuCopy.Image = (Image)resources.GetObject("emuCopy.Image");
            emuCopy.ImageTransparentColor = Color.Magenta;
            emuCopy.Name = "emuCopy";
            emuCopy.Size = new Size(29, 24);
            emuCopy.Text = "Copy";
            emuCopy.Click += emuCopy_Click;
            // 
            // emupaste
            // 
            emupaste.DisplayStyle = ToolStripItemDisplayStyle.Image;
            emupaste.Image = (Image)resources.GetObject("emupaste.Image");
            emupaste.ImageTransparentColor = Color.Magenta;
            emupaste.Name = "emupaste";
            emupaste.Size = new Size(29, 24);
            emupaste.Text = "Paste";
            emupaste.Click += emupaste_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 27);
            // 
            // emuquaylai
            // 
            emuquaylai.DisplayStyle = ToolStripItemDisplayStyle.Image;
            emuquaylai.Image = (Image)resources.GetObject("emuquaylai.Image");
            emuquaylai.ImageTransparentColor = Color.Magenta;
            emuquaylai.Name = "emuquaylai";
            emuquaylai.Size = new Size(29, 24);
            emuquaylai.Text = "Quay lại";
            emuquaylai.Click += emuquaylai_Click;
            // 
            // emutiep
            // 
            emutiep.DisplayStyle = ToolStripItemDisplayStyle.Image;
            emutiep.Image = (Image)resources.GetObject("emutiep.Image");
            emutiep.ImageTransparentColor = Color.Magenta;
            emutiep.Name = "emutiep";
            emutiep.Size = new Size(29, 24);
            emutiep.Text = "Tiếp";
            emutiep.Click += emutiep_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.BackColor = SystemColors.ActiveCaption;
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblTime, lblDate });
            statusStrip1.Location = new Point(0, 404);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.RightToLeft = RightToLeft.Yes;
            statusStrip1.Size = new Size(671, 29);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            statusStrip1.ItemClicked += statusStrip1_ItemClicked;
            // 
            // lblTime
            // 
            lblTime.Font = new Font("Segoe UI", 10F);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(72, 23);
            lblTime.Text = "9:56 AM";
            // 
            // lblDate
            // 
            lblDate.Font = new Font("Segoe UI", 10F);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(178, 23);
            lblDate.Text = "Sunday, June 19, 2020";
            // 
            // rtbText
            // 
            rtbText.Location = new Point(0, 58);
            rtbText.Name = "rtbText";
            rtbText.Size = new Size(671, 349);
            rtbText.TabIndex = 3;
            rtbText.Text = "";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(671, 433);
            Controls.Add(rtbText);
            Controls.Add(statusStrip1);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem emufile;
        private ToolStripMenuItem emuedit;
        private ToolStripMenuItem fomatToolStripMenuItem;
        private ToolStripMenuItem emufomat;
        private ToolStripMenuItem emuhelp;
        private ToolStrip toolStrip1;
        private ToolStripButton emuNew;
        private ToolStripButton emuOpen;
        private ToolStripButton emuSave;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton emuCut;
        private ToolStripButton emuCopy;
        private ToolStripButton emupaste;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton emuquaylai;
        private ToolStripButton emutiep;
        private StatusStrip statusStrip1;
        private RichTextBox rtbText;
        private ToolStripStatusLabel lblTime;
        private ToolStripStatusLabel lblDate;
        private System.Windows.Forms.Timer timer1;
    }
}
