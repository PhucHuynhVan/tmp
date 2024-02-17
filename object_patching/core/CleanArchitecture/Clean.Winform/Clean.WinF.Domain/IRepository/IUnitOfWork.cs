using Clean.WinF.Domain.Entities;
using Clean.WinF.Domain.Entities.Languages;
using Clean.WinF.Domain.Entities.Menus;
using Clean.WinF.Domain.Entities.SerialNumber;
using Clean.WinF.Domain.Entities.SewingMachine;
using Clean.WinF.Domain.Entities.SewingMachine.ConnectedDevice;
using Clean.WinF.Domain.Entities.Users;
using System;

namespace Clean.WinF.Domain.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        IAsyncRepository<Language> LanguageRepository { get; }
        IAsyncRepository<Menu> MenuRepository { get; }
        IAsyncRepository<Automat> AutomatRepository { get; }
        IAsyncRepository<Article> ArticleRepository { get; }
        IAsyncRepository<Bobbin> BobbinRepository { get; }
        IAsyncRepository<Computer> ComputerRepository { get; }
        IAsyncRepository<Order> OrderRepository { get; }
        IAsyncRepository<Part> PartRepository { get; }
        IAsyncRepository<Protocol> ProtocolRepository { get; }
        IAsyncRepository<Report> ReportRepository { get; }
        IAsyncRepository<Setting> SettingRepository { get; }
        IAsyncRepository<Supplier> SupplierRepository { get; }
        IAsyncRepository<Thread> ThreadRepository { get; }
        IAsyncRepository<WindingParamter> WindingParameterRepository { get; }
        IAsyncRepository<User> UserRepository { get; }
        IAsyncRepository<UserGroup> UserGroupRepository { get; }
        IAsyncRepository<Permission> PermissionRepository { get; }
        IAsyncRepository<Role> RoleRepository { get; }
        IAsyncRepository<ClipSenSorActivation> ClipSenSorActivationRepository { get; }
        IAsyncRepository<ChangeOfNeedlesRecords> ChangeNeedleRecordRepository { get; }
        IAsyncRepository<SewingMachineConfiguration> SewingMachineConfigurationRepository { get; }
        IAsyncRepository<SystemConfiguration> SystemConfigurationRepository { get; }
        IAsyncRepository<Port> PortRepository { get; }
        IAsyncRepository<DeviceType> DeviceTypeRepository { get; }
        IAsyncRepository<DeviceRouting> DeviceRoutingRepository { get; }
        IAsyncRepository<ConnectedDevice> ConnectedDeviceRepository { get; }
        IAsyncRepository<SerialNumber> SerialNumberRepository { get; }
        IAsyncRepository<CounterType> CounterTypeRepository { get; }
        IAsyncRepository<ResetType> ResetTypeRepository { get; }
        IAsyncRepository<Clean.WinF.Domain.Entities.Log.DBLog> DBLogRepository { get; }
        string DatabaseName { get; set; }
        int Complete();
    }
}
