using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using otelRezervasyonSistem.Data;
using otelRezervasyonSistem.Forms;

namespace otelRezervasyonSistem;

static class Program
{
    private static IServiceProvider? _serviceProvider;
    private static IConfiguration? _configuration;
    private static HotelDbContext? _context;

    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();
        ConfigureServices();
        Application.Run(new MainForm());
    }

    private static void ConfigureServices()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

        _configuration = builder.Build();

        var services = new ServiceCollection();

        // Add configuration
        services.AddSingleton<IConfiguration>(_configuration);

        // Add DbContext as Singleton for Windows Forms
        var connectionString = _configuration.GetConnectionString("DefaultConnection");
        if (string.IsNullOrEmpty(connectionString))
        {
            throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
        }

        var contextOptions = new DbContextOptionsBuilder<HotelDbContext>()
            .UseSqlServer(connectionString)
            .EnableSensitiveDataLogging()
            .Options;

        _context = new HotelDbContext(contextOptions);
        services.AddSingleton(_context);

        // Configure logging
        services.AddLogging(builder =>
        {
            builder.AddConsole();
            builder.AddDebug();
        });

        _serviceProvider = services.BuildServiceProvider();
    }

    public static HotelDbContext GetDbContext()
    {
        if (_context == null)
        {
            ConfigureServices();
            if (_context == null)
            {
                throw new InvalidOperationException("Failed to initialize DbContext.");
            }
        }
        return _context;
    }
}