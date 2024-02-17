using System.ComponentModel.DataAnnotations.Schema;

namespace Clean.WinF.Domain.Entities.SewingMachine
{
    [Table("ChangeOfNeedlesRecords")]
    public class ChangeOfNeedlesRecords : BaseEntity
    {
        public int MachineNumber { get; set; }
        public long UserID { get; set; }
        public int StitchCount { get; set; }
    }
}
