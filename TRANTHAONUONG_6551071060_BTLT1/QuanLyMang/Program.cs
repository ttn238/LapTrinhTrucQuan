using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyMang{
    class Program{
        static void Main(string[] args){
            Console.WriteLine("6551071060");
            int[] mang = new int[10];
            Console.WriteLine("NHAP 10 PHAN TU:");
            for (int i = 0; i < mang.Length; i++){
                Console.Write("mang[" + i + "] = ");
                mang[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("\nTOAN BO MANG:");
            foreach (int x in mang){
                Console.Write(x + " ");
            }
            int tong = 0;
            foreach (int x in mang){
                tong += x;
            }
            double trungBinh = (double)tong / mang.Length;
            Console.WriteLine("\n\nTong = " + tong);
            Console.WriteLine("Trung binh = " + trungBinh);
            int lonNhat = mang[0];
            int nhoNhat = mang[0];
            int viTriLonNhat = 0;
            int viTriNhoNhat = 0;
            for (int i = 1; i < mang.Length; i++){
                if (mang[i] > lonNhat){
                    lonNhat = mang[i];
                    viTriLonNhat = i;
                }
                if (mang[i] < nhoNhat){
                    nhoNhat = mang[i];
                    viTriNhoNhat = i;
                }
            }

            Console.WriteLine("\nLon nhat = " + lonNhat);
            Console.WriteLine("Vi tri = " + viTriLonNhat);
            Console.WriteLine("\nNho nhat = " + nhoNhat);
            Console.WriteLine("Vi tri = " + viTriNhoNhat);
            int soChan = 0;
            int soLe = 0;
            foreach (int x in mang){
                if (x % 2 == 0) {
                    soChan++;
                }else{
                    soLe++;
                }
            }

            Console.WriteLine("\nSo phan tu chan = " + soChan);
            Console.WriteLine("So phan tu le = " + soLe);
            Console.WriteLine("\nMang sau khi dao nguoc:");
            for (int i = mang.Length - 1; i >= 0; i--) {
                Console.Write(mang[i] + " ");
            }

            Console.WriteLine();
        }
    }
}