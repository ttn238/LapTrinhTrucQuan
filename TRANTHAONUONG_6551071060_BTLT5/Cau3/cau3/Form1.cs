 namespace cau3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DangKyEnterChuyenField();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void DangKyEnterChuyenField()
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.KeyPress += TextBox_KeyPress;
                }
            }
        }

        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;

                if (sender == txtAnh)
                {
                    btnLuu.PerformClick();
                }
                else
                {
                    SelectNextControl((Control)sender, true, true, true, true);
                }
            }
        }

        private void txtToan_Enter(object sender, EventArgs e)
        {
            txtToan.SelectAll();
        }

        private void txtVan_Enter(object sender, EventArgs e)
        {
            txtVan.SelectAll();
        }

        private void txtAnh_Enter(object sender, EventArgs e)
        {
            txtAnh.SelectAll();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            bool hopLe = true;

            decimal toan;
            decimal van;
            decimal anh;

            if (!decimal.TryParse(txtToan.Text, out toan) || toan < 0.0m || toan > 10.0m)
            {
                errorProvider1.SetError(txtToan, "?i?m Toán ph?i t? 0.0 ??n 10.0");
                hopLe = false;
            }

            if (!decimal.TryParse(txtVan.Text, out van) || van < 0.0m || van > 10.0m)
            {
                errorProvider1.SetError(txtVan, "?i?m V?n ph?i t? 0.0 ??n 10.0");
                hopLe = false;
            }

            if (!decimal.TryParse(txtAnh.Text, out anh) || anh < 0.0m || anh > 10.0m)
            {
                errorProvider1.SetError(txtAnh, "?i?m Anh ph?i t? 0.0 ??n 10.0");
                hopLe = false;
            }

            if (!hopLe)
            {
                return;
            }

            string dong = txtMaHS.Text + " | " + txtHoTen.Text
                        + " | T:" + txtToan.Text
                        + " V:" + txtVan.Text
                        + " A:" + txtAnh.Text;

            lstDanhSach.Items.Add(dong);

            txtMaHS.Clear();
            txtHoTen.Clear();
            txtToan.Clear();
            txtVan.Clear();
            txtAnh.Clear();

            txtMaHS.Focus();
        }

        private void btnXoaTrang_Click(object sender, EventArgs e)
        {
            txtMaHS.Clear();
            txtHoTen.Clear();
            txtToan.Clear();
            txtVan.Clear();
            txtAnh.Clear();

            errorProvider1.Clear();

            txtMaHS.Focus();
        }
    }
}

