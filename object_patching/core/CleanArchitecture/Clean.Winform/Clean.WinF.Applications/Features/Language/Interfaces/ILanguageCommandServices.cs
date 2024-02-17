using Clean.WinF.Applications.Features.Language.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Clean.WinF.Applications.Features.Language.Interfaces
{
    public interface ILanguageCommandServices
    {
        Task<LanguageDto> CreateNewLanguage(LanguageDto addedLanguage);
        Task<bool> CreateBulkLanguages(IList<LanguageDto> addedLanguages);
        //Task<LanguageDto> UpdateLanguage(LanguageDto updatedLanguage);
        //Task<LanguageDto> DeleteLanguage(LanguageDto deletedLanguage);
    }
}
