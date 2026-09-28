using System.ComponentModel;
using System.Globalization;

namespace cau2
{
    public partial class FormDatPhong : Form
    {
        public FormDatPhong()
        {
            InitializeComponent();
            txtHoTen.Validating += txtHoTen_Validating;
            txtHoTen.Validated += txtHoTen_Validated;
            txtCCCD.Validating += txtCCCD_Validating;
            txtCCCD.Validated += txtCCCD_Validated;
            txtNgayNhan.Validating += txtNgayNhan_Validating;
            txtNgayNhan.Validated += txtNgayNhan_Validated;
            txtNgayTra.Validating += txtNgayTra_Validating;
            txtNgayTra.Validated += txtNgayTra_Validated;
            txtSoNguoiLon.Validating += txtSoNguoiLon_Validating;
            txtSoNguoiLon.Validated += txtSoNguoiLon_Validated;
            txtSoTreEm.Validating += txtSoTreEm_Validating;
            txtSoTreEm.Validated += txtSoTreEm_Validated;
        }

        private void FormDatPhong_Load(object sender, EventArgs e)
        {

        }

        // Ki?m tra h? tên
        private void txtHoTen_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtHoTen, "H? tên không ???c ?? tr?ng");
                txtHoTen.BackColor = Color.MistyRose;
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtHoTen, "");
                txtHoTen.BackColor = Color.Honeydew;
            }
        }

        private void txtCCCD_Validating(object sender, CancelEventArgs e)
        {
            if (txtCCCD.Text.Length != 12 ||
                !long.TryParse(txtCCCD.Text, out _))
            {
                e.Cancel = true;
                errorProvider1.SetError(
                    txtCCCD,
                    "CCCD ph?i g?m ?úng 12 ch? s?"
                );
                txtCCCD.BackColor = Color.MistyRose;
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtCCCD, "");
                txtCCCD.BackColor = Color.Honeydew;
            }
        }

        private void txtNgayNhan_Validating(object sender, CancelEventArgs e)
        {
            DateTime ngayNhan;

            if (!DateTime.TryParseExact(
                txtNgayNhan.Text,
                "dd/MM/yyyy",
                CultureInfo.InvariantCulture,
                DateTimeStyles.None,
                out ngayNhan))
            {
                e.Cancel = true;
                errorProvider1.SetError(
                    txtNgayNhan,
                    "Ngày nh?n ph?i có d?ng dd/MM/yyyy"
                );
                txtNgayNhan.BackColor = Color.MistyRose;
            }
            else if (ngayNhan < DateTime.Today)
            {
                e.Cancel = true;
                errorProvider1.SetError(
                    txtNgayNhan,
                    "Ngày nh?n phòng ph?i t? hôm nay tr? ?i"
                );
                txtNgayNhan.BackColor = Color.MistyRose;
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtNgayNhan, "");
                txtNgayNhan.BackColor = Color.Honeydew;
            }
        }

        private void txtNgayTra_Validating(object sender, CancelEventArgs e)
        {
            DateTime ngayNhan;
            DateTime ngayTra;

            if (!DateTime.TryParseExact(
                txtNgayTra.Text,
                "dd/MM/yyyy",
                CultureInfo.InvariantCulture,
                DateTimeStyles.None,
                out ngayTra))
            {
                e.Cancel = true;
                errorProvider1.SetError(
                    txtNgayTra,
                    "Ngày tr? ph?i có d?ng dd/MM/yyyy"
                );
                txtNgayTra.BackColor = Color.MistyRose;
            }
            else if (!DateTime.TryParseExact(
                txtNgayNhan.Text,
                "dd/MM/yyyy",
                CultureInfo.InvariantCulture,
                DateTimeStyles.None,
                out ngayNhan))
            {
                e.Cancel = true;
                errorProvider1.SetError(
                    txtNgayTra,
                    "Vui lòng nh?p ngày nh?n phòng ?úng tr??c"
                );
                txtNgayTra.BackColor = Color.MistyRose;
            }
            else if (ngayTra <= ngayNhan)
            {
                e.Cancel = true;
                errorProvider1.SetError(
                    txtNgayTra,
                    "Ngày tr? phòng ph?i l?n h?n ngày nh?n phòng"
                );
                txtNgayTra.BackColor = Color.MistyRose;
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtNgayTra, "");
                txtNgayTra.BackColor = Color.Honeydew;
            }
        }

        private void txtSoNguoiLon_Validating(object sender, CancelEventArgs e)
        {
            int soNguoiLon;

            if (!int.TryParse(txtSoNguoiLon.Text, out soNguoiLon) ||
                soNguoiLon < 1 ||
                soNguoiLon > 4)
            {
                e.Cancel = true;
                errorProvider1.SetError(
                    txtSoNguoiLon,
                    "S? ng??i l?n ph?i t? 1 ??n 4"
                );
                txtSoNguoiLon.BackColor = Color.MistyRose;
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtSoNguoiLon, "");
                txtSoNguoiLon.BackColor = Color.Honeydew;
            }
        }

        private void txtSoTreEm_Validating(object sender, CancelEventArgs e)
        {
            int soTreEm;

            if (!int.TryParse(txtSoTreEm.Text, out soTreEm) ||
                soTreEm < 0 ||
                soTreEm > 3)
            {
                e.Cancel = true;
                errorProvider1.SetError(
                    txtSoTreEm,
                    "S? tr? em ph?i t? 0 ??n 3"
                );
                txtSoTreEm.BackColor = Color.MistyRose;
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtSoTreEm, "");
                txtSoTreEm.BackColor = Color.Honeydew;
            }
        }

        private void txtHoTen_Validated(object sender, EventArgs e)
        {
            txtHoTen.BackColor = Color.Honeydew;
        }

        private void txtCCCD_Validated(object sender, EventArgs e)
        {
            txtCCCD.BackColor = Color.Honeydew;
        }

        private void txtNgayNhan_Validated(object sender, EventArgs e)
        {
            txtNgayNhan.BackColor = Color.Honeydew;
        }

        private void txtNgayTra_Validated(object sender, EventArgs e)
        {
            txtNgayTra.BackColor = Color.Honeydew;
        }

        private void txtSoNguoiLon_Validated(object sender, EventArgs e)
        {
            txtSoNguoiLon.BackColor = Color.Honeydew;
        }

        private void txtSoTreEm_Validated(object sender, EventArgs e)
        {
            txtSoTreEm.BackColor = Color.Honeydew;
        }

        private void btnDatPhong_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                return;
            }

            DateTime ngayNhan;
            DateTime ngayTra;

            if (!DateTime.TryParseExact(
                txtNgayNhan.Text,
                "dd/MM/yyyy",
                CultureInfo.InvariantCulture,
                DateTimeStyles.None,
                out ngayNhan))
            {
                return;
            }

            if (!DateTime.TryParseExact(
                txtNgayTra.Text,
                "dd/MM/yyyy",
                CultureInfo.InvariantCulture,
                DateTimeStyles.None,
                out ngayTra))
            {
                return;
            }

            int soDem = (ngayTra - ngayNhan).Days;

            MessageBox.Show(
                "??t phòng thành công!\n\n" +
                "Khách hàng: " + txtHoTen.Text + "\n" +
                "S? ?êm: " + soDem + "\n" +
                "S? ng??i l?n: " + txtSoNguoiLon.Text + "\n" +
                "S? tr? em: " + txtSoTreEm.Text,
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void FormDatPhong_Load_1(object sender, EventArgs e)
        {

        }
    }
}