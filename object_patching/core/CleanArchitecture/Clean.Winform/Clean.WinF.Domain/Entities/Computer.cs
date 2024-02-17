using System.ComponentModel.DataAnnotations.Schema;
namespace Clean.WinF.Domain.Entities
{
    [Table("Computer")]
    public class Computer
    {
        public long ID { get; set; }
        public string Name { get; set; }
        public int MachineNumber { get; set; }
        public bool IsActive { get; set; }

    }
}
