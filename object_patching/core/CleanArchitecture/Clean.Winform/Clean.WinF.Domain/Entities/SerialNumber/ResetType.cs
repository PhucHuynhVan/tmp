using System.ComponentModel.DataAnnotations.Schema;

namespace Clean.WinF.Domain.Entities.SerialNumber
{
    [Table("ResetType")]
    public class ResetType
    {
        public long ID { get; set; }
        public string Name { get; set; }
    }
}
