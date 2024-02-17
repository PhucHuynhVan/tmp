using Clean.WinF.Applications.Features.SewingMachine.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Clean.WinF.Applications.Features.SewingMachine.Interfaces
{
    public interface IConnectedDeviceCommandServices
    {
        Task<List<ConnectedDeviceDto>> ListAllAsync();
        Task<bool> UpdateBulk(List<ConnectedDeviceDto> dtos);
    }
}
