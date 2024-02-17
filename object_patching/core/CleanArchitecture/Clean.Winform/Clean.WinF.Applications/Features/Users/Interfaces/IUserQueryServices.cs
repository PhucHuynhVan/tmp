using Clean.WinF.Applications.Features.Users.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Clean.WinF.Applications.Features.Users.Interfaces
{
    public interface IUserQueryServices
    {
        Task<UserDto> GetUserById(int id);
        Task<UserDto> GetUserByName(string name);
        Task<UserDto> GetUserNameAndPassword(string name, string pass);
        Task<List<UserDto>> GetAllUsers();
        Task<IEnumerable<UserDto>> ListAllAsync();
    }
}
