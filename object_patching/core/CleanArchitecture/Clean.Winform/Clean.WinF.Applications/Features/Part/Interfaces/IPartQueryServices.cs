using Clean.WinF.Applications.Features.Part.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Clean.WinF.Applications.Features.Part.Interfaces
{
    public interface IPartQueryServices
    {
        Task<PartDto> GetById(long id);
        Task<List<PartDto>> ListAllAsync();
    }
}
