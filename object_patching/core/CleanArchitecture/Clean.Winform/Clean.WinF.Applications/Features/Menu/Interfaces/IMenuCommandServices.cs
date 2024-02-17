using Clean.WinF.Applications.Features.Menu.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Clean.WinF.Applications.Features.Menu.Interfaces
{
    public interface IMenuCommandServices
    {
        Task<bool> CreateBulkMenus(IList<MenuDto> addedMenus);
        Task<bool> UpdateBulkMenus(IList<MenuDto> modifiedMenus);
    }
}
