using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySachCoBan
{
    internal class Sach
    {
        private string _maSach;
        private string _tenSach;
        private string _tacGia;
        private int _namXuatBan;
        private double _giaBan;

        public Sach(string maSach, string tenSach, string tacGia, int namXuatBan, double giaBan)
        {
            _maSach = maSach;
            _tenSach = tenSach;
            _tacGia = tacGia;
            _namXuatBan = namXuatBan;
            _giaBan = giaBan;
        }

        public Sach()
        {
            _maSach = "S000";
            _tenSach = "Chưa có tên";
            _tacGia = "Chưa có tác giả";
            _namXuatBan = 2000;
            _giaBan = 0;
        }

        public string MaSach
        {
            get { return _maSach; }
        }

        public string TenSach
        {
            get { return _tenSach; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Tên sách không được để trống!");
                }

                _tenSach = value;
            }
        }
        public string TacGia
        {
            get { return _tacGia; }
            set { _tacGia = value; }
        }
        public int NamXuatBan
        {
            get { return _namXuatBan; }
            set
            {
                int namHienTai = DateTime.Now.Year;

                if (value < 1900 || value > namHienTai)
                {
                    throw new ArgumentException(
                        $"Năm xuất bản phải từ 1900 đến {namHienTai}!"
                    );
                }

                _namXuatBan = value;
            }
        }
        public double GiaBan
        {
            get { return _giaBan; }
        }
        public void HienThiThongTin()
        {
            Console.WriteLine($"Mã sách      : {_maSach}");
            Console.WriteLine($"Tên sách     : {_tenSach}");
            Console.WriteLine($"Tác giả      : {_tacGia}");
            Console.WriteLine($"Năm xuất bản : {_namXuatBan}");
            Console.WriteLine($"Giá bán      : {_giaBan:N0} VNĐ");
        }
        public override string ToString()
        {
            return $"{_maSach} - {_tenSach} - {_tacGia} - {_namXuatBan} - {_giaBan:N0} VNĐ";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("6551071060");
            Console.OutputEncoding = Encoding.UTF8;
            Sach sach1 = new Sach(
                "S001",
                "Lập trình C# cơ bản",
                "Nguyễn Văn A",
                2023,
                85000
            );
            Sach sach2 = new Sach();
            sach2.TenSach = "Cấu trúc dữ liệu và giải thuật";
            sach2.TacGia = "Trần Văn B";
            sach2.NamXuatBan = 2024;
            Sach sach3 = new Sach
            {
                TenSach = "Cơ sở dữ liệu SQL Server",
                TacGia = "Lê Văn C",
                NamXuatBan = 2025
            };

            Console.WriteLine("===== THÔNG TIN CÁC SÁCH =====");
            sach1.HienThiThongTin();
            sach2.HienThiThongTin();
            sach3.HienThiThongTin();
            Console.WriteLine("\n===== KIỂM TRA NĂM XUẤT BẢN =====");
            try
            {
                sach1.NamXuatBan = 1800;
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
            }

            try
            {
                sach1.NamXuatBan = DateTime.Now.Year + 1;
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
            }
            Console.WriteLine("\n===== KIỂM TRA TÊN SÁCH =====");

            try
            {
                sach1.TenSach = "";
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
            }
            Console.WriteLine("\n===== TOSTRING =====");
            Console.WriteLine(sach1.ToString());
            Console.WriteLine(sach2.ToString());
            Console.WriteLine(sach3.ToString());
            return; 
            
        }
    }
}
