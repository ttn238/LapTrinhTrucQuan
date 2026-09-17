namespace cau19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString("dddd, MMMM dd, yyyy");
            lblTime.Text = DateTime.Now.ToString("hh:mm tt");
        }

        private void emuNew_Click(object sender, EventArgs e)
        {
            rtbText.Clear();
        }

        private void emuOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (open.ShowDialog() == DialogResult.OK)
            {
                rtbText.Text = File.ReadAllText(open.FileName);
            }
        }

        private void emuSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (save.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(save.FileName, rtbText.Text);
            }
        }

        private void emuCut_Click(object sender, EventArgs e)
        {
            rtbText.Cut();
        }

        private void emuCopy_Click(object sender, EventArgs e)
        {
            rtbText.Copy();
        }

        private void emupaste_Click(object sender, EventArgs e)
        {
            rtbText.Paste();
        }

        private void emuquaylai_Click(object sender, EventArgs e)
        {
            if (rtbText.CanUndo)
            {
                rtbText.Undo();
            }
        }

        private void emutiep_Click(object sender, EventArgs e)
        {
            if (rtbText.CanRedo)
            {
                rtbText.Redo();
            }
        }
    }
}

