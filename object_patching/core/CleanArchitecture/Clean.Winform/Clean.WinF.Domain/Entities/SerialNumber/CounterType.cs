using System.ComponentModel.DataAnnotations.Schema;

namespace Clean.WinF.Domain.Entities.SerialNumber
{
    [Table("CounterType")]
    public class CounterType
    {
        public long ID { get; set; }
        public string Name { get; set; }
    }
}
