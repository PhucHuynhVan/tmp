using AutoMapper;
using Clean.WinF.Applications.Features.Article.DTOs;
using Clean.WinF.Applications.Features.Bobbin.DTOs;
using Clean.WinF.Applications.Features.Computer.DTOs;
using Clean.WinF.Applications.Features.Order.DTOs;
using Clean.WinF.Applications.Features.Part.DTOs;
using Clean.WinF.Applications.Features.Protocol.DTOs;
using Clean.WinF.Applications.Features.Report.DTOs;
using Clean.WinF.Applications.Features.Setting.DTOs;
using Clean.WinF.Applications.Features.Supplier.DTOs;
using Clean.WinF.Applications.Features.Thread.DTOs;
using Clean.WinF.Applications.Features.Users.DTOs;
using Clean.WinF.Domain.Entities;
using Clean.WinF.Domain.Entities.Users;

namespace Clean.WinF.Applications.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Article, ArticleDto>();
            CreateMap<ArticleDto, Article>();

            CreateMap<Automat, AutomatDto>();
            CreateMap<AutomatDto, Automat>();

            CreateMap<SewingMachineParameter, SewingMachineParameterDto>();
            CreateMap<SewingMachineParameterDto, SewingMachineParameter>();

            CreateMap<Bobbin, BobbinDto>();
            CreateMap<BobbinDto, Bobbin>();

            CreateMap<Computer, ComputerDto>();
            CreateMap<ComputerDto, Computer>();

            CreateMap<Order, OrderDto>();
            CreateMap<OrderDto, Order>();

            CreateMap<Part, PartDto>();
            CreateMap<PartDto, Part>();

            CreateMap<Protocol, ProtocolDto>();
            CreateMap<ProtocolDto, Protocol>();

            CreateMap<Report, ReportDto>();
            CreateMap<ReportDto, Report>();

            CreateMap<Setting, SettingDto>();
            CreateMap<SettingDto, Setting>();

            CreateMap<Supplier, SupplierDto>();
            CreateMap<SupplierDto, Supplier>();

            CreateMap<Thread, ThreadDto>();
            CreateMap<ThreadDto, Thread>();

            CreateMap<Permission, PermissionDto>();
            CreateMap<PermissionDto, Permission>();

            CreateMap<Domain.Entities.Users.UserGroup, UserGroupDto>();
            CreateMap<UserGroupDto, Domain.Entities.Users.UserGroup>();

            CreateMap<User, UserDto>();
            CreateMap<UserDto, User>();
        }
    }
}
