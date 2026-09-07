using System;
using System.Collections.Generic;
using System.Runtime.Remoting.Messaging;

namespace QuanLySanPhamCuaHang
{
    class SanPham
    {
        private string _maSP;
        private string _tenSP;
        private decimal _gia;
        private int _soLuongTon;

        public string MaSP
        {
            get { return _maSP; }
            set { _maSP = value; }
        }

        public string TenSP
        {
            get { return _tenSP; }
            set { _tenSP = value; }
        }

        public decimal Gia
        {
            get { return _gia; }
            set { _gia = value; }
        }

        public int SoLuongTon
        {
            get { return _soLuongTon; }
            set { _soLuongTon = value; }
        }

        public SanPham(string maSP, string tenSP, decimal gia, int soLuongTon)
        {
            _maSP = maSP;
            _tenSP = tenSP;
            _gia = gia;
            _soLuongTon = soLuongTon;
        }

        public SanPham() { }
        public virtual decimal TinhGiaBan()
        {
            return _gia;
        }

        public virtual string MoTa()
        {
            return $"Mã SP: {_maSP}, Tên: {_tenSP}, Giá: {_gia:N0} VNĐ";
        }
    }

    class SanPhamThucPham : SanPham
    {
        private DateTime _ngayHetHan;
        private int _nhietDoBaoQuan;
        public SanPhamThucPham(
            string maSP,
            string tenSP,
            decimal gia,
            int soLuongTon,
            DateTime ngayHetHan,
            int nhietDoBaoQuan)
            : base(maSP, tenSP, gia, soLuongTon)
        {
            _ngayHetHan = ngayHetHan;
            _nhietDoBaoQuan = nhietDoBaoQuan;
        }
        public SanPhamThucPham() { }
        public DateTime NgayHetHan
        {
            get { return _ngayHetHan; }
            set { _ngayHetHan = value; }
        }

        public int NhietDoBaoQuan
        {
            get { return _nhietDoBaoQuan; }
            set { _nhietDoBaoQuan = value; }
        }
        public override decimal TinhGiaBan()
        {
            TimeSpan khoangCach = _ngayHetHan.Date - DateTime.Now.Date;

            if (khoangCach.TotalDays <= 3 && khoangCach.TotalDays >= 0)
            {
                return Gia * 0.7m;
            }

            return Gia;
        }
        public override string MoTa()
        {
            return $"[THỰC PHẨM] Mã: {MaSP}, " +
                   $"Tên: {TenSP}, " +
                   $"Giá gốc: {Gia:N0} VNĐ, " +
                   $"Hạn sử dụng: {NgayHetHan:dd/MM/yyyy}, " +
                   $"Nhiệt độ bảo quản: {NhietDoBaoQuan}°C, " +
                   $"Giá bán: {TinhGiaBan():N0} VNĐ";
        }
    }
    class SanPhamDienTu : SanPham
    {
        private int _baoHanhThang;
        private string _hangSanXuat;
        public SanPhamDienTu(
            string maSP,
            string tenSP,
            decimal gia,
            int soLuongTon,
            int baoHanhThang,
            string hangSanXuat)
            : base(maSP, tenSP, gia, soLuongTon)
        {
            _baoHanhThang = baoHanhThang;
            _hangSanXuat = hangSanXuat;
        }
        public SanPhamDienTu() { }
        public int BaoHanhThang
        {
            get { return _baoHanhThang; }
            set { _baoHanhThang = value; }
        }

        public string HangSanXuat
        {
            get { return _hangSanXuat; }
            set { _hangSanXuat = value; }
        }
        public override decimal TinhGiaBan()
        {
            if (_baoHanhThang > 12)
            {
                return Gia * 1.1m;
            }

            return Gia;
        }
        public override string MoTa()
        {
            return $"[ĐIỆN TỬ] Mã: {MaSP}, " +
                   $"Tên: {TenSP}, " +
                   $"Giá gốc: {Gia:N0} VNĐ, " +
                   $"Bảo hành: {BaoHanhThang} tháng, " +
                   $"Hãng sản xuất: {HangSanXuat}, " +
                   $"Giá bán: {TinhGiaBan():N0} VNĐ";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("6551071060\n");
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            List<SanPham> danhSachSanPham = new List<SanPham>
            {
                new SanPham()
                {
                    MaSP = "SP001",
                    TenSP = "Bút bi",
                    Gia = 5000,
                    SoLuongTon = 100
                },

                new SanPhamThucPham()
                {
                    MaSP = "TP001",
                    TenSP = "Sữa tươi",
                    Gia = 30000,
                    SoLuongTon = 20,
                    NgayHetHan = DateTime.Now.AddDays(2),
                    NhietDoBaoQuan = 4
                },

                new SanPhamThucPham()
                {
                    MaSP = "TP002",
                    TenSP = "Bánh quy",
                    Gia = 50000,
                    SoLuongTon = 15,
                    NgayHetHan = DateTime.Now.AddDays(30),
                    NhietDoBaoQuan = 25
                },

                new SanPhamDienTu()
                {
                    MaSP = "DT001",
                    TenSP = "Laptop",
                    Gia = 20000000,
                    SoLuongTon = 5,
                    BaoHanhThang = 24,
                    HangSanXuat = "Dell"
                },

                new SanPhamDienTu()
                {
                    MaSP = "DT002",
                    TenSP = "Chuột máy tính",
                    Gia = 300000,
                    SoLuongTon = 20,
                    BaoHanhThang = 6,
                    HangSanXuat = "Logitech"
                }
            };
            Console.WriteLine("=== DANH SÁCH SẢN PHẨM ===\n");

            foreach (SanPham sp in danhSachSanPham)
            {
                Console.WriteLine(sp.MoTa());
                Console.WriteLine($"Giá bán thực tế: {sp.TinhGiaBan():N0} VNĐ");
                Console.WriteLine($"Số lượng tồn: {sp.SoLuongTon}");
            }
            decimal tongGiaTriKho = 0;

            foreach (SanPham sp in danhSachSanPham)
            {
                tongGiaTriKho += sp.TinhGiaBan() * sp.SoLuongTon;
            }

            Console.WriteLine("\n=== TỔNG GIÁ TRỊ KHO ===");
            Console.WriteLine($"Tổng giá trị kho: {tongGiaTriKho:N0} VNĐ");
            return;
        }
    }
}

