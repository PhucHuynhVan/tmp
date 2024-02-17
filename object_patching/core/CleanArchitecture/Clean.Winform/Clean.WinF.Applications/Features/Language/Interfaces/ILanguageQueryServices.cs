using Clean.WinF.Applications.Features.Language.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Clean.WinF.Applications.Features.Language.Interfaces
{
    public interface ILanguageQueryServices
    {
        Task<List<LanguageDto>> GetAllLanguages(string displayCode);
        Task<List<AppCodeGUIDefinitionDto>> GetAllLanguagesByCodeDefinition(int appID, string codeGroup, string langCode);
        int GetApplicationIDByName(string appName);
        string GetGroupNameByCodeGroup(int appID, string codeGroupGUI);
        Task<List<LanguageDto>> GetAlls();
    }
}
