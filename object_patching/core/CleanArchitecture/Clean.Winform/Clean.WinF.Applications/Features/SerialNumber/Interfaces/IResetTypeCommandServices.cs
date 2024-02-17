using Clean.WinF.Applications.Features.SerialNumber.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Clean.WinF.Applications.Features.SerialNumber.Interfaces
{
    public interface IResetTypeCommandServices
    {
        Task<List<ResetTypeDto>> ListAllAsync();
    }
}
