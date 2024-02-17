using Clean.WinF.Domain.Entities;
using Clean.WinF.Domain.Entities.Languages;
using Clean.WinF.Domain.Entities.Log;
using Clean.WinF.Domain.Entities.Menus;
using Clean.WinF.Domain.Entities.SerialNumber;
using Clean.WinF.Domain.Entities.SewingMachine;
using Clean.WinF.Domain.Entities.SewingMachine.ConnectedDevice;
using Clean.WinF.Domain.Entities.Users;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;

namespace Clean.WinF.Infrastructure.DBContext
{
    public class ApplicationDBContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //worked with sqlite
                string connectionString = string.Empty;
                if (!string.IsNullOrEmpty(SQLiteConnection.GetSQLiteConnection))
                {
                    //for run time
                    connectionString = SQLiteConnection.GetSQLiteConnection;
                }
                else
                {
                    //case: development run with console to apply the ef command
                    var connectionStringBuilder = new SqliteConnectionStringBuilder { DataSource = "C:\\Data\\clean_winf_db.db" };
                    connectionString = connectionStringBuilder.ToString();
                }

                var connection = new SqliteConnection(connectionString);
                optionsBuilder.UseSqlite(connection);
                optionsBuilder.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
                optionsBuilder.EnableSensitiveDataLogging();

                //work with mysql
                //var connStr = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
                //var connStr = ConfigurationManager.AppSettings["DefaultConnection"];
                //optionsBuilder.UseMySql(connStr, ServerVersion.AutoDetect(connStr), context => context.MigrationsAssembly("Clean.WinF.Infrastructure"));

                //work with SQL server                           
                //optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);

