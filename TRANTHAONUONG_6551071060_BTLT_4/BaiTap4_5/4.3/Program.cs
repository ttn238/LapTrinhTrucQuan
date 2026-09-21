// =========================================================================
// Bài 4.3 - Danh sách việc cần làm (ListBox và ContextMenuStrip)
//
// 1. Môi trường phát triển:
//      - Framework : .NET 9.0 (Windows Forms App) - net9.0-windows
//      - Ngôn ngữ  : C#
//      - IDE       : Microsoft Visual Studio 2022
// 2. Project     : Chuong4_Bai3_ToDoList
// 3. Tập tin     : Program.cs
// =========================================================================

namespace Chuong4_Bai3_ToDoList
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new FormToDo());
        }
    }
}
