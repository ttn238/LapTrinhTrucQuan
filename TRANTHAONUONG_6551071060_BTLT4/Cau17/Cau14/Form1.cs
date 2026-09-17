namespace Cau14
{
    public partial class Formcapnhat : Form
    {
        public Formcapnhat()
        {
            InitializeComponent();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (txtTen.Text == "")
            {
                MessageBox.Show("Bạn không được phép nhập dữ liệu rỗng!", "Thông Báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtTen.Focus();
            }
            else
            {
                string strDuLieu = txtTen.Text;

                lstLopA.Items.Add(strDuLieu);

                txtTen.Clear();
                txtTen.Focus();
            }
        }

        void chuyenDuLieu(ListBox lst1, ListBox lst2)
        {
            int i = 0;

            while (i < lst1.Items.Count)
            {
                if (lst1.GetSelected(i))
                {
                    string stDuLieu = lst1.Items[i].ToString();

                    lst2.Items.Add(stDuLieu);

                    lst1.Items.RemoveAt(i);
                }
                else
                {
                    i++;
                }
            }
        }

        private void btnChuyen_Click(object sender, EventArgs e)
        {
            DialogResult hoiChuyen;

            if (lstLopA.Items.Count > 0)
            {
                hoiChuyen = MessageBox.Show(
                    "Bạn có chắc chuyển những dữ liệu đang chọn không?",
                    "Thông Báo",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1);

                if (hoiChuyen == DialogResult.Yes)
                {
                    chuyenDuLieu(lstLopA, lstLopB);
                }
            }
            else
            {
                MessageBox.Show("Danh sách hiện đang rỗng!", "Chú ý");
            }
        }

        private void btnTraLai_Click(object sender, EventArgs e)
        {
            DialogResult hoiChuyen;

            if (lstLopB.Items.Count > 0)
            {
                hoiChuyen = MessageBox.Show(
                    "Bạn có chắc chuyển những dữ liệu đang chọn không?",
                    "Thông Báo",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1);

                if (hoiChuyen == DialogResult.Yes)
                {
                    chuyenDuLieu(lstLopB, lstLopA);
                }
            }
            else
            {
                MessageBox.Show("Danh sách hiện đang rỗng!", "Chú ý");
            }
        }

        void chuyenToanBo(ListBox lst1, ListBox lst2)
        {
            while (lst1.Items.Count != 0)
            {
                string stDuLieu = lst1.Items[0].ToString();

                lst2.Items.Add(stDuLieu);

                lst1.Items.RemoveAt(0);
            }
        }

        private void btnChuyenTatCa_Click(object sender, EventArgs e)
        {
            DialogResult hoiChuyen;

            if (lstLopA.Items.Count > 0)
            {
                hoiChuyen = MessageBox.Show(
                    "Bạn có chắc chuyển toàn bộ dữ liệu không?",
                    "Thông Báo",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1);

                if (hoiChuyen == DialogResult.Yes)
                {
                    chuyenToanBo(lstLopA, lstLopB);
                }
            }
            else
            {
                MessageBox.Show("Danh sách hiện đang rỗng!", "Chú ý");
            }
        }

        private void btnTraLaiTatCa_Click(object sender, EventArgs e)
        {
            DialogResult hoiChuyen;

            if (lstLopB.Items.Count > 0)
            {
                hoiChuyen = MessageBox.Show(
                    "Bạn có chắc chuyển toàn bộ dữ liệu không?",
                    "Thông Báo",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1);

                if (hoiChuyen == DialogResult.Yes)
                {
                    chuyenToanBo(lstLopB, lstLopA);
                }
            }
            else
            {
                MessageBox.Show("Danh sách hiện đang rỗng!", "Chú ý");
            }
        }

        void xoaDuLieu(ListBox lst)
        {
            int i = 0;

            while (i < lst.Items.Count)
            {
                if (lst.GetSelected(i))
                {
                    lst.Items.RemoveAt(i);
                }
                else
                {
                    i++;
                }
            }
        }

        private void btnXoaLopA_Click(object sender, EventArgs e)
        {
            DialogResult hoiXoa;

            if (lstLopA.Items.Count > 0)
            {
                hoiXoa = MessageBox.Show(
                    "Bạn có chắc xóa những phần tử này không?",
                    "Chú ý",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1);

                if (hoiXoa == DialogResult.Yes)
                {
                    xoaDuLieu(lstLopA);
                }
            }
            else
            {
                MessageBox.Show("Hiện danh sách đang rỗng!", "Chú ý");
            }
        }

        private void btnXoaLopB_Click(object sender, EventArgs e)
        {
            DialogResult hoiXoa;

            if (lstLopB.Items.Count > 0)
            {
                hoiXoa = MessageBox.Show(
                    "Bạn có chắc xóa những phần tử này không?",
                    "Chú ý",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1);

                if (hoiXoa == DialogResult.Yes)
                {
                    xoaDuLieu(lstLopB);
                }
            }
            else
            {
                MessageBox.Show("Hiện danh sách đang rỗng!", "Chú ý");
            }
        }

        private void btnkt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Formcapnhat_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult hoiThoat;

            hoiThoat = MessageBox.Show(
                "Bạn có chắc muốn thoát chương trình không?",
                "Thông Báo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (hoiThoat == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void hệThốngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cậpNhậtToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void kếtThúcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnkt_Click(sender, e);
        }

        private void thôngTinToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show(
                "THÔNG TIN SINH VIÊN\n\n" +
                "Họ tên: Trần Thảo Nương\n" +
                "Mã sinh viên: 6551071060\n" +
                "Lớp: CNTT.CQ.65",
                "Thông tin sinh viên",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void cậpNhậtLớpAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnCapNhat_Click(sender, e);
        }

        private void cấpNhậtLớpBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtTen.Text == "")
            {
                MessageBox.Show("Bạn không được phép nhập dữ liệu rỗng!", "Thông Báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtTen.Focus();
            }
            else
            {
                string strDuLieu = txtTen.Text;

                lstLopB.Items.Add(strDuLieu);

                txtTen.Clear();
                txtTen.Focus();
            }
        }

        private void chuyểnPhầnTửChọnSangLớpAToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            btnTraLai_Click(sender, e);
        }

        private void chuyểnPhầnTửChọnSangLơpsBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnChuyen_Click(sender, e);
        }

        private void chuyểnHếtDsSangLớpAToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            btnTraLaiTatCa_Click(sender, e);
        }

        private void chuyểnHếtDsSangLớpBToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            btnChuyenTatCa_Click(sender, e);
        }

        private void xóaDanhSáchLớpAToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            btnXoaLopA_Click(sender, e);
        }

        private void xóaDanhSáchLớpBToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            btnXoaLopB_Click(sender, e);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tssngay.Text = DateTime.Now.ToString("dddd, MMMM dd, yyyy");
            tssgio.Text = DateTime.Now.ToString("hh:mm tt");
            
        }

        
    }
}