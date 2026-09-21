// =========================================================================
// Bài 4.2 - Đăng ký hội viên phòng Gym (các control nhập liệu và ToolTip)
//
// 1. Môi trường phát triển:
//      - Framework : .NET 9.0 (Windows Forms App) - net9.0-windows
//      - Ngôn ngữ  : C#
//      - IDE       : Microsoft Visual Studio 2022
// 2. Project     : Chuong4_Bai2_GymDangKy
// 3. Tập tin     : FormDangKy.cs
// =========================================================================

using System.Text;

namespace Chuong4_Bai2_GymDangKy
{
    public partial class FormDangKy : Form
    {
        public FormDangKy()
        {
            InitializeComponent();

            // ===== Thiết lập thuộc tính ToolTip trong constructor =====
            toolTip1.AutoPopDelay = 5000;   // chú thích hiện tối đa 5 giây rồi tự ẩn
            toolTip1.InitialDelay = 500;    // rê chuột nửa giây mới hiện
            toolTip1.ReshowDelay = 100;     // chuyển sang control khác thì hiện gần như ngay
            toolTip1.ShowAlways = true;     // hiện cả khi Form không active
            toolTip1.ToolTipTitle = "Hướng dẫn nhập";
            toolTip1.ToolTipIcon = ToolTipIcon.Info;

            // ===== Gán nội dung chú thích cho từng control =====
            // (Có thể làm bằng cửa sổ Properties, ở đây viết code cho dễ nhìn)
            toolTip1.SetToolTip(txtHoTen, "Nhập họ và tên đầy đủ, có dấu tiếng Việt");
            toolTip1.SetToolTip(txtSDT, "Nhập đúng 10 chữ số, không chứa khoảng trắng hay ký tự đặc biệt");
            toolTip1.SetToolTip(txtEmail, "Email dùng để nhận thông báo lịch tập và khuyến mãi");
            toolTip1.SetToolTip(dtpNgaySinh, "Chọn ngày sinh để xác định gói tập phù hợp");
            toolTip1.SetToolTip(cboGoiTap, "Gói VIP và Premium có kèm huấn luyện viên riêng");
            toolTip1.SetToolTip(numSoBuoiTuan, "Số buổi tập mỗi tuần, từ 1 đến 7 buổi");
            toolTip1.SetToolTip(btnDangKy, "Bấm để lưu thông tin hội viên mới");

            cboGoiTap.SelectedIndex = 0;   // mặc định chọn gói Basic
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu bắt buộc
            if (txtHoTen.Text.Trim() == "" || txtSDT.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Họ tên và Số điện thoại",
                                "Thiếu thông tin",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;   // dừng lại, không đăng ký
            }

            // Ghép chuỗi tổng hợp thông tin
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Họ tên: " + txtHoTen.Text.Trim());
            sb.AppendLine("SĐT: " + txtSDT.Text.Trim());
            sb.AppendLine("Email: " + txtEmail.Text.Trim());
            sb.AppendLine("Ngày sinh: " + dtpNgaySinh.Value.ToString("dd/MM/yyyy"));
            sb.AppendLine("Gói tập: " + cboGoiTap.Text);
            sb.AppendLine("Số buổi/tuần: " + numSoBuoiTuan.Value);

            MessageBox.Show(sb.ToString(), "Đăng ký thành công",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
