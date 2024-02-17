using AutoMapper;
using Clean.WinF.Applications.Features.Article.DTOs;
using Clean.WinF.Applications.Features.Bobbin.DTOs;
using Clean.WinF.Applications.Features.Computer.DTOs;
using Clean.WinF.Applications.Features.Language.DTOs;
using Clean.WinF.Applications.Features.Menu.DTOs;
using Clean.WinF.Applications.Features.Order.DTOs;
using Clean.WinF.Applications.Features.Part.DTOs;
using Clean.WinF.Applications.Features.Protocol.DTOs;
using Clean.WinF.Applications.Features.Report.DTOs;
using Clean.WinF.Applications.Features.SerialNumber.DTOs;
using Clean.WinF.Applications.Features.Setting.DTOs;
using Clean.WinF.Applications.Features.SewingMachine.DTOs;
using Clean.WinF.Applications.Features.Supplier.DTOs;
using Clean.WinF.Applications.Features.SystemConfiguration.DTOs;
using Clean.WinF.Applications.Features.Thread.DTOs;
using Clean.WinF.Applications.Features.Users.DTOs;
using Clean.WinF.Domain.Entities;
using Clean.WinF.Domain.Entities.Languages;
using Clean.WinF.Domain.Entities.Menus;
using Clean.WinF.Domain.Entities.SerialNumber;
using Clean.WinF.Domain.Entities.SewingMachine;
using Clean.WinF.Domain.Entities.SewingMachine.ConnectedDevice;
using Clean.WinF.Domain.Entities.Users;

namespace Clean.WinF.Applications.MappingProfiles
{
    public static class AutoMapperConfig
    {
        public static IMapper Configure()
        {
            var mapperConfig = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Article, ArticleDto>();
                cfg.CreateMap<ArticleDto, Article>();

                cfg.CreateMap<Automat, AutomatDto>();
                cfg.CreateMap<AutomatDto, Automat>();

                cfg.CreateMap<Bobbin, BobbinDto>();
                cfg.CreateMap<BobbinDto, Bobbin>();

                cfg.CreateMap<Computer, ComputerDto>();
                cfg.CreateMap<ComputerDto, Computer>();

                cfg.CreateMap<Order, OrderDto>();
                cfg.CreateMap<OrderDto, Order>();

                cfg.CreateMap<Part, PartDto>();
                cfg.CreateMap<PartDto, Part>();

                cfg.CreateMap<Protocol, ProtocolDto>();
                cfg.CreateMap<ProtocolDto, Protocol>();

                cfg.CreateMap<Report, ReportDto>();
                cfg.CreateMap<ReportDto, Report>();

                cfg.CreateMap<Setting, SettingDto>();
                cfg.CreateMap<SettingDto, Setting>();

                cfg.CreateMap<Supplier, SupplierDto>();
                cfg.CreateMap<SupplierDto, Supplier>();

                cfg.CreateMap<Thread, ThreadDto>();
                cfg.CreateMap<ThreadDto, Thread>();

                cfg.CreateMap<WindingParamter, ThreadWindingParamDto>();
                cfg.CreateMap<ThreadWindingParamDto, WindingParamter>();

                cfg.CreateMap<Permission, PermissionDto>();
                cfg.CreateMap<PermissionDto, Permission>();

                cfg.CreateMap<Role, RoleDto>();
                cfg.CreateMap<RoleDto, Role>();

                cfg.CreateMap<UserGroup, UserGroupDto>();
                cfg.CreateMap<UserGroupDto, UserGroup>();

                cfg.CreateMap<User, UserDto>();
                cfg.CreateMap<UserDto, User>();

                cfg.CreateMap<MenuDto, Menu>();
                cfg.CreateMap<Menu, MenuDto>();

                cfg.CreateMap<LanguageDto, Language>();
                cfg.CreateMap<Language, LanguageDto>();

                cfg.CreateMap<ChangeNeedleRecordDto, ChangeOfNeedlesRecords>();
                cfg.CreateMap<ChangeOfNeedlesRecords, ChangeNeedleRecordDto>();

                cfg.CreateMap<ClipSensorActivationDto, ClipSenSorActivation>();
                cfg.CreateMap<ClipSenSorActivation, ClipSensorActivationDto>();

                cfg.CreateMap<SewingMachineConfigurationDto, SewingMachineConfiguration>();
                cfg.CreateMap<SewingMachineConfiguration, SewingMachineConfigurationDto>();

                cfg.CreateMap<SystemConfigurationDtos, SystemConfiguration>();
                cfg.CreateMap<SystemConfiguration, SystemConfigurationDtos>();

                cfg.CreateMap<PortDto, Port>();
                cfg.CreateMap<Port, PortDto>();

                cfg.CreateMap<DeviceTypeDto, DeviceType>();
                cfg.CreateMap<DeviceType, DeviceTypeDto>();

                cfg.CreateMap<DeviceRoutingDto, DeviceRouting>();
                cfg.CreateMap<DeviceRouting, DeviceRoutingDto>();

                cfg.CreateMap<ConnectedDeviceDto, ConnectedDevice>();
                cfg.CreateMap<ConnectedDevice, ConnectedDeviceDto>();

                cfg.CreateMap<CounterTypeDto, CounterType>();
                cfg.CreateMap<CounterType, CounterTypeDto>();

                cfg.CreateMap<ResetTypeDto, ResetType>();
                cfg.CreateMap<ResetType, ResetTypeDto>();

                cfg.CreateMap<SerialNumberDto, SerialNumber>();
                cfg.CreateMap<SerialNumber, SerialNumberDto>();
            });

            IMapper mapper = mapperConfig.CreateMapper();
            return mapper;
        }
    }
}
