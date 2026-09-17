namespace cau16
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
            btnex1 = new Button();
            btnex2 = new Button();
            SuspendLayout();
            // 
            // btnex1
            // 
            btnex1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnex1.Location = new Point(59, 66);
            btnex1.Name = "btnex1";
            btnex1.Size = new Size(438, 103);
            btnex1.TabIndex = 0;
            btnex1.Text = "Ex: Creating a Main Menu for a Form";
            btnex1.UseVisualStyleBackColor = true;
            btnex1.Click += btnex1_Click;
            // 
            // btnex2
            // 
            btnex2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnex2.Location = new Point(59, 250);
            btnex2.Name = "btnex2";
            btnex2.Size = new Size(448, 99);
            btnex2.TabIndex = 1;
            btnex2.Text = "Ex : Creating a Context Menu for a Form ";
            btnex2.UseVisualStyleBackColor = true;
            btnex2.Click += btnex2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(551, 411);
            Controls.Add(btnex2);
            Controls.Add(btnex1);
            IsMdiContainer = true;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnex1;
        private Button btnex2;
    }
}
