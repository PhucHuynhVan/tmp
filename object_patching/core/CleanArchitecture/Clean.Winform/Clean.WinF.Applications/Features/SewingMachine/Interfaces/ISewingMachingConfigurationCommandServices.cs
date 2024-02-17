using Clean.WinF.Applications.Features.SewingMachine.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Clean.WinF.Applications.Features.SewingMachine.Interfaces
{
    public interface ISewingMachingConfigurationCommandServices
    {
        Task<List<SewingMachineConfigurationDto>> ListAllAsync();
        Task<bool> UpdateBulk(List<SewingMachineConfigurationDto> dtos);
        Task<bool> CreateBulk(List<SewingMachineConfigurationDto> dtos);
        Task<SewingMachineConfigurationDto> GetById(long id);
        Task<List<SewingMachineConfigurationDto>> GetBySewingMachineNumber(int id);
    }
}
