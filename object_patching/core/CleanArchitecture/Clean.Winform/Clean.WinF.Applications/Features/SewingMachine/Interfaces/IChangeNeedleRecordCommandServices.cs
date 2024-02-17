using Clean.WinF.Applications.Features.SewingMachine.DTOs;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Clean.WinF.Applications.Features.SewingMachine.Interfaces
{
    public interface IChangeNeedleRecordCommandServices
    {
        Task<List<ChangeNeedleRecordDto>> ListAllAsync();
        Task<bool> UpdateBulk(List<ChangeNeedleRecordDto> dtos);
        Task<bool> CreateBulk(List<ChangeNeedleRecordDto> dtos);
        Task<List<ChangeNeedleRecordDto>> GetByUserIdAndMachineNumber(long user_id, int machine_number);
        Task<List<ChangeNeedleRecordDto>> GetByTimeRange(long user_id, int machine_number, DateTime start_date, DateTime end_date);
    }
}
