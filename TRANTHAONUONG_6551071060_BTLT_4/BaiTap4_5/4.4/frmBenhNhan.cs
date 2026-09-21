// =========================================================================
// Bài 4.4 - Quản lý phòng khám mini (ứng dụng MDI nhiều cửa sổ con)
//
// 1. Môi trường phát triển:
//      - Framework : .NET 9.0 (Windows Forms App) - net9.0-windows
//      - Ngôn ngữ  : C#
//      - IDE       : Microsoft Visual Studio 2022
// 2. Project     : Chuong4_Bai4_PhongKhamMDI
// 3. Tập tin     : frmBenhNhan.cs
// =========================================================================

namespace Chuong4_Bai4_PhongKhamMDI
{
    public partial class frmBenhNhan : Form
    {
        // Mỗi cửa sổ con có danh sách RIÊNG của mình (biến thành viên, không dùng CSDL)
        private List<string> danhSachBenhNhan = new List<string>();

        public frmBenhNhan()
        {
            InitializeComponent();
        }

        private void btnLuuTam_Click(object sender, EventArgs e)
        {
            if (txtHoTen.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập họ tên bệnh nhân!", "Thiếu thông tin",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string dong = txtHoTen.Text.Trim() + " - " + numTuoi.Value + " tuổi - " + txtTrieuChung.Text.Trim();
            danhSachBenhNhan.Add(dong);

            // Nạp lại ListBox từ List
            lstBenhNhan.Items.Clear();
            foreach (string s in danhSachBenhNhan)
                lstBenhNhan.Items.Add(s);

            // Xóa trắng để nhập bệnh nhân tiếp theo
            txtHoTen.Clear();
            txtTrieuChung.Clear();
            numTuoi.Value = 0;
            txtHoTen.Focus();
        }
    }
}
