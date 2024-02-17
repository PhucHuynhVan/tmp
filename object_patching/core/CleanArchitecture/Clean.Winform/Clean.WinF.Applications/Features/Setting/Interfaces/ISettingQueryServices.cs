using Clean.WinF.Applications.Features.Setting.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Clean.WinF.Applications.Features.Setting.Interfaces
{
    public interface ISettingQueryServices
    {
        Task<SettingDto> GetSettingById(int id);
        Task<List<SettingDto>> GetSettingByName(string computerName);
        Task<List<SettingDto>> GetAllSettings();
        Task<IEnumerable<SettingDto>> ListAllAsync();
    }
}
