using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BangCuuChuong
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("6551071060");
            int n;
            do {
                Console.Write("Nhập số n (1 - 9): ");
                n = int.Parse(Console.ReadLine());
                if (n < 1 || n > 9) {
                    Console.WriteLine("Lỗi! Vui lòng nhập số từ 1 đến 9.");
                }
            } while (n < 1 || n > 9);
            Console.WriteLine();
            Console.WriteLine("Bảng cửu chương của " + n + ":");
            for (int i = 1; i <= 10; i++) {
                Console.WriteLine(n + " × " + i + " = " + (n * i));
            }
        }
    }
}
