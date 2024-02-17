using Clean.WinF.Applications.Features.Bobbin.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Clean.WinF.Applications.Features.Bobbin.Interfaces
{
    public interface IBobbinCommandServices
    {
        Task<bool> CreateBulk(List<BobbinDto> dtos);
        Task<bool> UpdateBulk(List<BobbinDto> dtos);
    }
}
