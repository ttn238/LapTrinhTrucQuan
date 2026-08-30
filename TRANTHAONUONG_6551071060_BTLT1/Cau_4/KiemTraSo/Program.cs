using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiemTraSo
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("6551071060");
            Console.Write("Nhập một số nguyên: ");
            int so = int.Parse(Console.ReadLine());
            if (so > 0) {
                Console.WriteLine("Số đó là số dương.");
            }
            else if (so < 0){
                Console.WriteLine("Số đó là số âm.");
            } else {
                Console.WriteLine("Số đó bằng 0.");
            } if (so % 2 == 0) {
                Console.WriteLine("Số đó là số chẵn.");
            } else {
                Console.WriteLine("Số đó là số lẻ.");
            } if (so % 3 == 0) {
                Console.WriteLine("Số đó chia hết cho 3.");
            } else {
                Console.WriteLine("Số đó không chia hết cho 3.");
            } if (so % 2 == 0 && so % 3 == 0) {
                Console.WriteLine("Số đó chia hết cho cả 2 và 3.");
            } else {
                Console.WriteLine("Số đó không chia hết cho cả 2 và 3.");
            }
        }
    }
}
