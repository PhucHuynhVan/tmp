using Clean.WinF.Applications.Features.Computer.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Clean.WinF.Applications.Features.Computer.Interfaces
{
    public interface IComputerCommandServices
    {
        Task<List<ComputerDto>> ListAllAsync();
        Task<ComputerDto> GetById(long id);
        Task<bool> UpdateBulk(List<ComputerDto> dtos);
        Task<bool> CreateBulk(List<ComputerDto> dtos);
    }
}
