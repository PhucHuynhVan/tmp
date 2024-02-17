using Clean.WinF.Applications.Features.Setting.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Clean.WinF.Applications.Features.Setting.Interfaces
{
    public interface IBobbinCommandServices
    {
        Task<List<SettingDto>> CreateNewSetting(SettingDto addedSetting);
        Task<SettingDto> UpdateSetting(SettingDto updatedSetting);
        Task<List<SettingDto>> DeleteSetting(SettingDto deletedSetting);
    }
}
