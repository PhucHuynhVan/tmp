using Clean.WinF.Applications.Features.Menu.DTOs;
using Clean.WinF.Applications.Features.Menu.Interfaces;
using Clean.WinF.Domain.IRepository;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clean.WinF.Applications.Features.Menu.Services
{
    public class MenuQueryService : IMenuQueryServices
    {
        private readonly IAsyncRepository<Clean.WinF.Domain.Entities.Menus.Menu> _menuRepository;
        private readonly IUnitOfWork _unitOfWork;
        public MenuQueryService(IAsyncRepository<Clean.WinF.Domain.Entities.Menus.Menu> menuRepository, IUnitOfWork unitOfWork)
        {
            _menuRepository = menuRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<List<MenuDto>> GetAllMenus(string codeLanguage)
        {
            var result = new List<MenuDto>();

            try
            {
                IQueryable<Clean.WinF.Domain.Entities.Menus.Menu> existedMenus = null;
                existedMenus = (IQueryable<Clean.WinF.Domain.Entities.Menus.Menu>)_menuRepository.Query().Where(p => p.Languages.Equals(codeLanguage)).AsQueryable();

                if (existedMenus != null)
                {
                    foreach (var menu in existedMenus)
                    {
                        var menuDto = new MenuDto()
                        {
                            Name = menu.Name,
                            ID = menu.ID,
                            ParentName = menu.ParentName,
                            IsActive = menu.IsActive,
                            Tag = menu.Tag,
                            Desciption = menu.Desciption,
                            IconImg = menu.IconImg
                        };
                        result.Add(menuDto);
                    }

                }
            }
            catch (Exception ex)
            {
                Log.Error(string.Concat("GetAllMenus() ", ex.ToString()));
                return null;
            }

            return result;
        }
    }
}
