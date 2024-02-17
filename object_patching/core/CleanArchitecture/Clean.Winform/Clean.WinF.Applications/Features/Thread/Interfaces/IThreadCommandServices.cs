using Clean.WinF.Applications.Features.Thread.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Clean.WinF.Applications.Features.Thread.Interfaces
{
    public interface IThreadCommandServices
    {
        //Task<List<ThreadDto>> CreateNewThread(ThreadDto addedThread);
        //Task<ThreadDto> UpdateThread(ThreadDto updatedThread);
        //Task<List<ThreadDto>> DeleteThread(ThreadDto deletedThread);

        Task<bool> CreateBulk(List<ThreadDto> dtos);
        Task<bool> UpdateBulk(List<ThreadDto> dtos);
    }
}
