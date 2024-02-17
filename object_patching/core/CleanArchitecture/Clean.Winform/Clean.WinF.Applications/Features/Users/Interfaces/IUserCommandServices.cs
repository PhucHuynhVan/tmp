using Clean.WinF.Applications.Features.Users.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Clean.WinF.Applications.Features.Users.Interfaces
{
    public interface IUserCommandServices
    {
        //Task<UserDto> CreateNewUser(UserDto addedUser);
        //Task<UserDto> UpdateUser(UserDto updatedUser);
        //Task<UserDto> DeleteUser(UserDto deletedUser);

        Task<UserDto> GetById(long id);
        Task<List<UserDto>> ListAllAsync();

        Task<bool> CreateBulk(List<UserDto> dtos);
        Task<bool> UpdateBulk(List<UserDto> dtos);

        Task<UserDto> login(string userId, string password);
    }
}
