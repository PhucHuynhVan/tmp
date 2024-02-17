using Clean.WinF.Applications.Features.Menu.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Clean.WinF.Applications.Features.Menu.Interfaces
{
    public interface IMenuQueryServices
    {
        Task<List<MenuDto>> GetAllMenus(string codeLanguage);
    }
}
