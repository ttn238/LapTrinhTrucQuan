namespace cau5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            cboPhim.Items.Add("Chi?n binh cu?i cùng");
            cboPhim.Items.Add("Avengers");
            cboPhim.Items.Add("Doraemon");
            cboPhim.Items.Add("Conan");

            cboSuatChieu.Items.Add("09:00");
            cboSuatChieu.Items.Add("13:00");
            cboSuatChieu.Items.Add("17:00");
            cboSuatChieu.Items.Add("19:00");

            // Hi?n th? gi?ng hình m?u
            cboPhim.SelectedIndex = 0;
            cboSuatChieu.SelectedIndex = 3;
        }

        private void btnChonGhe_Click(object sender, EventArgs e)
        {
            using (FormChonGhe dlg =
                   new FormChonGhe(txtGheDaChon.Text))
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    txtGheDaChon.Text = dlg.GheChon;
                }
            }
        }

        private void btnDatVe_Click(object sender, EventArgs e)
        {
            if (txtTenKhach.Text.Trim() == "" ||
                cboPhim.SelectedIndex == -1 ||
                cboSuatChieu.SelectedIndex == -1 ||
                txtGheDaChon.Text.Trim() == "")
            {
                MessageBox.Show(
                    "Vui lòng nh?p ??y ?? thông tin ??t vé.",
                    "C?nh báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            string thongTin =
                "Tên khách: " + txtTenKhach.Text.Trim() + "\n" +
                "Phim: " + cboPhim.Text + "\n" +
                "Su?t chi?u: " + cboSuatChieu.Text + "\n" +
                "Gh?: " + txtGheDaChon.Text + "\n" +
                "Giá vé: 75.000?/vé";

            DialogResult result = MessageBox.Show(
                thongTin + "\n\nXác nh?n ??t vé?",
                "Xác nh?n ??t vé",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                MessageBox.Show(
                    "??t vé thành công!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtTenKhach.Clear();
            cboPhim.SelectedIndex = -1;
            cboSuatChieu.SelectedIndex = -1;
            txtGheDaChon.Clear();
        }
    }
}