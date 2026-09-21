// =========================================================================
// Bài 5.1 - Form bán hàng siêu thị mini (KeyPress, KeyDown, KeyPreview)
//
// 1. Môi trường phát triển:
//      - Framework : .NET 9.0 (Windows Forms App) - net9.0-windows
//      - Ngôn ngữ  : C#
//      - IDE       : Microsoft Visual Studio 2022
// 2. Project     : Chuong5_Cau1_FormBanHang
// 3. Tập tin     : Program.cs
// =========================================================================

namespace Chuong5_Cau1_FormBanHang
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new FormBanHang());
        }
    }
}
