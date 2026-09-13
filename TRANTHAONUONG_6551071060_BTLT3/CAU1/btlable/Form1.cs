namespace NGOCNGA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có thực sự muốn đóng không?",
                "Xác nhận đóng",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void buttiep_Click(object sender, EventArgs e)
        {
            opass.Text = "";
            opass.Clear();
            ohienthi.Text = "";
            ohienthi.Clear();
        }

        private void buthienthi_Click(object sender, EventArgs e)
        {
            ohienthi.Text = opass.Text;
        }
    }
}
