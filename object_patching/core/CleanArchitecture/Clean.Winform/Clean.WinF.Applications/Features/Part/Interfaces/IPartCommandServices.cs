using Clean.WinF.Applications.Features.Part.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Clean.WinF.Applications.Features.Part.Interfaces
{
    public interface IPartCommandServices
    {
        Task<bool> CreateBulk(List<PartDto> dtos);
        Task<bool> UpdateBulk(List<PartDto> dtos);
    }
}
