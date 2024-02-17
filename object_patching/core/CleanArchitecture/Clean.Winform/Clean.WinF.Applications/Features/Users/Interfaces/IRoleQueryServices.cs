using Clean.WinF.Applications.Features.Users.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Clean.WinF.Applications.Features.Users.Interfaces
{
    public interface IRoleQueryServices
    {
        Task<RoleDto> GetById(long id);
        Task<RoleDto> GetByName(string name);
        Task<List<RoleDto>> GetAlls();
        Task<IEnumerable<RoleDto>> ListAllAsync();
    }
}
