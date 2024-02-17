using Clean.WinF.Applications.Features.Article.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Clean.WinF.Applications.Features.Automat.Interfaces
{
    public interface IAutomatCommandServices
    {
        Task<AutomatDto> CreateNewAutomat(AutomatDto addedAutomat);
        Task<AutomatDto> UpdateAutomat(AutomatDto updatedAutomat);
        Task<AutomatDto> DeleteAutomat(AutomatDto deletedAutomat);
        Task<bool> CreateBulkAutomats(List<AutomatDto> addedAutomats);
        Task<bool> UpdateBulkAutomats(List<AutomatDto> updatedAutomats);

    }
}
