// =========================================================================
// Bài 5.2 - Bảng vẽ mini (sự kiện chuột và sự kiện Paint)
//
// 1. Môi trường phát triển:
//      - Framework : .NET 9.0 (Windows Forms App) - net9.0-windows
//      - Ngôn ngữ  : C#
//      - IDE       : Microsoft Visual Studio 2022
// 2. Project     : Chuong5_Cau2_BangVeMini
// 3. Tập tin     : FormBangVe.cs
// =========================================================================

using System.Drawing.Drawing2D;

namespace Chuong5_Cau2_BangVeMini
{
    public partial class FormBangVe : Form
    {
        private Bitmap anhNen;          // ảnh đệm lưu nét vẽ (không bị mất khi Form vẽ lại)
        private Graphics gVe;           // đối tượng vẽ lên ảnh đệm
        private bool dangVe = false;    // cờ: có đang giữ chuột trái hay không
        private Point diemTruoc;        // điểm trước đó để nối thành đường liền
        private Pen but = new Pen(Color.Blue, 2);

        public FormBangVe()
        {
            InitializeComponent();
            TaoAnhNen();
        }

        // Tạo ảnh đệm trắng đúng bằng kích thước Panel
        private void TaoAnhNen()
        {
            anhNen = new Bitmap(pnlCanvas.ClientSize.Width, pnlCanvas.ClientSize.Height);
            gVe = Graphics.FromImage(anhNen);
            gVe.Clear(Color.White);
            gVe.SmoothingMode = SmoothingMode.AntiAlias; // cho nét vẽ mượt
            but.StartCap = LineCap.Round;
            but.EndCap = LineCap.Round;
        }

        // ===== MouseDown: bắt đầu một nét vẽ =====
        private void pnlCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                dangVe = true;
                diemTruoc = e.Location;        // ghi nhớ điểm bắt đầu
                lblTrangThai.Text = "Đang vẽ...";
                lblTrangThai.ForeColor = Color.OrangeRed;
            }
        }

        // ===== MouseMove: vẽ từng đoạn nhỏ + luôn cập nhật tọa độ =====
        private void pnlCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            // Yêu cầu 3: Label hiện tọa độ dù có vẽ hay không
            lblViTri.Text = "X = " + e.X + " , Y = " + e.Y;

            if (dangVe)
            {
                // Nối điểm cũ với điểm mới -> nhiều đoạn nhỏ ghép lại thành nét liền mạch
                gVe.DrawLine(but, diemTruoc, e.Location);
                diemTruoc = e.Location;   // cập nhật lại điểm trước
                pnlCanvas.Invalidate();   // yêu cầu Panel vẽ lại (gọi sự kiện Paint)
            }
        }

        // ===== MouseUp: kết thúc nét vẽ =====
        private void pnlCanvas_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                dangVe = false;
                lblTrangThai.Text = "Sẵn sàng";
                lblTrangThai.ForeColor = Color.SeaGreen;
            }
        }

        // ===== Chuột phải: xóa trắng toàn bộ Panel =====
        private void pnlCanvas_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                gVe.Clear(Color.White);   // xóa nội dung ảnh đệm
                pnlCanvas.Invalidate();   // vẽ lại Panel -> màn hình trắng tinh
                lblTrangThai.Text = "Sẵn sàng";
                lblTrangThai.ForeColor = Color.SeaGreen;
            }
        }

        // ===== Giải phóng tài nguyên đồ họa khi đóng Form =====
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            but.Dispose();
            gVe.Dispose();
            anhNen.Dispose();
            base.OnFormClosed(e);
        }

        // ===== Paint: luôn vẽ lại ảnh đệm lên Panel =====
        // Nhờ vậy nét vẽ không bị mất khi cửa sổ bị che rồi hiện lại
        private void pnlCanvas_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(anhNen, 0, 0);
        }
    }
}
