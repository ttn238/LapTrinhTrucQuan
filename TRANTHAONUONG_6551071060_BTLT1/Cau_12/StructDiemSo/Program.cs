using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructDiemSo
{
    struct HocSinh
    {
        public int MaSo;
        public string HoTen;
        public double DiemVan;
        public double DiemToan;
        public double DiemAnh;
    }

    class Program
    {
        static void Main(string[] args)
        {
            HocSinh[] danhSach = new HocSinh[5];

            Console.WriteLine("6551071060");
            Console.WriteLine("NHAP THONG TIN 5 HOC SINH");

            for (int i = 0; i < danhSach.Length; i++)
            {
                Console.WriteLine("\nHoc sinh thu " + (i + 1));

                Console.Write("Ma so: ");
                danhSach[i].MaSo = int.Parse(Console.ReadLine() ?? "0");

                Console.Write("Ho ten: ");
                danhSach[i].HoTen = Console.ReadLine() ?? "";

                Console.Write("Diem Van: ");
                danhSach[i].DiemVan = double.Parse(Console.ReadLine() ?? "0");

                Console.Write("Diem Toan: ");
                danhSach[i].DiemToan = double.Parse(Console.ReadLine() ?? "0");

                Console.Write("Diem Anh: ");
                danhSach[i].DiemAnh = double.Parse(Console.ReadLine() ?? "0");
            }

            double[] diemTrungBinh = new double[5];

            for (int i = 0; i < danhSach.Length; i++)
            {
                diemTrungBinh[i] =
                    (danhSach[i].DiemVan +
                     danhSach[i].DiemToan +
                     danhSach[i].DiemAnh) / 3;
            }

            int viTriCaoNhat = 0;

            for (int i = 1; i < danhSach.Length; i++)
            {
                if (diemTrungBinh[i] > diemTrungBinh[viTriCaoNhat])
                {
                    viTriCaoNhat = i;
                }
            }

            Console.WriteLine("\nHOC SINH CO DIEM TRUNG BINH CAO NHAT");
            Console.WriteLine("Ma so: " + danhSach[viTriCaoNhat].MaSo);
            Console.WriteLine("Ho ten: " + danhSach[viTriCaoNhat].HoTen);
            Console.WriteLine("Diem trung binh: " + diemTrungBinh[viTriCaoNhat].ToString("F2"));

            Console.WriteLine("\nDANH SACH HOC SINH");

            for (int i = 0; i < danhSach.Length; i++)
            {
                string xepLoai;

                if (diemTrungBinh[i] >= 8)
                {
                    xepLoai = "Gioi";
                }
                else if (diemTrungBinh[i] >= 6.5)
                {
                    xepLoai = "Kha";
                }
                else if (diemTrungBinh[i] >= 5)
                {
                    xepLoai = "TB";
                }
                else
                {
                    xepLoai = "Yeu";
                }

                Console.WriteLine(
                    "Ma so: " + danhSach[i].MaSo +
                    " | Ho ten: " + danhSach[i].HoTen +
                    " | Van: " + danhSach[i].DiemVan +
                    " | Toan: " + danhSach[i].DiemToan +
                    " | Anh: " + danhSach[i].DiemAnh +
                    " | Diem TB: " + diemTrungBinh[i].ToString("F2") +
                    " | Xep loai: " + xepLoai
                );
            }

            // struct la value type: khi gan struct cho bien khac,
            // du lieu duoc sao chep thanh mot ban sao doc lap.
            // class la reference type: khi gan class cho bien khac,
            // hai bien cung tham chieu den cung mot doi tuong.

            Console.ReadKey();
        }
    }
}