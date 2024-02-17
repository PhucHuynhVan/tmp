using Clean.WinF.Applications.Features.Bobbin.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Clean.WinF.Applications.Features.Bobbin.Interfaces
{
    public interface IBobbinQueryServices
    {
        Task<BobbinDto> GetById(long id);
        Task<List<BobbinDto>> ListAllAsync();
    }
}
