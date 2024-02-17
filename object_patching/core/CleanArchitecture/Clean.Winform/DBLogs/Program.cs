using Clean.Win.AppUI.Features;
using Clean.WinF.Applications.Features.Systems.Log;
using Clean.WinF.Common.Utilities;
using Clean.WinF.Domain.IRepository;
using Clean.WinF.Infrastructure.DBContext;
using Clean.WinF.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Serilog;
using System.Configuration;

namespace DBLogs
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            SQLiteConnection.GetSQLiteConnection = ConfigurationManager.ConnectionStrings["SQLiteDefaultConnection"].ConnectionString;

            //Implement serilog with file
            var fileName = string.Concat("Logs\\", DateTime.Now.ToString("yyyy-MM-dd"), ".log");
            Log.Logger = new LoggerConfiguration()
                        .MinimumLevel.Debug()
                        .WriteTo.File(fileName, rollingInterval: RollingInterval.Day) // write logs to a file
                        .CreateLogger();

            // Set up the SQLite sink
            var arr = CleanWinFUtility.ConvertStringToArray(SQLiteConnection.GetSQLiteConnection, "=");
            var connectionString = arr[arr.Length - 1].Replace(";", "");
            Log.Logger = new LoggerConfiguration()
                .Enrich.WithProperty("Properties", Application.ProductName)
                //.WriteTo.SQLite(connectionString, tableName: "DBLog")
                .CreateLogger();

            //apply DI container
            //register part service here
            var services = new ServiceCollection();

            services.AddDbContext<ApplicationDBContext>();
            using (var dbContext = new Clean.WinF.Infrastructure.DBContext.ApplicationDBContext())
            {
                // Execute database migrations               
                dbContext.Database.Migrate();
            }

            services.AddSingleton(typeof(IAsyncRepository<>), typeof(EFRepository<>));
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            services.AddTransient<IDBLogQueryServices, DBLogQueryServices>();

            var serviceProvider = services.BuildServiceProvider();
            IDBLogQueryServices dBLogQueryServices = serviceProvider.GetService<IDBLogQueryServices>();

            ApplicationConfiguration.Initialize();
            Application.Run(new DBLogForm(dBLogQueryServices));
        }
    }
}