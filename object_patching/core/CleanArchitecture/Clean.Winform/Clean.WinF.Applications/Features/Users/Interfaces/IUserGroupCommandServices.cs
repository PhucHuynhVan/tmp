using Clean.WinF.Applications.Features.Users.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Clean.WinF.Applications.Features.Users.Interfaces
{
    public interface IUserGroupCommandServices
    {
        Task<List<UserGroupDto>> ListAllAsync();
        Task<List<UserGroupDto>> GetAllById(long id);

        Task<UserGroupDto> GetById(long role_id, long permission_id);
        Task<bool> UpdateBulk(List<UserGroupDto> dtos);
        Task<bool> CreateBulk(List<UserGroupDto> dtos);
    }
}
