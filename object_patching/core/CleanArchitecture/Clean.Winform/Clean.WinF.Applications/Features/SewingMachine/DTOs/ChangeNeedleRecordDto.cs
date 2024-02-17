using Clean.WinF.Applications.DTOs;

namespace Clean.WinF.Applications.Features.SewingMachine.DTOs
{
    public class ChangeNeedleRecordDto : BaseDTO
    {
        public int StitchCount { get; set; }
        public long UserID { get; set; }
        public int MachineNumber { get; set; }
    }
}
