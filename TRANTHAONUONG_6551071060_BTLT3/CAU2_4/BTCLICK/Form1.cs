namespace MINHTU
{
    public partial class frmSimpleEvent : Form
    {
        public frmSimpleEvent()
        {
            InitializeComponent();
        }

        private void bntClickMe_Click_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Button was clicked.");
        }

        private void frmSimpleEvent_Click_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Hi , Welcome to C# 2010 programming!");
        }

        private void frmSimpleEvent_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Form was clicked.");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
