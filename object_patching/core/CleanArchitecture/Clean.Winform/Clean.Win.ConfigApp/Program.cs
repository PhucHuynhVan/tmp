using Clean.Win.AppUI.Features;
using Clean.WinF.Applications.Features.Article.Interfaces;
using Clean.WinF.Applications.Features.Article.Services;
using Clean.WinF.Applications.Features.Automat.Interfaces;
using Clean.WinF.Applications.Features.Automat.Services;
using Clean.WinF.Applications.Features.Bobbin.Interfaces;
using Clean.WinF.Applications.Features.Computer.Interfaces;
using Clean.WinF.Applications.Features.Computer.Services;
using Clean.WinF.Applications.Features.Language.Interfaces;
using Clean.WinF.Applications.Features.Language.Services;
using Clean.WinF.Applications.Features.Menu.Interfaces;
using Clean.WinF.Applications.Features.Menu.Services;
using Clean.WinF.Applications.Features.Part.Interfaces;
using Clean.WinF.Applications.Features.Part.Services;
using Clean.WinF.Applications.Features.SerialNumber.Interfaces;
using Clean.WinF.Applications.Features.SerialNumber.Services;
using Clean.WinF.Applications.Features.SewingMachine.Interfaces;
using Clean.WinF.Applications.Features.SewingMachine.Services;
using Clean.WinF.Applications.Features.Supplier.Interfaces;
using Clean.WinF.Applications.Features.Supplier.Services;
using Clean.WinF.Applications.Features.SystemConfiguration.Interfaces;
using Clean.WinF.Applications.Features.SystemConfiguration.Services;
using Clean.WinF.Applications.Features.Systems.Log;
using Clean.WinF.Applications.Features.Thread.Interfaces;
using Clean.WinF.Applications.Features.Users.Interfaces;
using Clean.WinF.Applications.Features.Users.Services;
using Clean.WinF.Common.Utilities;
using Clean.WinF.Domain.IRepository;
using Clean.WinF.Infrastructure.DBContext;
using Clean.WinF.Infrastructure.Repositories;
using Clean.WinF.Infrastructure.SeedData;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Serilog;
using System;
using System.Configuration;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace Clean.Win.Apps
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

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
                .WriteTo.SQLite(connectionString, tableName: "DBLog")
                .CreateLogger();

            //apply DI container
            //register part service here
            var services = new ServiceCollection();

            services.AddDbContext<ApplicationDBContext>();
            using (var dbContext = new Clean.WinF.Infrastructure.DBContext.ApplicationDBContext())
            {
                dbContext.Database.Migrate();
            }

            services.AddSingleton(typeof(IAsyncRepository<>), typeof(EFRepository<>));
            services.AddTransient<IUnitOfWork, UnitOfWork>();

            services.AddTransient<IPartCommandServices, PartCommandServices>();
            services.AddTransient<IPartQueryServices, PartQueryServices>();

            services.AddTransient<IArticleCommandServices, ArticleCommandServices>();
            services.AddTransient<IArticleQueryServices, ArticleQueryServices>();

            services.AddTransient<IAutomatCommandServices, AutomatCommandServices>();
            services.AddTransient<IAutomatQueryServices, AutomatQueryServices>();

            services.AddTransient<ILanguageCommandServices, LanguageCommandService>();
            services.AddTransient<ILanguageQueryServices, LanguageQueryService>();

            services.AddTransient<IMenuCommandServices, MenuCommandService>();
            services.AddTransient<IMenuQueryServices, MenuQueryService>();

            services.AddTransient<ISupplierCommandServices, SupplierCommandServices>();
            services.AddTransient<ISupplierQueryServices, SupplierQueryServices>();

            services.AddTransient<IThreadCommandServices, ThreadCommandServices>();
            services.AddTransient<IThreadQueryServices, ThreadQueryServices>();

            services.AddTransient<IBobbinCommandServices, BobbinCommandServices>();
            services.AddTransient<IBobbinQueryServices, BobbinQueryServices>();

            services.AddTransient<IUserCommandServices, UserCommandServices>();
            services.AddTransient<IWindingParamCommandServices, WindingParamCommandServices>();

            services.AddTransient<IDBLogQueryServices, DBLogQueryServices>();

            services.AddTransient<IComputerCommandServices, ComputerCommandServices>();
            services.AddTransient<ISystemConfigurationCommandServices, SystemConfigurationCommandServices>();
            services.AddTransient<ISewingMachingConfigurationCommandServices, SewingMachingConfigurationCommandServices>();
            services.AddTransient<IClipSensorActivationCommandServices, ClipSensorActivationCommandServices>();
            services.AddTransient<IPortCommandServices, PortCommandServices>();
            services.AddTransient<IDeviceTypeCommandServices, DeviceTypeCommandServices>();
            services.AddTransient<IDeviceRoutingCommandServices, DeviceRoutingCommandServices>();
            services.AddTransient<IConnectedDeviceCommandServices, ConnectedDeviceCommandServices>();

            // For Serial Number
            services.AddTransient<ICounterTypeCommandServices, CounterTypeCommandServices>();
            services.AddTransient<IResetTypeCommandServices, ResetTypeCommandServices>();
            services.AddTransient<ISerialNumberCommandServices, SerialNumberCommandServices>();

            services.AddTransient<IPermissionCommandServices, PermissionCommandServices>();

            var serviceProvider = services.BuildServiceProvider();

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Apply DIs into main thread
            ILanguageCommandServices languageCommandService = serviceProvider.GetService<ILanguageCommandServices>();
            ILanguageQueryServices langQueryService = serviceProvider.GetService<ILanguageQueryServices>();

            IMenuCommandServices menuCommandService = serviceProvider.GetService<IMenuCommandServices>();
            IMenuQueryServices menuQueryService = serviceProvider.GetService<IMenuQueryServices>();

            IUserQueryServices userQueryService = serviceProvider.GetService<IUserQueryServices>();
            IUserCommandServices userCommandService = serviceProvider.GetService<IUserCommandServices>();

            IUserGroupQueryServices userGroupQueryServices = serviceProvider.GetService<IUserGroupQueryServices>();
            IUserGroupCommandServices userGroupCommandService = serviceProvider.GetService<IUserGroupCommandServices>();

            IPartCommandServices partCommandService = serviceProvider.GetService<IPartCommandServices>();
            IPartQueryServices partQueryService = serviceProvider.GetService<IPartQueryServices>();

            IArticleCommandServices articleCommandService = serviceProvider.GetService<IArticleCommandServices>();
            IArticleQueryServices articleQueryService = serviceProvider.GetService<IArticleQueryServices>();

            IAutomatCommandServices automatCommandService = serviceProvider.GetService<IAutomatCommandServices>();
            IAutomatQueryServices automatQueryService = serviceProvider.GetService<IAutomatQueryServices>();

            ISupplierCommandServices supplierCommandService = serviceProvider.GetService<ISupplierCommandServices>();
            ISupplierQueryServices supplierQueryService = serviceProvider.GetService<ISupplierQueryServices>();

            IThreadCommandServices threadCommandService = serviceProvider.GetService<IThreadCommandServices>();
            IThreadQueryServices threadQueryService = serviceProvider.GetService<IThreadQueryServices>();

            IBobbinCommandServices bobbinCommandService = serviceProvider.GetService<IBobbinCommandServices>();
            IBobbinQueryServices bobbinQueryService = serviceProvider.GetService<IBobbinQueryServices>();

            IDBLogQueryServices dBLogQueryServices = serviceProvider.GetService<IDBLogQueryServices>();
            IWindingParamCommandServices windingParamCommandServices = serviceProvider.GetService<IWindingParamCommandServices>();

            IComputerCommandServices computerCommandServices = serviceProvider.GetService<IComputerCommandServices>();
            ISystemConfigurationCommandServices systemConfigurationCommandServices = serviceProvider.GetService<ISystemConfigurationCommandServices>();

            ISewingMachingConfigurationCommandServices sewingMachingConfigurationCommandServices = serviceProvider.GetService<ISewingMachingConfigurationCommandServices>();
            IClipSensorActivationCommandServices clipSensorActivationCommandServices = serviceProvider.GetService<IClipSensorActivationCommandServices>();
            IPortCommandServices portCommandServices = serviceProvider.GetService<IPortCommandServices>();
            IDeviceTypeCommandServices deviceTypeCommandServices = serviceProvider.GetService<IDeviceTypeCommandServices>();
            IDeviceRoutingCommandServices deviceRoutingCommandServices = serviceProvider.GetService<IDeviceRoutingCommandServices>();
            IConnectedDeviceCommandServices connectedDeviceCommandServices = serviceProvider.GetService<IConnectedDeviceCommandServices>();

            ISerialNumberCommandServices serialNumberCommandServices = serviceProvider.GetService<ISerialNumberCommandServices>();
            ICounterTypeCommandServices counterTypeCommandServices = serviceProvider.GetService<ICounterTypeCommandServices>();
            IResetTypeCommandServices resetTypeCommandServices = serviceProvider.GetService<IResetTypeCommandServices>();

            IPermissionCommandServices permissionCommandServices = serviceProvider.GetService<IPermissionCommandServices>();

            //Initial seed data
            var res = new Seed(
                        menuQueryService,
                        menuCommandService,
                        langQueryService,
                        languageCommandService,
                        userQueryService,
                        userCommandService,
                        userGroupQueryServices,
                        userGroupCommandService);
            res.InitialSeedData(false);

            // Attach event handlers for catching exceptions
            Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);

            //Microsoft.Win32.SystemEvents.SessionSwitch += new Microsoft.Win32.SessionSwitchEventHandler(SystemEvents_SessionSwitch);

            mainForm = new MainForm(
                languageCommandService,
                langQueryService,
                menuCommandService,
                menuQueryService,
                userQueryService,
                userCommandService,
                partCommandService,
                partQueryService,
                articleCommandService,
                articleQueryService,
                automatCommandService,
                automatQueryService,
                supplierCommandService,
                supplierQueryService,
                threadCommandService,
                threadQueryService,
                bobbinCommandService,
                bobbinQueryService,
                dBLogQueryServices,
                windingParamCommandServices,
                computerCommandServices,
                systemConfigurationCommandServices,
                sewingMachingConfigurationCommandServices,
                clipSensorActivationCommandServices,
                portCommandServices,
                deviceTypeCommandServices,
                deviceRoutingCommandServices,
                connectedDeviceCommandServices,
                serialNumberCommandServices,
                counterTypeCommandServices,
                resetTypeCommandServices,
                permissionCommandServices);
            //Inject these above services into Mainform
            //var encryptKey = ConfigurationManager.AppSettings["EncryptionKey"];
            //var encryptIV = ConfigurationManager.AppSettings["EncryptionIV"];
            //if (CleanWinFUtility.IsExistingLicenseKey(encryptKey, encryptIV))
            //    Application.Run(mainForm);
            //else
            //Application.Run(new LicenseKeysForm());
            Application.Run(mainForm);
        }

        static CustomLogForm customForm;
        static MainForm mainForm;
        //static LicenseKeysForm licenseForm;
        static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            ShowCustomForm(e.Exception);
        }

        static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            ShowCustomForm(e.ExceptionObject as Exception);
        }

        static void ShowCustomForm(Exception ex)
        {
            if (customForm == null || customForm.IsDisposed)
            {
                customForm = new CustomLogForm(mainForm);
                customForm.OnFormClose += OnClosingForm;
            }

            Log.Error(string.Concat("Error: ", ex.Message, Environment.NewLine, ex.StackTrace, Environment.NewLine, "{@CustomValue}", Application.ProductName));
            Log.CloseAndFlush();

            customForm.richTextError.Text = ex.ToString();
            customForm.Owner = mainForm;
            customForm.ShowDialog();
        }

        static void OnClosingForm(Control subControl)
        {
            if (subControl != null)
                customForm = null;
        }

    }
}
