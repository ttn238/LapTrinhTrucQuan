// =========================================================================
// Bài 4.4 - Quản lý phòng khám mini (ứng dụng MDI nhiều cửa sổ con)
//
// 1. Môi trường phát triển:
//      - Framework : .NET 9.0 (Windows Forms App) - net9.0-windows
//      - Ngôn ngữ  : C#
//      - IDE       : Microsoft Visual Studio 2022
// 2. Project     : Chuong4_Bai4_PhongKhamMDI
// 3. Tập tin     : Program.cs
// =========================================================================

namespace Chuong4_Bai4_PhongKhamMDI
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new frmParent());
        }
    }
}
