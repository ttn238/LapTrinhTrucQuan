using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cau16
{
    public partial class Formex1 : Form
    {
        public Formex1()
        {
            InitializeComponent();
        }

        private void Formex1_Load(object sender, EventArgs e)
        {

        }

        private void tileHorizontallyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void tileVerticallyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void newDocumentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.MdiParent = this;
            f.Show();
        }

        private void cBookProjectsQue7031602Code316C02binDebugAboutrtfToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2 ();
            f.MdiParent = this;
            f.Show();
        }

        private void cDocumentsAndSettingsAdministratorDesktopMCSDNETExam70316rtfToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.MdiParent = this;
            f.Show();
        }
    }
}

