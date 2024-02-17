using Clean.WinF.Applications.Features.Menu.DTOs;
using Clean.WinF.Applications.Features.Menu.Interfaces;
using Clean.WinF.Applications.MappingProfiles;
using Clean.WinF.Domain.IRepository;
using Serilog;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Clean.WinF.Applications.Features.Menu.Services
{
    public class MenuCommandService : IMenuCommandServices
    {
        private readonly IAsyncRepository<Clean.WinF.Domain.Entities.Menus.Menu> _menuRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly AutoMapper.IMapper _mapper;
        public MenuCommandService(IAsyncRepository<Clean.WinF.Domain.Entities.Menus.Menu> menuRepository,
            IUnitOfWork unitOfWork)
        {
            _menuRepository = menuRepository;
            _unitOfWork = unitOfWork;
            _mapper = AutoMapperConfig.Configure();
        }

        public async Task<bool> CreateBulkMenus(IList<MenuDto> addMenus)
        {
            var result = true;
            try
            {
                if (addMenus != null)
                {
                    var bulkMenus = new List<Domain.Entities.Menus.Menu>();
                    foreach (var menuDto in addMenus)
                    {
                        var menuEntity = _mapper.Map<MenuDto, Domain.Entities.Menus.Menu>(menuDto);
                        bulkMenus.Add(menuEntity);
                    }

                    if (bulkMenus != null && bulkMenus.Count > 0)
                        result = await _unitOfWork.MenuRepository.AddBulkEntitiesAsync(bulkMenus);
                }
            }
            catch (Exception ex)
            {
                Log.Error($"CreateBulkMenus() error: {ex.ToString()}");
                return result;
            }

            return result;
        }

        public async Task<bool> UpdateBulkMenus(IList<MenuDto> updatedMenus)
        {
            var result = true;
            try
            {
                if (updatedMenus != null)
                {
                    var bulkMenus = new List<Domain.Entities.Menus.Menu>();
                    foreach (var menuDto in updatedMenus)
                    {
                        var menu = new Domain.Entities.Menus.Menu
                        {
                            ID = menuDto.ID,
                            Name = menuDto.Name,
                            IconImg = menuDto.IconImg,
                            Tag = menuDto.Tag,
                            Desciption = menuDto.Desciption,
                            ParentName = menuDto.ParentName,
                            IsActive = menuDto.IsActive
                        };
                        bulkMenus.Add(menu);
                    }

                    if (bulkMenus != null && bulkMenus.Count > 0)
                        result = await _unitOfWork.MenuRepository.UpdateBulkEntitiesAsync(bulkMenus);
                }
            }
            catch (Exception ex)
            {
                Log.Error($"UpdateBulkMenus() error: {ex.ToString()}");
                return result;
            }

            return result;
        }
    }
}
