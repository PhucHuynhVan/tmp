using System.ComponentModel.DataAnnotations.Schema;

namespace Clean.WinF.Domain.Entities.SewingMachine
{
    [Table("SewingMachineConfiguration")]
    public class SewingMachineConfiguration : BaseEntity
    {
        public int MachineNumber { get; set; }
        public int AlternativeMachine { get; set; }
        public bool ActivatedFootLiftinCriticalSection { get; set; }
        public int MaxNoStitchesPerNeedles { get; set; }
        public string ClipSensorActivationName { get; set; }
        public int OnAfterMinStitchesminusXStitch { get; set; }
        public int StitchesAlreadySewn { get; set; }
        public int CSAStitches { get; set; }
        public int ETMLastAdjusted { get; set; }
        public string SerialNumber { get; set; }
    }
}
