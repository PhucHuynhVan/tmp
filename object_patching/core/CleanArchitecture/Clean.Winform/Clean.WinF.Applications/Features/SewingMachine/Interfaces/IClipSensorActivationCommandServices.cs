using Clean.WinF.Applications.Features.SewingMachine.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Clean.WinF.Applications.Features.SewingMachine.Interfaces
{
    public interface IClipSensorActivationCommandServices
    {
        Task<List<ClipSensorActivationDto>> ListAllAsync();
        Task<bool> CreateBulk(List<ClipSensorActivationDto> dtos);
    }
}
