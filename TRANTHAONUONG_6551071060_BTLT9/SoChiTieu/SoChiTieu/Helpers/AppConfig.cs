using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using SoChiTieu.Models;

namespace SoChiTieu.Helpers;

public static class AppConfig
{
    public static IConfigurationRoot Configuration { get; private set; } = null!;
    public static AppSettings Settings { get; private set; } = new();
    public static string ConnectionString { get; private set; } = string.Empty;

    public static void Initialize()
    {
        var environment = Environment.GetEnvironmentVariable("DOTNET_ENVIRONMENT") ?? "Production";
        var builder = new ConfigurationBuilder()
            .SetBasePath(AppContext.BaseDirectory)
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
            .AddJsonFile($"appsettings.{environment}.json", optional: true, reloadOnChange: true);
        Configuration = builder.Build();
        ConnectionString = Configuration.GetConnectionString("DefaultConnection")
            ?? throw new InvalidOperationException("Thiếu ConnectionStrings:DefaultConnection trong appsettings.json.");
        Settings = Configuration.GetSection("AppSettings").Get<AppSettings>() ?? new AppSettings();
    }

    public static QLChiTieuContext CreateDbContext()
    {
        var options = new DbContextOptionsBuilder<QLChiTieuContext>()
            .UseSqlServer(ConnectionString, sql => sql.CommandTimeout(15)).Options;
        return new QLChiTieuContext(options);
    }
}
