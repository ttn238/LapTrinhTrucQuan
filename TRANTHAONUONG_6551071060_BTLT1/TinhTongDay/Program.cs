using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinhTongDay
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("6551071060");
            Console.Write("Nhập số nguyên dương n: ");
            int n = int.Parse(Console.ReadLine());
            long tong = 0;
            long tongChan = 0;
            long tongLe = 0;
            for (int i = 1; i <= n; i++) {
                tong += i;

                if (i % 2 == 0) {
                    tongChan += i;
                }
                if (i % 2 != 0) {
                    tongLe += i;
                }
            }
            long giaiThua = 1;
            int j = 1;
            while (j <= n) {
                giaiThua *= j;
                j++;
            }
            Console.WriteLine();
            Console.WriteLine("Tổng 1 + 2 + ... + n = " + tong);
            Console.WriteLine("Tổng các số chẵn từ 1 đến n = " + tongChan);
            Console.WriteLine("Tổng các số lẻ từ 1 đến n = " + tongLe);
            Console.WriteLine("Giai thừa " + n + "! = " + giaiThua);
        }
    }
}
