namespace cau16
{
    partial class Formex1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formex1));
            menuStrip1 = new MenuStrip();
            emufile = new ToolStripMenuItem();
            emunew = new ToolStripMenuItem();
            emuopen = new ToolStripMenuItem();
            emusaveas = new ToolStripMenuItem();
            emuexit = new ToolStripMenuItem();
            emufomat = new ToolStripMenuItem();
            emugelp = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { emufile, emufomat, emugelp });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(624, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // emufile
            // 
            emufile.DropDownItems.AddRange(new ToolStripItem[] { emunew, emuopen, emusaveas, emuexit });
            emufile.ImageScaling = ToolStripItemImageScaling.None;
            emufile.Name = "emufile";
            emufile.Size = new Size(46, 24);
            emufile.Text = "File";
            // 
            // emunew
            // 
            emunew.Image = (Image)resources.GetObject("emunew.Image");
            emunew.Name = "emunew";
            emunew.ShortcutKeys = Keys.Control | Keys.N;
            emunew.Size = new Size(231, 26);
            emunew.Text = "New";
            // 
            // emuopen
            // 
            emuopen.Image = (Image)resources.GetObject("emuopen.Image");
            emuopen.Name = "emuopen";
            emuopen.ShortcutKeys = Keys.Control | Keys.O;
            emuopen.Size = new Size(231, 26);
            emuopen.Text = "Open..";
            // 
            // emusaveas
            // 
            emusaveas.Image = (Image)resources.GetObject("emusaveas.Image");
            emusaveas.Name = "emusaveas";
            emusaveas.ShortcutKeys = Keys.Control | Keys.Shift | Keys.S;
            emusaveas.Size = new Size(231, 26);
            emusaveas.Text = "Save as";
            // 
            // emuexit
            // 
            emuexit.Image = (Image)resources.GetObject("emuexit.Image");
            emuexit.Name = "emuexit";
            emuexit.ShortcutKeys = Keys.Control | Keys.E;
            emuexit.Size = new Size(231, 26);
            emuexit.Text = "Exit";
            // 
            // emufomat
            // 
            emufomat.Name = "emufomat";
            emufomat.Size = new Size(65, 24);
            emufomat.Text = "Fomat";
            // 
            // emugelp
            // 
            emugelp.Name = "emugelp";
            emugelp.Size = new Size(55, 24);
            emugelp.Text = "Help";
            // 
            // Formex1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(624, 344);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Formex1";
            Text = " Creating a Main Menu for a Form";
            Load += Formex1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem emufile;
        private ToolStripMenuItem emunew;
        private ToolStripMenuItem emuopen;
        private ToolStripMenuItem emusaveas;
        private ToolStripMenuItem emuexit;
        private ToolStripMenuItem emufomat;
        private ToolStripMenuItem emugelp;
    }
}