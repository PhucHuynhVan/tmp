using Clean.WinF.Applications.Features.Users.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Clean.WinF.Applications.Features.Users.Interfaces
{
    public interface IPermissionCommandServices
    {
        Task<List<PermissionDto>> ListAllAsync();
        Task<List<PermissionDto>> GetAllsActive();
        Task<bool> UpdateBulk(List<PermissionDto> dtos);
        Task<bool> CreateBulk(List<PermissionDto> dtos);
    }
}
