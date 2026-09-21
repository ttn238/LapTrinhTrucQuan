using System;
using System.Drawing;
using System.Windows.Forms;

namespace CafeStatusDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblGioHienTai.Text = DateTime.Now.ToString("HH:mm:ss");

            int hour = DateTime.Now.Hour;
            if (hour >= 6 && hour < 22)
            {
                lblTrangThai.Text = "?ang m? c?a";
                lblTrangThai.ForeColor = Color.Green;
            }
            else
            {
                lblTrangThai.Text = "?ã ?óng c?a";
                lblTrangThai.ForeColor = Color.Red;
            }
        }

        private void doiMauNenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = colorDialog1.Color;
            }
        }

        private void thoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
