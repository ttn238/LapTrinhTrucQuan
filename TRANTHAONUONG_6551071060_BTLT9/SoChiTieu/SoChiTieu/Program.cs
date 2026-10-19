using Serilog;
using SoChiTieu.Helpers;

namespace SoChiTieu;

internal static class Program
{
    [STAThread]
    static void Main()
    {
        try
        {
            AppConfig.Initialize();
            LogHelper.Initialize();
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            Application.ThreadException += (_, e) =>
            {
                Log.Error(e.Exception, "Lỗi UI không được xử lý");
                MessageBox.Show("Đã xảy ra lỗi. Thông tin đã được ghi vào nhật ký.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            };
            AppDomain.CurrentDomain.UnhandledException += (_, e) => Log.Fatal(e.ExceptionObject as Exception, "Lỗi nghiêm trọng");
            ApplicationConfiguration.Initialize();
            Application.Run(new FormChiTieu());
        }
        catch (Exception ex)
        {
            Log.Fatal(ex, "Không thể khởi động ứng dụng");
            MessageBox.Show("Không thể khởi động ứng dụng. Hãy kiểm tra cấu hình và kết nối SQL Server.\n\n" + ex.Message,
                "Lỗi khởi động", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally { Log.CloseAndFlush(); }
    }
}
