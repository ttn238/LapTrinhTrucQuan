using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XepLoaiHocSinh
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("6551071060");
            Console.Write("Nhập điểm trung bình: ");
            double diem = double.Parse(Console.ReadLine());
            if (diem < 0 || diem > 10) {
                Console.WriteLine("Điểm không hợp lệ!");
            }
            else if (diem >= 9.0) {
                Console.WriteLine("Xếp loại: Xuất sắc");
            }
            else if (diem >= 8.0){
                Console.WriteLine("Xếp loại: Giỏi");
            }
            else if (diem >= 6.5){
                Console.WriteLine("Xếp loại: Khá");
            }
            else if (diem >= 5.0) {
                Console.WriteLine("Xếp loại: Trung bình");
            }
            else {
                Console.WriteLine("Xếp loại: Yếu");
            }
        }
    }
}
