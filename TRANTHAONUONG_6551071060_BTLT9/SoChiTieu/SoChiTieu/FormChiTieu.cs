using Microsoft.EntityFrameworkCore;
using Serilog;
using SoChiTieu.Helpers;
using SoChiTieu.Models;
using System.ComponentModel;
using System.Globalization;

namespace SoChiTieu;

public class FormChiTieu : Form
{
    private readonly DateTimePicker dtNgayChi = new() { Format = DateTimePickerFormat.Short };
    private readonly TextBox txtNoiDung = new() { MaxLength = 100 };
    private readonly ComboBox cboLoaiChi = new() { DropDownStyle = ComboBoxStyle.DropDownList };
    private readonly NumericUpDown numSoTien = new() { Minimum = 0, Maximum = 1000000000, Increment = 1000, ThousandsSeparator = true, DecimalPlaces = 0 };
    private readonly TextBox txtGhiChu = new() { Multiline = true, ScrollBars = ScrollBars.Vertical, MaxLength = 200 };
    private readonly TextBox txtTim = new() { PlaceholderText = "Nhập nội dung cần tìm..." };
    private readonly ComboBox cboLocLoai = new() { DropDownStyle = ComboBoxStyle.DropDownList };
    private readonly DateTimePicker dtTuNgay = new() { Format = DateTimePickerFormat.Short };
    private readonly DateTimePicker dtDenNgay = new() { Format = DateTimePickerFormat.Short };
    private readonly DataGridView dgv = new() { Dock = DockStyle.Fill, ReadOnly = true, AllowUserToAddRows = false, AllowUserToDeleteRows = false, SelectionMode = DataGridViewSelectionMode.FullRowSelect, MultiSelect = false, AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill, RowHeadersVisible = false };
    private readonly Label lblTong = new() { AutoSize = true, Font = new Font("Segoe UI", 11, FontStyle.Bold), Text = "Tổng chi: 0 đ" };
    private readonly Button btnThem = new() { Text = "Thêm", Width = 90 };
    private readonly Button btnSua = new() { Text = "Sửa", Width = 90 };
    private readonly Button btnXoa = new() { Text = "Xóa", Width = 90 };
    private readonly Button btnMoi = new() { Text = "Làm mới", Width = 90 };
    private int? maDangChon;
    private bool dangNap;
    private readonly string[] loaiChi = ["Ăn uống", "Đi lại", "Học tập", "Giải trí", "Khác"];

    public FormChiTieu()
    {
        Text = "Sổ chi tiêu cá nhân";
        StartPosition = FormStartPosition.CenterScreen;
        MinimumSize = new Size(1000, 650);
        Size = new Size(1200, 760);
        Font = new Font("Segoe UI", 9F);
        TaoGiaoDien();
        cboLoaiChi.Items.AddRange(loaiChi);
        cboLocLoai.Items.Add("Tất cả loại chi");
        cboLocLoai.Items.AddRange(loaiChi);
        cboLoaiChi.SelectedIndex = 0;
        cboLocLoai.SelectedIndex = 0;
        dtTuNgay.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
        dtDenNgay.Value = DateTime.Today;
        btnThem.Click += (_, _) => Them();
        btnSua.Click += (_, _) => Sua();
        btnXoa.Click += (_, _) => Xoa();
        btnMoi.Click += (_, _) => LamMoi();
        dgv.SelectionChanged += (_, _) => HienThiDongDaChon();
        txtTim.TextChanged += (_, _) => TaiDanhSach();
        cboLocLoai.SelectedIndexChanged += (_, _) => TaiDanhSach();
        dtTuNgay.ValueChanged += (_, _) => TaiDanhSach();
        dtDenNgay.ValueChanged += (_, _) => TaiDanhSach();
        Shown += (_, _) => TaiDanhSach();
    }

