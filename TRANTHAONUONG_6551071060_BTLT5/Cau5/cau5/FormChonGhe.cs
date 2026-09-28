using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
namespace cau5
{
    public partial class FormChonGhe : Form
    {
        public string GheChon { get; private set; }

        private Button gheDangChon = null!;

        public FormChonGhe(string gheHienTai)
        {
            InitializeComponent();

            // Tạo 15 ghế
            string[] danhSachGhe =
            {
                "A1", "A2", "A3", "A4", "A5",
                "B1", "B2", "B3", "B4", "B5",
                "C1", "C2", "C3", "C4", "C5"
            };

            for (int i = 0; i < danhSachGhe.Length; i++)
            {
                Button btn = new Button();

                btn.Text = danhSachGhe[i];
                btn.Name = "btn" + danhSachGhe[i];

                btn.Size = new Size(40, 30);

                // 5 cột, 3 hàng
                int cot = i % 5;
                int hang = i / 5;

                btn.Location = new Point(
                    12 + cot * 42,
                    10 + hang * 27
                );

                btn.Font = new Font("Segoe UI", 10F);
                btn.BackColor = SystemColors.Control;
                btn.FlatStyle = FlatStyle.Standard;

                btn.Click += BtnGhe_Click;

                pnlGhe.Controls.Add(btn);

                // Nếu ghế hiện tại là ghế đã chọn
                if (!string.IsNullOrEmpty(gheHienTai) &&
                    gheHienTai == btn.Text)
                {
                    ChonGhe(btn);
                }
            }

            if (gheDangChon == null)
            {
                lblGheDaChon.Text = "Đang chọn:";
            }
        }

        private void BtnGhe_Click(object? sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                ChonGhe(btn);
            }
        }

        private void ChonGhe(Button btn)
        {
            // Bỏ màu của ghế cũ
            if (gheDangChon != null)
            {
                gheDangChon.BackColor = SystemColors.Control;
                gheDangChon.ForeColor = SystemColors.ControlText;
            }

            // Chọn ghế mới
            gheDangChon = btn;

            gheDangChon.BackColor = Color.SteelBlue;
            gheDangChon.ForeColor = Color.White;

            lblGheDaChon.Text = "Đang chọn: " + btn.Text;
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (gheDangChon == null)
            {
                MessageBox.Show(
                    "Vui lòng chọn một ghế.",
                    "Cảnh báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            GheChon = gheDangChon.Text;

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}