                //Access
            }
        }

        public DbSet<Order> Orders { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Thread> Threads { get; set; }
        public DbSet<WindingParamter> WindingParameters { get; set; }
        public DbSet<Report> Reports { get; set; }
        public DbSet<Setting> Settings { get; set; }
        public DbSet<Protocol> Protocols { get; set; }
        public DbSet<Part> Parts { get; set; }
        public DbSet<Bobbin> Bobbins { get; set; }
        public DbSet<Computer> Computer { get; set; }

        public DbSet<Language> Languages { get; set; }
        public DbSet<ApplicationDefinition> ApplicationDefinitions { get; set; }
        public DbSet<AppGroupGUIDefinition> AppGroupGUIDefinitions { get; set; }
        public DbSet<AppCodeGUIDefinition> AppCodeGUIDefinitions { get; set; }

        public DbSet<Menu> Menus { get; set; }
        public DbSet<DBLog> DBLogs { get; set; }

        public DbSet<Role> Role { get; set; }
        public DbSet<Permission> Permission { get; set; }
        public DbSet<UserGroup> UserGroup { get; set; }
        public DbSet<ConnectedDevice> ConnectedDevice { get; set; }
        public DbSet<DeviceRouting> DeviceRouting { get; set; }
        public DbSet<DeviceType> DeviceType { get; set; }
        public DbSet<Port> Port { get; set; }
        public DbSet<SerialNumber> SerialNumber { get; set; }
        public DbSet<CounterType> CounterType { get; set; }
        public DbSet<ResetType> ResetType { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Article>(article =>
            {
                article.HasOne<Automat>(art => art.Automat)
                .WithMany(atm => atm.Articles)
                .HasForeignKey(art => art.AutomatID)
                .IsRequired();

                article.HasOne(s => s.SewingMachineParameter)
                .WithOne(a => a.Article)
                .HasForeignKey<SewingMachineParameter>(s => s.ArticleID);
            });

            builder.Entity<Automat>().HasMany(art => art.Articles)
                .WithOne(aut => aut.Automat)
                .HasForeignKey(art => art.AutomatID)
                .OnDelete(DeleteBehavior.Cascade); ;

            builder.Entity<SewingMachineParameter>()
                .HasOne(a => a.Article)
                .WithOne(s => s.SewingMachineParameter)
                .HasForeignKey<Article>(a => a.SewingMachineParameterID);

            builder.Entity<Order>().ToTable("Order");
            builder.Entity<Supplier>().ToTable("Supplier");
            builder.Entity<Thread>().ToTable("Thread");
            builder.Entity<WindingParamter>().ToTable("WindingParamter");
            builder.Entity<Report>().ToTable("Report");
            builder.Entity<Protocol>().ToTable("Protocol");
            builder.Entity<Part>().ToTable("Part");
            builder.Entity<Bobbin>().ToTable("Bobbin");
            builder.Entity<Language>().ToTable("Language");
            builder.Entity<ApplicationDefinition>().ToTable("AppDefinition");
            builder.Entity<AppGroupGUIDefinition>().ToTable("AppGroupGUIDefinition");
            builder.Entity<AppCodeGUIDefinition>().ToTable("AppCodeGUIDefinition");
            builder.Entity<Computer>().ToTable("Computer");
            builder.Entity<ChangeOfNeedlesRecords>().ToTable("ChangeOfNeedlesRecords");
            builder.Entity<ClipSenSorActivation>().ToTable("ClipSenSorActivation");
            builder.Entity<SewingMachineConfiguration>().ToTable("SewingMachineConfiguration");
            builder.Entity<SystemConfiguration>().ToTable("SystemConfiguration");

            builder.Entity<User>().ToTable("User");
            builder.Entity<Role>().ToTable("Role");
            builder.Entity<Permission>().ToTable("Permission");

            // For Sewing Machine
            builder.Entity<ConnectedDevice>().ToTable("ConnectedDevice");
            builder.Entity<DeviceRouting>().ToTable("DeviceRouting");
            builder.Entity<DeviceType>().ToTable("DeviceType");
            builder.Entity<Port>().ToTable("Port");

            // For SerialNumber
            builder.Entity<SerialNumber>().ToTable("SerialNumber");
            builder.Entity<CounterType>().ToTable("CounterType");
            builder.Entity<ResetType>().ToTable("ResetType");

            //Menu tables
            builder.Entity<Menu>().ToTable("Menu");

            //DBLog table
            builder.Entity<DBLog>().ToTable("DBLog");

            //user relationship tables
            //apply fluent API
            // builder.Entity<ComputerConfiguration>()
            //.HasOne<Setting>(s => s.Settings)
            //.WithOne(c => c.Computers)
            //.HasForeignKey<Setting>(st => st.ComputerID);

            // builder.Entity<Setting>()
            // .HasOne<ComputerConfiguration>(c => c.Computers)
            // .WithOne(s => s.Settings)
            // .HasForeignKey<Setting>(st => st.ComputerID);

            // Thiết lập các quan hệ nếu cần
            //builder.Entity<UserGroup>()
            //    .HasOne(ug => ug.Role)
            //    .WithMany(r => r.UserGroups)
            //    .HasForeignKey(ug => ug.RoleID);

            //builder.Entity<UserGroup>()
            //    .HasOne(ug => ug.Permission)
            //    .WithMany(p => p.UserGroups)
            //    .HasForeignKey(ug => ug.PermissionID);

            //builder.Entity<User>(us =>
            //{
            //    us.HasOne<UserGroup>(ug => ug.UserGroups)
            //    .WithMany(g => g.Users)
            //    .HasForeignKey(ugr => ugr.UserGroupID)
            //    .IsRequired();
            //    us.ToTable("User");
            //});

            //builder.Entity<UserGroup>(usrgroup =>
            //{
            //usrgroup.HasMany<User>(us => us.Users)
            //.WithOne(ug => ug.UserGroups)
            //.HasForeignKey(us => us.UserGroupID)
            //.OnDelete(DeleteBehavior.Cascade);

            //    usrgroup.HasMany<Permission>(per => per.Permissions)
            //   .WithOne(ug => ug.UserGroups)
            //   .HasForeignKey(us => us.UserGroupID)
            //   .OnDelete(DeleteBehavior.Cascade);

            //    usrgroup.ToTable("UserGroup");
            //});

            //builder.Entity<Permission>(us =>
            //{
            //    us.HasOne<UserGroup>(ug => ug.UserGroup)
            //    .WithMany(g => g.Permission)
            //    .HasForeignKey(ugr => ugr.PermissionID)
            //    .IsRequired();
            //    us.ToTable("Permission");
            //});
        }
    }

    public static class SQLiteConnection
    {
        public static string GetSQLiteConnection;
    }

}
