// =========================================================================
// Bài 4.3 - Danh sách việc cần làm (ListBox và ContextMenuStrip)
//
// 1. Môi trường phát triển:
//      - Framework : .NET 9.0 (Windows Forms App) - net9.0-windows
//      - Ngôn ngữ  : C#
//      - IDE       : Microsoft Visual Studio 2022
// 2. Project     : Chuong4_Bai3_ToDoList
// 3. Tập tin     : FormToDo.cs
// =========================================================================

namespace Chuong4_Bai3_ToDoList
{
    public partial class FormToDo : Form
    {
        // Tiền tố đánh dấu công việc đã xong
        private const string TIEN_TO = "[Hoàn thành] ";

        public FormToDo()
        {
            InitializeComponent();
        }

        // ===== Thêm công việc mới =====
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtCongViecMoi.Text.Trim() != "")
            {
                lstCongViec.Items.Add(txtCongViecMoi.Text.Trim());
                txtCongViecMoi.Clear();
                txtCongViecMoi.Focus();
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập nội dung công việc!", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Mẹo nhỏ: bấm chuột phải lên dòng nào thì chọn luôn dòng đó
        // (nếu không, menu ngữ cảnh sẽ tác động lên dòng đang chọn trước đó)
        private void lstCongViec_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int chiSo = lstCongViec.IndexFromPoint(e.Location);
                if (chiSo != ListBox.NoMatches)
                    lstCongViec.SelectedIndex = chiSo;
            }
        }

        // ===== Menu: Đánh dấu hoàn thành =====
        private void mnuHoanThanh_Click(object sender, EventArgs e)
        {
            if (lstCongViec.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn một công việc trước!", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int viTri = lstCongViec.SelectedIndex;
            string noiDung = lstCongViec.Items[viTri].ToString();

            // Kiểm tra để không bị lặp tiền tố khi bấm nhiều lần
            if (!noiDung.StartsWith(TIEN_TO))
            {
                lstCongViec.Items[viTri] = TIEN_TO + noiDung;
                lstCongViec.SelectedIndex = viTri;   // giữ nguyên dòng đang chọn
            }
            else
            {
                MessageBox.Show("Công việc này đã được đánh dấu hoàn thành rồi.", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // ===== Menu: Xóa công việc này =====
        private void mnuXoaMot_Click(object sender, EventArgs e)
        {
            if (lstCongViec.SelectedItem != null)
            {
                lstCongViec.Items.Remove(lstCongViec.SelectedItem);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn công việc cần xóa!", "Chưa chọn dòng nào",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // ===== Menu: Xóa tất cả =====
        private void mnuXoaTatCa_Click(object sender, EventArgs e)
        {
            if (lstCongViec.Items.Count == 0)
            {
                MessageBox.Show("Danh sách đang trống.", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult tl = MessageBox.Show("Bạn có chắc muốn xóa TẤT CẢ công việc?",
                                              "Xác nhận",
                                              MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (tl == DialogResult.Yes)
            {
                lstCongViec.Items.Clear();
            }
        }
    }
}
