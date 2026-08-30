using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayTinhDonGian
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("6551071060");
            Console.Write("Nhập số a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Nhập số b: ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Kết quả các phép toán:");
            Console.WriteLine("a + b = " + (a + b));
            Console.WriteLine("a - b = " + (a - b));
            Console.WriteLine("a * b = " + (a * b));
            if (b != 0)
            {
                Console.WriteLine("a / b = " + (a / b));
                Console.WriteLine("a / b = " + ((int)a / (int)b));
                Console.WriteLine("a % b = " + ((int)a % (int)b));
            }
            else
            {
                Console.WriteLine("a / b = Không thể chia cho 0");
                Console.WriteLine("a / b = Không thể chia cho 0");
                Console.WriteLine("a % b = Không thể chia cho 0");
            }
            Console.WriteLine("a ^ b = " + Math.Pow(a, b));
        }
    }
}
