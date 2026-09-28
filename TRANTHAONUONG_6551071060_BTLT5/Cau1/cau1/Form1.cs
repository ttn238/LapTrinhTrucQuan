namespace cau6
{
    public partial class fdki : Form
    {
        public fdki()
        {
            InitializeComponent();
        }

        private void fdki_Load(object sender, EventArgs e)
        {

        }
        private bool KiemTraHopLe()
        {
            bool hopLe = true;
             
            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                errorProvider1.SetError(txtHoTen, "H? tên không ???c ?? tr?ng");
                hopLe = false;
            }
            else if (txtHoTen.Text.Trim().Length < 3)
            {
                errorProvider1.SetError(txtHoTen, "H? tên ph?i có ít nh?t 3 ký t?");
                hopLe = false;
            }
            else
            {
                errorProvider1.SetError(txtHoTen, "");
            }
             
            if (string.IsNullOrWhiteSpace(txtSDT.Text))
            {
                errorProvider1.SetError(txtSDT, "S? ?i?n tho?i không ???c ?? tr?ng");
                hopLe = false;
            }
            else if (txtSDT.Text.Length != 10 ||
                     !txtSDT.Text.StartsWith("0") ||
                     !long.TryParse(txtSDT.Text, out _))
            {
                errorProvider1.SetError(
                    txtSDT,
                    "S? ?i?n tho?i ph?i có 10 ch? s? và b?t ??u b?ng 0"
                );
                hopLe = false;
            }
            else
            {
                errorProvider1.SetError(txtSDT, "");
            }

            string email = txtEmail.Text.Trim();
            int viTriA = email.IndexOf("@");

            if (string.IsNullOrWhiteSpace(email))
            {
                errorProvider1.SetError(txtEmail, "Email không ???c ?? tr?ng");
                hopLe = false;
            }
            else if (viTriA <= 0 ||
                     viTriA != email.LastIndexOf("@") ||
                     viTriA == email.Length - 1 ||
                     email.IndexOf(".", viTriA + 1) == -1 ||
                     email.IndexOf(".", viTriA + 1) == email.Length - 1)
            {
                errorProvider1.SetError(txtEmail, "Email không ?úng ??nh d?ng");
                hopLe = false;
            }
            else
            {
                errorProvider1.SetError(txtEmail, "");
            }

            if (string.IsNullOrWhiteSpace(txtMatKhau.Text))
            {
                errorProvider1.SetError(
                    txtMatKhau,
                    "M?t kh?u không ???c ?? tr?ng"
                );
                hopLe = false;
            }
            else if (txtMatKhau.Text.Length < 6)
            {
                errorProvider1.SetError(
                    txtMatKhau,
                    "M?t kh?u ph?i có ít nh?t 6 ký t?"
                );
                hopLe = false;
            }
            else
            {
                errorProvider1.SetError(txtMatKhau, "");
            }
             
            if (txtXacNhanMK.Text != txtMatKhau.Text)
            {
                errorProvider1.SetError(
                    txtXacNhanMK,
                    "Xác nh?n m?t kh?u ph?i kh?p v?i m?t kh?u"
                );
                hopLe = false;
            }
            else
            {
                errorProvider1.SetError(txtXacNhanMK, "");
            }

            return hopLe;
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (!KiemTraHopLe())
                return;

            MessageBox.Show(
                "??ng ký thành công! Chào m?ng " + txtHoTen.Text,
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            btnHuy.CausesValidation = false;
            errorProvider1.Clear();
            this.Close();
        }

    }
}
