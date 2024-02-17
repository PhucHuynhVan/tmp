using Clean.WinF.Applications.Features.Users.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Clean.WinF.Applications.Features.Users.Interfaces
{
    public interface IRoleCommandServices
    {
        Task<List<RoleDto>> ListAllAsync();
        Task<bool> UpdateBulk(List<RoleDto> dtos);
        Task<bool> CreateBulk(List<RoleDto> dtos);
        Task<RoleDto> GetById(long id);
    }
}
