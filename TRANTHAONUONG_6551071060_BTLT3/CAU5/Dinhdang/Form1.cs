namespace Dinhdang
{
    public partial class fdinhdang : Form
    {
        public fdinhdang()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtNhapten_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text = txtNhapten.Text;
        }

        private void radred_CheckedChanged(object sender, EventArgs e)
        {
            if (radred.Checked)
            {
                textBox1.ForeColor = Color.Red;
                txtNhapten.ForeColor = Color.Red;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void fdinhdang_Load(object sender, EventArgs e)
        {
            txtNhapten.Focus();
            radred.Checked = true;
        }

        private void radgreen_CheckedChanged(object sender, EventArgs e)
        {
            if (radgreen.Checked)
            {
                textBox1.ForeColor = Color.Green;
                txtNhapten.ForeColor = Color.Green;
            }
        }

        private void radblue_CheckedChanged(object sender, EventArgs e)
        {
            if (radblue.Checked)
            {
                textBox1.ForeColor = Color.Blue;
                txtNhapten.ForeColor = Color.Blue;
            }
        }

        private void radioblack_CheckedChanged(object sender, EventArgs e)
        {
            if (radioblack.Checked)
            {
                textBox1.ForeColor = Color.Black;
                txtNhapten.ForeColor = Color.Black;
            }
        }

        private void DoiFont()
        {
            FontStyle style = FontStyle.Regular;

            if (cbdam.Checked)
            {
                style |= FontStyle.Bold;
            }

            if (cbnghieng.Checked)
            {
                style |= FontStyle.Italic;
            }

            if (chgach.Checked)
            {
                style |= FontStyle.Underline;
            }

            textBox1.Font = new Font(
                textBox1.Font.Name,
                textBox1.Font.Size,
                style
            );

            txtNhapten.Font = new Font(
                txtNhapten.Font.Name,
                txtNhapten.Font.Size,
                style
            );
        }

        private void cbdam_CheckedChanged(object sender, EventArgs e)
        {
            DoiFont();
        }

        private void cbnghieng_CheckedChanged(object sender, EventArgs e)
        {
            DoiFont();
        }

        private void chgach_CheckedChanged(object sender, EventArgs e)
        {
            DoiFont();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}