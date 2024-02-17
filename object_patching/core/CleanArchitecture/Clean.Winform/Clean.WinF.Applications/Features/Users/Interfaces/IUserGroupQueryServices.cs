using Clean.WinF.Applications.Features.Users.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Clean.WinF.Applications.Features.Users.Interfaces
{
    public interface IUserGroupQueryServices
    {
        Task<UserGroupDto> GetUserGroupById(int id);
        Task<UserGroupDto> GetUserGroupByName(string name);
        Task<List<UserGroupDto>> GetAllUserGroups();
        Task<IEnumerable<UserGroupDto>> ListAllAsync();
    }
}