    private void TaoGiaoDien()
    {
        var root = new TableLayoutPanel { Dock = DockStyle.Fill, Padding = new Padding(12), ColumnCount = 1, RowCount = 4 };
        root.RowStyles.Add(new RowStyle(SizeType.Absolute, 190));
        root.RowStyles.Add(new RowStyle(SizeType.Absolute, 82));
        root.RowStyles.Add(new RowStyle(SizeType.Percent, 100));
        root.RowStyles.Add(new RowStyle(SizeType.Absolute, 38));
        Controls.Add(root);

        var group = new GroupBox { Text = "Thông tin khoản chi", Dock = DockStyle.Fill, Padding = new Padding(10) };
        var form = new TableLayoutPanel { Dock = DockStyle.Fill, ColumnCount = 4, RowCount = 3 };
        form.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100)); form.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));
        form.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100)); form.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));
        form.RowStyles.Add(new RowStyle(SizeType.Absolute, 38)); form.RowStyles.Add(new RowStyle(SizeType.Absolute, 38)); form.RowStyles.Add(new RowStyle(SizeType.Percent, 100));
        AddField(form, "Ngày chi:", dtNgayChi, 0, 0); AddField(form, "Nội dung:", txtNoiDung, 2, 0);
        AddField(form, "Loại chi:", cboLoaiChi, 0, 1); AddField(form, "Số tiền (đ):", numSoTien, 2, 1);
        form.Controls.Add(new Label { Text = "Ghi chú:", TextAlign = ContentAlignment.TopLeft, Dock = DockStyle.Fill, Padding = new Padding(0, 7, 0, 0) }, 0, 2);
        form.Controls.Add(txtGhiChu, 1, 2); form.SetColumnSpan(txtGhiChu, 3); txtGhiChu.Dock = DockStyle.Fill;
        group.Controls.Add(form); root.Controls.Add(group, 0, 0);

        var searchGroup = new GroupBox { Text = "Tìm kiếm / lọc", Dock = DockStyle.Fill, Padding = new Padding(8) };
        var search = new TableLayoutPanel { Dock = DockStyle.Fill, ColumnCount = 6, RowCount = 2 };
        search.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 75)); search.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 34));
        search.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 75)); search.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24));
        search.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 65)); search.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 42));
        search.RowStyles.Add(new RowStyle(SizeType.Absolute, 28)); search.RowStyles.Add(new RowStyle(SizeType.Percent, 100));
        search.Controls.Add(new Label { Text = "Nội dung:", TextAlign = ContentAlignment.MiddleLeft, Dock = DockStyle.Fill }, 0, 0);
        search.Controls.Add(txtTim, 1, 0); txtTim.Dock = DockStyle.Fill;
        search.Controls.Add(new Label { Text = "Loại chi:", TextAlign = ContentAlignment.MiddleLeft, Dock = DockStyle.Fill }, 2, 0);
        search.Controls.Add(cboLocLoai, 3, 0); cboLocLoai.Dock = DockStyle.Fill;
        search.Controls.Add(new Label { Text = "Từ ngày:", TextAlign = ContentAlignment.MiddleLeft, Dock = DockStyle.Fill }, 4, 0);
        var datePanel = new FlowLayoutPanel { Dock = DockStyle.Fill, WrapContents = false };
        datePanel.Controls.Add(dtTuNgay); datePanel.Controls.Add(new Label { Text = "Đến:", AutoSize = true, Padding = new Padding(4, 7, 0, 0) }); datePanel.Controls.Add(dtDenNgay);
        search.Controls.Add(datePanel, 5, 0); search.SetRowSpan(datePanel, 2);
        var actions = new FlowLayoutPanel { Dock = DockStyle.Fill, WrapContents = false };
        actions.Controls.AddRange([btnThem, btnSua, btnXoa, btnMoi]);
        search.Controls.Add(actions, 0, 1); search.SetColumnSpan(actions, 5);
        searchGroup.Controls.Add(search); root.Controls.Add(searchGroup, 0, 1);
        root.Controls.Add(dgv, 0, 2);
        var bottom = new Panel { Dock = DockStyle.Fill };
        lblTong.Dock = DockStyle.Right; lblTong.TextAlign = ContentAlignment.MiddleRight; bottom.Controls.Add(lblTong); root.Controls.Add(bottom, 0, 3);
    }

    private static void AddField(TableLayoutPanel panel, string label, Control control, int col, int row)
    {
        panel.Controls.Add(new Label { Text = label, TextAlign = ContentAlignment.MiddleLeft, Dock = DockStyle.Fill }, col, row);
        panel.Controls.Add(control, col + 1, row); control.Dock = DockStyle.Fill;
    }

    private void TaiDanhSach()
    {
        if (dangNap || IsDisposed) return;
        if (dtTuNgay.Value.Date > dtDenNgay.Value.Date) { lblTong.Text = "Tổng chi: 0 đ (Khoảng ngày không hợp lệ)"; return; }
        try
        {
            using var db = AppConfig.CreateDbContext();
            var query = db.ChiTieu.AsNoTracking().Where(x => x.NgayChi >= dtTuNgay.Value.Date && x.NgayChi <= dtDenNgay.Value.Date);
            if (cboLocLoai.SelectedIndex > 0)
            {
                string loai = cboLocLoai.SelectedItem!.ToString()!;
                query = query.Where(x => x.LoaiChi == loai);
            }
            string tim = txtTim.Text.Trim();
            if (!string.IsNullOrWhiteSpace(tim)) query = query.Where(x => x.NoiDung.Contains(tim));
            var ds = query.OrderByDescending(x => x.NgayChi).ThenByDescending(x => x.MaCT).ToList();
            dangNap = true;
            dgv.DataSource = ds.Select(x => new ChiTieuHienThi { MaCT = x.MaCT, NgayChi = x.NgayChi, NoiDung = x.NoiDung, LoaiChi = x.LoaiChi, SoTien = x.SoTien, GhiChu = x.GhiChu }).ToList();
            dangNap = false;
            if (dgv.Columns[nameof(ChiTieuHienThi.MaCT)] != null) dgv.Columns[nameof(ChiTieuHienThi.MaCT)]!.HeaderText = "Mã";
            if (dgv.Columns[nameof(ChiTieuHienThi.NgayChi)] != null) dgv.Columns[nameof(ChiTieuHienThi.NgayChi)]!.HeaderText = "Ngày chi";
            if (dgv.Columns[nameof(ChiTieuHienThi.NoiDung)] != null) dgv.Columns[nameof(ChiTieuHienThi.NoiDung)]!.HeaderText = "Nội dung";
            if (dgv.Columns[nameof(ChiTieuHienThi.LoaiChi)] != null) dgv.Columns[nameof(ChiTieuHienThi.LoaiChi)]!.HeaderText = "Loại chi";
            if (dgv.Columns[nameof(ChiTieuHienThi.SoTien)] != null) { dgv.Columns[nameof(ChiTieuHienThi.SoTien)]!.HeaderText = "Số tiền (đ)"; dgv.Columns[nameof(ChiTieuHienThi.SoTien)]!.DefaultCellStyle.Format = "N0"; }
            if (dgv.Columns[nameof(ChiTieuHienThi.GhiChu)] != null) dgv.Columns[nameof(ChiTieuHienThi.GhiChu)]!.HeaderText = "Ghi chú";
            lblTong.Text = $"Tổng chi: {ds.Sum(x => x.SoTien).ToString("N0", CultureInfo.GetCultureInfo("vi-VN"))} đ  |  {ds.Count} khoản";
            HienThiDongDaChon();
        }
        catch (Exception ex)
        {
            dangNap = false; Log.Error(ex, "Lỗi truy cập CSDL khi tải danh sách chi tiêu");
            MessageBox.Show("Không thể tải dữ liệu chi tiêu. Hãy kiểm tra SQL Server và connection string trong appsettings.json.", "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }

    private void HienThiDongDaChon()
    {
        if (dangNap || dgv.CurrentRow?.DataBoundItem is not ChiTieuHienThi row) return;
        maDangChon = row.MaCT; dtNgayChi.Value = row.NgayChi; txtNoiDung.Text = row.NoiDung;
        cboLoaiChi.SelectedItem = loaiChi.Contains(row.LoaiChi) ? row.LoaiChi : "Khác";
        numSoTien.Value = Math.Clamp(row.SoTien, numSoTien.Minimum, numSoTien.Maximum); txtGhiChu.Text = row.GhiChu ?? string.Empty;
    }

    private bool KiemTra()
    {
        if (string.IsNullOrWhiteSpace(txtNoiDung.Text)) { MessageBox.Show("Vui lòng nhập nội dung khoản chi."); txtNoiDung.Focus(); return false; }
        if (numSoTien.Value <= 0) { MessageBox.Show("Số tiền phải lớn hơn 0."); numSoTien.Focus(); return false; }
        if (dtNgayChi.Value.Date > DateTime.Today) { MessageBox.Show("Ngày chi không được lớn hơn hôm nay."); dtNgayChi.Focus(); return false; }
        return true;
    }

    private ChiTieu LayDuLieu() => new() { NgayChi = dtNgayChi.Value.Date, NoiDung = txtNoiDung.Text.Trim(), LoaiChi = cboLoaiChi.SelectedItem?.ToString() ?? "Khác", SoTien = numSoTien.Value, GhiChu = string.IsNullOrWhiteSpace(txtGhiChu.Text) ? null : txtGhiChu.Text.Trim() };

    private void Them()
    {
        if (!KiemTra()) return;
        try
        {
            using var db = AppConfig.CreateDbContext(); var item = LayDuLieu(); db.ChiTieu.Add(item); db.SaveChanges();
            Log.Information("Thêm khoản chi MaCT={MaCT}, SoTien={SoTien}", item.MaCT, item.SoTien);
            LamMoi();
        }
        catch (Exception ex) { LoiLuu(ex, "thêm"); }
    }

    private void Sua()
    {
        if (maDangChon == null) { MessageBox.Show("Hãy chọn khoản chi cần sửa trong danh sách."); return; }
        if (!KiemTra()) return;
        try
        {
            using var db = AppConfig.CreateDbContext(); var item = db.ChiTieu.Find(maDangChon.Value);
            if (item == null) { MessageBox.Show("Khoản chi không còn tồn tại."); TaiDanhSach(); return; }
            var id = item.MaCT; item.NgayChi = dtNgayChi.Value.Date; item.NoiDung = txtNoiDung.Text.Trim(); item.LoaiChi = cboLoaiChi.SelectedItem?.ToString() ?? "Khác"; item.SoTien = numSoTien.Value; item.GhiChu = string.IsNullOrWhiteSpace(txtGhiChu.Text) ? null : txtGhiChu.Text.Trim();
            db.SaveChanges(); Log.Information("Sửa khoản chi MaCT={MaCT}, SoTien={SoTien}", id, item.SoTien); LamMoi();
        }
        catch (Exception ex) { LoiLuu(ex, "sửa"); }
    }

    private void Xoa()
    {
        if (maDangChon == null) { MessageBox.Show("Hãy chọn khoản chi cần xóa."); return; }
        if (MessageBox.Show($"Bạn có chắc muốn xóa khoản chi mã {maDangChon.Value}?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;
        try
        {
            using var db = AppConfig.CreateDbContext(); var item = db.ChiTieu.Find(maDangChon.Value);
            if (item != null) { int id = item.MaCT; db.ChiTieu.Remove(item); db.SaveChanges(); Log.Information("Xóa khoản chi MaCT={MaCT}", id); }
            LamMoi();
        }
        catch (Exception ex) { LoiLuu(ex, "xóa"); }
    }

    private void LoiLuu(Exception ex, string thaoTac)
    {
        Log.Error(ex, "Lỗi khi {ThaoTac} khoản chi", thaoTac);
        MessageBox.Show($"Không thể {thaoTac} khoản chi. Vui lòng kiểm tra kết nối CSDL rồi thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
    }

    private void LamMoi()
    {
        maDangChon = null; dgv.ClearSelection(); txtNoiDung.Clear(); txtGhiChu.Clear(); dtNgayChi.Value = DateTime.Today; cboLoaiChi.SelectedIndex = 0; numSoTien.Value = 0;
        TaiDanhSach();
    }

    private class ChiTieuHienThi
    {
        public int MaCT { get; set; }
        public DateTime NgayChi { get; set; }
        public string NoiDung { get; set; } = "";
        public string LoaiChi { get; set; } = "";
        public decimal SoTien { get; set; }
        public string? GhiChu { get; set; }
    }
}
