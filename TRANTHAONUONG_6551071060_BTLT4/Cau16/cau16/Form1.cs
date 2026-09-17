namespace cau16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnex1_Click(object sender, EventArgs e)
        {
            Formex1 ex1form1 = new Formex1();
            ex1form1.MdiParent = this;
            ex1form1.Show();
            btnex1.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnex2_Click(object sender, EventArgs e)
        {
            Formex2 ex1form2 = new Formex2();
            ex1form2.MdiParent = this;
            ex1form2.Show();
            btnex2.Hide();
        }
    }
}
