using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeThongThanhToan
{
    abstract class PhuongThucThanhToan
    {
        public string TenPhuongThuc { 
            get; 
        }
        public PhuongThucThanhToan(string tenPhuongThuc)
        {
            TenPhuongThuc = tenPhuongThuc;
        }
        public abstract decimal TinhPhiGiaoDich(decimal soTien);
        public abstract bool XacNhan();
        public void ThongTinGiaoDich(decimal soTien)
        {
            decimal phi = TinhPhiGiaoDich(soTien);
            bool xacNhan = XacNhan();
            Console.WriteLine($"Phương thức : {TenPhuongThuc}");
            Console.WriteLine($"Số tiền     : {soTien:N0} VNĐ");
            Console.WriteLine($"Phí giao dịch: {phi:N0} VNĐ");
            Console.WriteLine($"Xác nhận    : {(xacNhan ? "Thành công" : "Thất bại")}");
            Console.WriteLine($"Tổng thanh toán: {(soTien + phi):N0} VNĐ");
        }
    }
    class ThanhToanTienMat : PhuongThucThanhToan
    {
        public decimal TienKhachDua { 
            get; 
            set; 
        }
        public decimal TienThua
        {
            get
            {
                return TienKhachDua - 500000;
            }
        }
        public ThanhToanTienMat() : base("Tiền mặt") {}

        public override decimal TinhPhiGiaoDich(decimal soTien)
        {
            return 0;
        } 
        public override bool XacNhan()
        {
            return true;
        }
    } 
    class ThanhToanTheNganHang : PhuongThucThanhToan
    { 
        public string SoThe { 
            get; 
            set; 
        }
         
        public ThanhToanTheNganHang() : base("Thẻ ngân hàng") { } 
        public override decimal TinhPhiGiaoDich(decimal soTien)
        {
            return soTien * 0.015m;
        } 
        public override bool XacNhan()
        {
            Random random = new Random();
            return random.Next(0, 2) == 1;
        } 
        public string SoTheHienThi()
        {
            if (string.IsNullOrEmpty(SoThe) || SoThe.Length <= 8)
            {
                return "********";
            }

            return "********" + SoThe.Substring(8);
        }
    } 
    class ThanhToanViDienTu : PhuongThucThanhToan
    { 
        public string TenVi { 
            get; 
            set; 
        } 
        public ThanhToanViDienTu() : base("Ví điện tử") { } 
        public override decimal TinhPhiGiaoDich(decimal soTien)
        {
            decimal phi = soTien * 0.005m;

            if (phi < 2000)
            {
                phi = 2000;
            }

            return phi;
        } 
        public override bool XacNhan()
        {
            return true;
        }
    } 
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("6551071060");
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            decimal soTien = 500000; 
            PhuongThucThanhToan[] danhSach =
            {
                new ThanhToanTienMat
                {
                    TienKhachDua = 600000
                },

                new ThanhToanTheNganHang
                {
                    SoThe = "1234567812345678"
                },

                new ThanhToanViDienTu
                {
                    TenVi = "MoMo"
                }
            };  
            Console.WriteLine("HỆ THỐNG THANH TOÁN");  
            Console.WriteLine($"Hóa đơn: {soTien:N0} VNĐ\n"); 
            foreach (PhuongThucThanhToan ptt in danhSach)
            {
                ptt.ThongTinGiaoDich(soTien);
            } 
            PhuongThucThanhToan phuongThucPhiThapNhat = danhSach[0];
            decimal phiThapNhat = danhSach[0].TinhPhiGiaoDich(soTien);

            foreach (PhuongThucThanhToan ptt in danhSach)
            {
                decimal phi = ptt.TinhPhiGiaoDich(soTien);

                if (phi < phiThapNhat)
                {
                    phiThapNhat = phi;
                    phuongThucPhiThapNhat = ptt;
                }
            } 
            Console.WriteLine(" PHƯƠNG THỨC PHÍ THẤP NHẤT"); 
            Console.WriteLine($"Phương thức: {phuongThucPhiThapNhat.TenPhuongThuc}");
            Console.WriteLine($"Phí: {phiThapNhat:N0} VNĐ");
            return;
        }
    }
}
