using System.Windows.Forms;

namespace cau6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CapNhatSoLuongGhiChu();
        }

        private void moGhiChuMoiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGhiChu formGhiChu = new FormGhiChu();

            formGhiChu.MdiParent = this;

            formGhiChu.FormClosed += FormGhiChu_FormClosed;

            formGhiChu.Show();

            CapNhatSoLuongGhiChu();
        }

        private void FormGhiChu_FormClosed(object sender, FormClosedEventArgs e)
        {
            CapNhatSoLuongGhiChu();
        }

        private void xepTangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void xepNgangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void xepDocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void thoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CapNhatSoLuongGhiChu()
        {
            toolStripStatusLabel1.Text = "S? ghi chú ?ang m?: " + MdiChildren.Length;
        }
    }
}