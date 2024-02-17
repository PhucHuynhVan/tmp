using Clean.WinF.Applications.Features.SerialNumber.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Clean.WinF.Applications.Features.SerialNumber.Interfaces
{
    public interface ISerialNumberCommandServices
    {
        Task<List<SerialNumberDto>> ListAllAsync();
        Task<bool> UpdateBulk(List<SerialNumberDto> dtos);
        Task<SerialNumberDto> GetById(long id);
    }
}
