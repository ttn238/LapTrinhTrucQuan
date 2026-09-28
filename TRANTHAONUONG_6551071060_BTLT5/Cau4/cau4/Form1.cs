namespace cau4
{
    public partial class Form1 : Form
    {
        private int _indexDangSua = -1;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtTen.Text.Trim() == "" || txtSDT.Text.Trim() == "")
            {
                MessageBox.Show(
                    "Vui lòng nh?p ??y ?? tên và s? ?i?n tho?i.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            string lienHe = txtTen.Text.Trim() + " - " + txtSDT.Text.Trim();

            if (_indexDangSua == -1)
            {
                lstLienHe.Items.Add(lienHe);

                MessageBox.Show(
                    "Thêm thành công",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                lstLienHe.Items[_indexDangSua] = lienHe;
                _indexDangSua = -1;

                MessageBox.Show(
                    "C?p nh?t thành công.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }

            txtTen.Clear();
            txtSDT.Clear();
            lstLienHe.ClearSelected();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (lstLienHe.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Vui lòng ch?n m?t liên h? ?? s?a.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            _indexDangSua = lstLienHe.SelectedIndex;

            string lienHe = lstLienHe.SelectedItem.ToString();

            string[] thongTin = lienHe.Split(new string[] { " - " }, StringSplitOptions.None);

            txtTen.Text = thongTin[0];
            txtSDT.Text = thongTin[1];

            txtTen.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lstLienHe.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Vui lòng ch?n m?t liên h? ?? xóa",
                    "C?nh báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            string lienHe = lstLienHe.SelectedItem.ToString();
            string ten = lienHe.Split(new string[] { " - " }, StringSplitOptions.None)[0];

            DialogResult ketQua = MessageBox.Show(
                "B?n có ch?c mu?n xóa liên h? " + ten + "? Thao tác này không th? hoàn tác!",
                "Xác nh?n xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (ketQua == DialogResult.Yes)
            {
                lstLienHe.Items.RemoveAt(lstLienHe.SelectedIndex);

                MessageBox.Show(
                    "Xóa thành công.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                txtTen.Clear();
                txtSDT.Clear();
                _indexDangSua = -1;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (txtTen.Text.Trim() != "" || txtSDT.Text.Trim() != "")
            {
                DialogResult ketQua = MessageBox.Show(
                    "B?n có d? li?u ch?a ???c l?u. B?n mu?n thoát không?",
                    "C?nh báo",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Warning);

                if (ketQua == DialogResult.Yes)
                {
                    e.Cancel = false;
                }
                else if (ketQua == DialogResult.No)
                {
                    txtTen.Clear();
                    txtSDT.Clear();
                    e.Cancel = false;
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
