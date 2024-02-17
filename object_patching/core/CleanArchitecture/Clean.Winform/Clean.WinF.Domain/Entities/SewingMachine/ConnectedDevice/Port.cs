using System.ComponentModel.DataAnnotations.Schema;

namespace Clean.WinF.Domain.Entities.SewingMachine.ConnectedDevice
{
    [Table("Port")]
    public class Port
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
}
