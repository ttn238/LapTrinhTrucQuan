// =========================================================================
// Bài 4.2 - Đăng ký hội viên phòng Gym (các control nhập liệu và ToolTip)
//
// 1. Môi trường phát triển:
//      - Framework : .NET 9.0 (Windows Forms App) - net9.0-windows
//      - Ngôn ngữ  : C#
//      - IDE       : Microsoft Visual Studio 2022
// 2. Project     : Chuong4_Bai2_GymDangKy
// 3. Tập tin     : Program.cs
// =========================================================================

namespace Chuong4_Bai2_GymDangKy
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new FormDangKy());
        }
    }
}
