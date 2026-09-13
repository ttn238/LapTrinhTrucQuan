namespace MINHTU
{
    partial class frmSimpleEvent
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
            bntClickMe = new Button();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // bntClickMe
            // 
            bntClickMe.Anchor = AnchorStyles.None;
            bntClickMe.BackColor = SystemColors.GradientInactiveCaption;
            bntClickMe.FlatAppearance.BorderColor = Color.Blue;
            bntClickMe.FlatAppearance.BorderSize = 3;
            bntClickMe.FlatAppearance.MouseDownBackColor = Color.MintCream;
            bntClickMe.FlatAppearance.MouseOverBackColor = Color.White;
            bntClickMe.FlatStyle = FlatStyle.Flat;
            bntClickMe.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bntClickMe.ForeColor = Color.Red;
            bntClickMe.Location = new Point(256, 179);
            bntClickMe.Name = "bntClickMe";
            bntClickMe.Size = new Size(300, 101);
            bntClickMe.TabIndex = 0;
            bntClickMe.Text = "Click Me";
            bntClickMe.UseVisualStyleBackColor = false;
            bntClickMe.Click += bntClickMe_Click_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(bntClickMe);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 450);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // frmSimpleEvent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "frmSimpleEvent";
            Text = "Simple Event Example";
            Load += frmSimpleEvent_Click_Load;
            Click += frmSimpleEvent_Click;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button bntClickMe;
        private Panel panel1;
    }
}
