using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien
{
    struct SinhVien
    {
        public string MaSV;
        public string HoTen;
        public double[] Diem;
    }

    class Program
    {
        static void Main(string[] args){
            Console.WriteLine("6551071060");
            SinhVien[] danhSach = new SinhVien[5];
            Console.WriteLine("NHAP THONG TIN 5 SINH VIEN");
            for (int i = 0; i < danhSach.Length; i++){
                Console.WriteLine("\nSinh vien thu " + (i + 1));
                Console.Write("Ma SV: ");
                danhSach[i].MaSV = Console.ReadLine();
                Console.Write("Ho ten: ");
                danhSach[i].HoTen = Console.ReadLine();
                danhSach[i].Diem = new double[5];
                for (int j = 0; j < danhSach[i].Diem.Length; j++){
                    Console.Write("Diem mon " + (j + 1) + ": ");
                    danhSach[i].Diem[j] = double.Parse(Console.ReadLine());
                }
            }
            double[] diemTrungBinh = new double[5];
            for (int i = 0; i < danhSach.Length; i++){
                double tong = 0;
                for (int j = 0; j < danhSach[i].Diem.Length; j++){
                    tong += danhSach[i].Diem[j];
                }

                diemTrungBinh[i] = tong / danhSach[i].Diem.Length;
            }
            for (int i = 0; i < danhSach.Length - 1; i++){
                for (int j = 0; j < danhSach.Length - 1 - i; j++){
                    if (diemTrungBinh[j] < diemTrungBinh[j + 1]){
                        SinhVien tempSV = danhSach[j];
                        danhSach[j] = danhSach[j + 1];
                        danhSach[j + 1] = tempSV;

                        double tempDiem = diemTrungBinh[j];
                        diemTrungBinh[j] = diemTrungBinh[j + 1];
                        diemTrungBinh[j + 1] = tempDiem;
                    }
                }
            }
            Console.WriteLine("\nDANH SACH SINH VIEN");
            for (int i = 0; i < danhSach.Length; i++){
                Console.WriteLine(
                    "Hang " + (i + 1) +
                    " | Ma SV: " + danhSach[i].MaSV +
                    " | Ho ten: " + danhSach[i].HoTen +
                    " | Diem TB: " + diemTrungBinh[i].ToString("F2")
                );
            }
            Console.WriteLine("\nTIM KIEM SINH VIEN");
            Console.Write("Nhap MaSV can tim: ");
            string maCanTim = Console.ReadLine();
            int viTri = 0;
            bool timThay = false;
            while (viTri < danhSach.Length){
                if (danhSach[viTri].MaSV == maCanTim){
                    Console.WriteLine("\nMa SV: " + danhSach[viTri].MaSV);
                    Console.WriteLine("Ho ten: " + danhSach[viTri].HoTen);
                    Console.WriteLine("Diem TB: " + diemTrungBinh[viTri].ToString("F2"));
                    timThay = true;
                    break;
                }
                viTri++;
            }
            if (!timThay){
                Console.WriteLine("Khong tim thay sinh vien co MaSV = " + maCanTim);
            }
            Console.WriteLine("\nKIEM TRA MANG DIEM");
            try{
                Console.Write("Nhap vi tri mon muon xem (0 - 4): ");
                int viTriMon = int.Parse(Console.ReadLine());
                Console.WriteLine(
                    "Diem mon tai vi tri " + viTriMon +
                    " = " + danhSach[0].Diem[viTriMon]
                );
            }
            catch (IndexOutOfRangeException){
                Console.WriteLine("Loi: Vi tri nam ngoai pham vi cua mang diem!");
            }
            catch (FormatException){
                Console.WriteLine("Loi: Vi tri phai la so nguyen!");
            }
            Console.ReadKey();
        }
    }
}

