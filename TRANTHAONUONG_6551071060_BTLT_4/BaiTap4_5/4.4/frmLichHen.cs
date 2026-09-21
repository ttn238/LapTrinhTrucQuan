// =========================================================================
// Bài 4.4 - Quản lý phòng khám mini (ứng dụng MDI nhiều cửa sổ con)
//
// 1. Môi trường phát triển:
//      - Framework : .NET 9.0 (Windows Forms App) - net9.0-windows
//      - Ngôn ngữ  : C#
//      - IDE       : Microsoft Visual Studio 2022
// 2. Project     : Chuong4_Bai4_PhongKhamMDI
// 3. Tập tin     : frmLichHen.cs
// =========================================================================

namespace Chuong4_Bai4_PhongKhamMDI
{
    public partial class frmLichHen : Form
    {
        // Danh sách lịch hẹn riêng của từng cửa sổ
        private List<string> danhSachLichHen = new List<string>();

        public frmLichHen()
        {
            InitializeComponent();
        }

        private void btnDatLich_Click(object sender, EventArgs e)
        {
            if (txtTenBenhNhan.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập tên bệnh nhân!", "Thiếu thông tin",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string dong = dtpNgayHen.Value.ToString("dd/MM/yyyy HH:mm") + " - " + txtTenBenhNhan.Text.Trim();
            danhSachLichHen.Add(dong);

            lstLichHen.Items.Clear();
            foreach (string s in danhSachLichHen)
                lstLichHen.Items.Add(s);

            txtTenBenhNhan.Clear();
            txtTenBenhNhan.Focus();
        }
    }
}
