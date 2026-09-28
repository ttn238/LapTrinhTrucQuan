using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cau6
{
    public partial class FormGhiChu : Form
    {
        private bool daThayDoi = false;

        public FormGhiChu()
        {
            InitializeComponent();

            cboMucDoUuTien.Items.Add("Thấp");
            cboMucDoUuTien.Items.Add("Trung bình");
            cboMucDoUuTien.Items.Add("Cao");

            cboMucDoUuTien.SelectedIndex = 2;
        }

        private void FormGhiChu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S)
            {
                e.SuppressKeyPress = true;
                btnLuuGhiChu.PerformClick();
            }

            if (e.KeyCode == Keys.Escape)
            {
                if (daThayDoi)
                {
                    DialogResult ketQua = MessageBox.Show(
                        "Nội dung ghi chú đã thay đổi. Bạn có chắc muốn đóng không?",
                        "Xác nhận đóng",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (ketQua == DialogResult.Yes)
                    {
                        Close();
                    }
                }
                else
                {
                    Close();
                }
            }
        }

        private void txtNoiDung_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtNoiDung.Text.Length >= 500 &&
                !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

            if (!char.IsControl(e.KeyChar))
            {
                daThayDoi = true;
            }
        }

        private void txtNoiDung_TextChanged(object sender, EventArgs e)
        {
            daThayDoi = true;
        }

        private void txtTieuDe_TextChanged(object sender, EventArgs e)
        {
            daThayDoi = true;
        }

        private void cboMucDoUuTien_SelectedIndexChanged(object sender, EventArgs e)
        {
            daThayDoi = true;
        }

        private void lblTieuDeForm_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
            }
            else
            {
                WindowState = FormWindowState.Maximized;
            }
        }

        private void btnLuuGhiChu_MouseEnter(object sender, EventArgs e)
        {
            btnLuuGhiChu.BackColor = Color.LightBlue;
        }

        private void btnLuuGhiChu_MouseLeave(object sender, EventArgs e)
        {
            btnLuuGhiChu.BackColor = SystemColors.Control;
        }

        private void txtTieuDe_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTieuDe.Text))
            {
                e.Cancel = true;
                txtTieuDe.BackColor = Color.MistyRose;
                errorProvider1.SetError(
                    txtTieuDe,
                    "Tiêu đề không được để trống.");
            }
            else if (txtTieuDe.Text.Length > 50)
            {
                e.Cancel = true;
                txtTieuDe.BackColor = Color.MistyRose;
                errorProvider1.SetError(
                    txtTieuDe,
                    "Tiêu đề tối đa 50 ký tự.");
            }
        }

        private void txtTieuDe_Validated(object sender, EventArgs e)
        {
            txtTieuDe.BackColor = Color.White;
            errorProvider1.SetError(txtTieuDe, "");
        }

        private void btnLuuGhiChu_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                return;
            }

            this.Text = txtTieuDe.Text;
            daThayDoi = false;

            MessageBox.Show(
                "Đã lưu ghi chú",
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}
