// =========================================================================
// Bài 5.1 - Form bán hàng siêu thị mini (KeyPress, KeyDown, KeyPreview)
//
// 1. Môi trường phát triển:
//      - Framework : .NET 9.0 (Windows Forms App) - net9.0-windows
//      - Ngôn ngữ  : C#
//      - IDE       : Microsoft Visual Studio 2022
// 2. Project     : Chuong5_Cau1_FormBanHang
// 3. Tập tin     : FormBanHang.cs
// =========================================================================

namespace Chuong5_Cau1_FormBanHang
{
    public partial class FormBanHang : Form
    {
        // Biến cờ: khi người dùng đã xác nhận thoát thì không hỏi lại lần nữa
        private bool daXacNhanThoat = false;

        public FormBanHang()
        {
            InitializeComponent();
        }

        // ===== YÊU CẦU 2: chỉ cho nhập chữ số 0-9 và phím Backspace =====
        // Dùng chung cho txtSoLuong và txtDonGia
        private void ChiChoNhapSo_KeyPress(object sender, KeyPressEventArgs e)
        {
            // char.IsControl(e.KeyChar) cho phép Backspace (mã 8), Delete, Ctrl+V...
            // Nếu ký tự không phải số và không phải phím điều khiển -> chặn lại
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Handled = true nghĩa là "đã xử lý rồi",
                                  // TextBox sẽ KHÔNG nhận ký tự này
            }
        }

        // ===== YÊU CẦU 6: KeyPreview = true (đặt trong Designer) =====
        // Nhờ KeyPreview, Form nhận phím TRƯỚC khi TextBox nhận,
        // nên F2/F5/Esc vẫn chạy dù con trỏ đang nằm trong TextBox.
        private void FormBanHang_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)          // YÊU CẦU 3
            {
                btnThem.PerformClick();        // kích hoạt nút Thêm
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.F5)     // YÊU CẦU 4
            {
                btnXoaTrang.PerformClick();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Escape) // YÊU CẦU 5
            {
                DialogResult tl = MessageBox.Show("Bạn có muốn thoát?",
                                                  "Xác nhận",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);
                if (tl == DialogResult.Yes)
                {
                    daXacNhanThoat = true;
                    this.Close();
                }
                e.Handled = true;
            }
        }

        // ===== Nút Thêm: đưa dữ liệu xuống ListBox =====
        private void btnThem_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu trước khi thêm
            if (txtMaSP.Text.Trim() == "" || txtSoLuong.Text.Trim() == "" || txtDonGia.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập đủ Mã SP, Số lượng và Đơn giá!",
                                "Thiếu dữ liệu",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Định dạng: "MaSP | SoLuong | DonGia"
            string dong = txtMaSP.Text.Trim() + " | " + txtSoLuong.Text.Trim() + " | " + txtDonGia.Text.Trim();
            lstKetQua.Items.Add(dong);

            // Nhập xong thì xóa trắng luôn cho nhanh (thu ngân nhập liên tục)
            XoaTrang();
        }

        // ===== Nút Xóa trắng =====
        private void btnXoaTrang_Click(object sender, EventArgs e)
        {
            XoaTrang();
        }

        // Hàm dùng chung: xóa 3 TextBox và đưa con trỏ về txtMaSP
        private void XoaTrang()
        {
            txtMaSP.Clear();
            txtSoLuong.Clear();
            txtDonGia.Clear();
            txtMaSP.Focus();
        }

        // Nếu người dùng bấm nút X trên cửa sổ thì cũng hỏi xác nhận
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (!daXacNhanThoat && e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult tl = MessageBox.Show("Bạn có muốn thoát?", "Xác nhận",
                                                  MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (tl == DialogResult.No) e.Cancel = true;
            }
            base.OnFormClosing(e);
        }
    }
}
