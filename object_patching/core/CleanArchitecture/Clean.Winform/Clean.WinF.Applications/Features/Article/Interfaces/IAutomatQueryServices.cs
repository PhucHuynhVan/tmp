using Clean.WinF.Applications.Features.Article.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Clean.WinF.Applications.Features.Automat.Interfaces
{
    public interface IAutomatQueryServices
    {
        Task<AutomatDto> GetAutomatById(int id);
        Task<List<AutomatDto>> GetAutomatByName(string articleName);
        Task<List<AutomatDto>> GetAutomatByCode(string articleNumber);
        Task<List<AutomatDto>> GetAllAutomats();
        Task<List<AutomatDto>> ListAllAsync();
    }
}
