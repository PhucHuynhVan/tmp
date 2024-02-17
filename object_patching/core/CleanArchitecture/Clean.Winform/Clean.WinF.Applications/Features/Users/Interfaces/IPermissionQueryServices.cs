using Clean.WinF.Applications.Features.Users.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Clean.WinF.Applications.Features.Users.Interfaces
{
    public interface IPermissionQueryServices
    {
        Task<PermissionDto> GetById(long id);
        Task<PermissionDto> GetByName(string name);
        Task<List<PermissionDto>> GetAlls();
        Task<IEnumerable<PermissionDto>> ListAllAsync();
    }
}
