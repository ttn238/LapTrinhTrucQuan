// =========================================================================
// Bài 5.2 - Bảng vẽ mini (sự kiện chuột và sự kiện Paint)
//
// 1. Môi trường phát triển:
//      - Framework : .NET 9.0 (Windows Forms App) - net9.0-windows
//      - Ngôn ngữ  : C#
//      - IDE       : Microsoft Visual Studio 2022
// 2. Project     : Chuong5_Cau2_BangVeMini
// 3. Tập tin     : Program.cs
// =========================================================================

namespace Chuong5_Cau2_BangVeMini
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new FormBangVe());
        }
    }
}
