using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChuyenDoiNhietDo
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("6551071060");
            Console.Write("Nhập nhiệt độ Celsius: ");
            decimal celsius = decimal.Parse(Console.ReadLine());
            decimal fahrenheit = celsius * 9 / 5 + 32;
            decimal kelvin = celsius + 273.15m;
            Console.WriteLine();
            Console.WriteLine("Nhiệt độ Fahrenheit: {0:F2} °F", fahrenheit);
            Console.WriteLine("Nhiệt độ Kelvin: {0:F2} K", kelvin);
        }
    }
}
