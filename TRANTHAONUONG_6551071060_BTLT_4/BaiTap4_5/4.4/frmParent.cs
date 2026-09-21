// =========================================================================
// Bài 4.4 - Quản lý phòng khám mini (ứng dụng MDI nhiều cửa sổ con)
//
// 1. Môi trường phát triển:
//      - Framework : .NET 9.0 (Windows Forms App) - net9.0-windows
//      - Ngôn ngữ  : C#
//      - IDE       : Microsoft Visual Studio 2022
// 2. Project     : Chuong4_Bai4_PhongKhamMDI
// 3. Tập tin     : frmParent.cs
// =========================================================================

namespace Chuong4_Bai4_PhongKhamMDI
{
    public partial class frmParent : Form
    {
        // Đếm số cửa sổ đã mở để đặt tiêu đề khác nhau cho từng cửa sổ
        private int demBenhNhan = 0;
        private int demLichHen = 0;

        public frmParent()
        {
            InitializeComponent();
        }

        // ===== Mở form con Thông tin bệnh nhân =====
        // Mỗi lần bấm luôn tạo đối tượng MỚI HOÀN TOÀN
        private void mnuThongTinBenhNhan_Click(object sender, EventArgs e)
        {
            demBenhNhan++;
            frmBenhNhan f = new frmBenhNhan();
            f.Text = "Bệnh nhân " + demBenhNhan;   // Text này sẽ hiện trong menu "Cửa sổ"
            f.MdiParent = this;                     // gán cha là form MDI container
            f.Show();
        }

        // ===== Mở form con Đặt lịch hẹn =====
        private void mnuDatLichHen_Click(object sender, EventArgs e)
        {
            demLichHen++;
            frmLichHen f = new frmLichHen();
            f.Text = "Lịch hẹn " + demLichHen;
            f.MdiParent = this;
            f.Show();
        }

        // Ghi chú: KHÔNG cần viết code cập nhật menu "Cửa sổ".
        // Chỉ cần đặt MenuStrip.MdiWindowListItem = mnuCuaSo (xem file Designer),
        // WinForms sẽ tự liệt kê tên các form con đang mở và tự đánh dấu form đang active.
    }
}
