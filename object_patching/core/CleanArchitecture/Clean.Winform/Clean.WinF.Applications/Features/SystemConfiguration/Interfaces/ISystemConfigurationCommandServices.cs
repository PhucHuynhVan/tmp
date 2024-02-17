using Clean.WinF.Applications.Features.SystemConfiguration.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Clean.WinF.Applications.Features.SystemConfiguration.Interfaces
{
    public interface ISystemConfigurationCommandServices
    {
        Task<List<SystemConfigurationDtos>> ListAllAsync();
        Task<SystemConfigurationDtos> GetByFeatureKey(string key);
        Task<bool> UpdateBulk(List<SystemConfigurationDtos> dtos);
        Task<bool> CreateBulk(List<SystemConfigurationDtos> dtos);
    }
}
