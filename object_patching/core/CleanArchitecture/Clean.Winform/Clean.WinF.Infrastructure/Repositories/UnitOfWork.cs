using Clean.WinF.Domain.Entities;
using Clean.WinF.Domain.Entities.Languages;
using Clean.WinF.Domain.Entities.Log;
using Clean.WinF.Domain.Entities.Menus;
using Clean.WinF.Domain.Entities.SerialNumber;
using Clean.WinF.Domain.Entities.SewingMachine;
using Clean.WinF.Domain.Entities.SewingMachine.ConnectedDevice;
using Clean.WinF.Domain.Entities.Users;
using Clean.WinF.Domain.IRepository;
using Clean.WinF.Infrastructure.DBContext;
using System;

namespace Clean.WinF.Infrastructure.Repositories
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        public string DatabaseName { get; set; }
        private ApplicationDBContext _appDBContext;
        public IAsyncRepository<Language> LanguageRepository { get; private set; }
        public IAsyncRepository<Menu> MenuRepository { get; private set; }
        public IAsyncRepository<Part> PartRepository { get; private set; }
        public IAsyncRepository<Thread> ThreadRepository { get; private set; }
        public IAsyncRepository<WindingParamter> WindingParameterRepository { get; private set; }
        public IAsyncRepository<Supplier> SupplierRepository { get; private set; }
        public IAsyncRepository<Setting> SettingRepository { get; private set; }
        public IAsyncRepository<Report> ReportRepository { get; private set; }
        public IAsyncRepository<Protocol> ProtocolRepository { get; private set; }
        public IAsyncRepository<Order> OrderRepository { get; private set; }
        public IAsyncRepository<Computer> ComputerRepository { get; private set; }
        public IAsyncRepository<Bobbin> BobbinRepository { get; private set; }
        public IAsyncRepository<Article> ArticleRepository { get; private set; }
        public IAsyncRepository<Automat> AutomatRepository { get; private set; }
        public IAsyncRepository<SewingMachineParameter> SewingMachineParameterRepository { get; private set; }
        public IAsyncRepository<User> UserRepository { get; private set; }
        public IAsyncRepository<UserGroup> UserGroupRepository { get; private set; }
        public IAsyncRepository<Permission> PermissionRepository { get; private set; }
        public IAsyncRepository<Role> RoleRepository { get; private set; }
        public IAsyncRepository<DBLog> DBLogRepository { get; private set; }
        public IAsyncRepository<ChangeOfNeedlesRecords> ChangeNeedleRecordRepository { get; private set; }
        public IAsyncRepository<ClipSenSorActivation> ClipSenSorActivationRepository { get; private set; }
        public IAsyncRepository<SewingMachineConfiguration> SewingMachineConfigurationRepository { get; private set; }
        public IAsyncRepository<SystemConfiguration> SystemConfigurationRepository { get; private set; }
        public IAsyncRepository<Port> PortRepository { get; private set; }
        public IAsyncRepository<DeviceType> DeviceTypeRepository { get; private set; }
        public IAsyncRepository<DeviceRouting> DeviceRoutingRepository { get; private set; }
        public IAsyncRepository<ConnectedDevice> ConnectedDeviceRepository { get; private set; }
        public IAsyncRepository<SerialNumber> SerialNumberRepository { get; private set; }
        public IAsyncRepository<CounterType> CounterTypeRepository { get; private set; }
        public IAsyncRepository<ResetType> ResetTypeRepository { get; private set; }
        public UnitOfWork(ApplicationDBContext appDBContext)
        {
            _appDBContext = appDBContext;
            MenuRepository = new EFRepository<Menu>(_appDBContext);
            LanguageRepository = new EFRepository<Language>(_appDBContext);
            PartRepository = new EFRepository<Part>(_appDBContext);
            ThreadRepository = new EFRepository<Thread>(_appDBContext);
            WindingParameterRepository = new EFRepository<WindingParamter>(_appDBContext);
            SupplierRepository = new EFRepository<Supplier>(_appDBContext);
            SettingRepository = new EFRepository<Setting>(_appDBContext);
            ReportRepository = new EFRepository<Report>(_appDBContext);
            ProtocolRepository = new EFRepository<Protocol>(_appDBContext);
            OrderRepository = new EFRepository<Order>(_appDBContext);
            ComputerRepository = new EFRepository<Computer>(_appDBContext);
            BobbinRepository = new EFRepository<Bobbin>(_appDBContext);
            ArticleRepository = new EFRepository<Article>(_appDBContext);
            AutomatRepository = new EFRepository<Automat>(_appDBContext);
            SewingMachineParameterRepository = new EFRepository<SewingMachineParameter>(_appDBContext);
            UserRepository = new EFRepository<User>(_appDBContext);
            UserGroupRepository = new EFRepository<UserGroup>(_appDBContext);
            PermissionRepository = new EFRepository<Permission>(_appDBContext);
            RoleRepository = new EFRepository<Role>(_appDBContext);
            DBLogRepository = new EFRepository<DBLog>(_appDBContext);
            ChangeNeedleRecordRepository = new EFRepository<ChangeOfNeedlesRecords>(_appDBContext);
            ClipSenSorActivationRepository = new EFRepository<ClipSenSorActivation>(_appDBContext);
            SewingMachineConfigurationRepository = new EFRepository<SewingMachineConfiguration>(_appDBContext);
            SystemConfigurationRepository = new EFRepository<SystemConfiguration>(_appDBContext);
            PortRepository = new EFRepository<Port>(_appDBContext);
            DeviceTypeRepository = new EFRepository<DeviceType>(_appDBContext);
            DeviceRoutingRepository = new EFRepository<DeviceRouting>(_appDBContext);
            ConnectedDeviceRepository = new EFRepository<ConnectedDevice>(_appDBContext);
            SerialNumberRepository = new EFRepository<SerialNumber>(_appDBContext);
            CounterTypeRepository = new EFRepository<CounterType>(_appDBContext);
            ResetTypeRepository = new EFRepository<ResetType>(_appDBContext);
        }

        public int Complete()
        {
            return _appDBContext.SaveChanges();
        }

        public void Dispose()
        {
            _appDBContext.Dispose();
        }
    }
}
