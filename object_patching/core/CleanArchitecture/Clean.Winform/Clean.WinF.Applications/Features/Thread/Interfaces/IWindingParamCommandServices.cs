using Clean.WinF.Applications.Features.Thread.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Clean.WinF.Applications.Features.Users.Interfaces
{
    public interface IWindingParamCommandServices
    {
        Task<ThreadWindingParamDto> GetById(long id);
        Task<List<ThreadWindingParamDto>> ListAllAsync();

        Task<bool> CreateBulk(List<ThreadWindingParamDto> dtos);
        Task<bool> UpdateBulk(List<ThreadWindingParamDto> dtos);


    }
}
