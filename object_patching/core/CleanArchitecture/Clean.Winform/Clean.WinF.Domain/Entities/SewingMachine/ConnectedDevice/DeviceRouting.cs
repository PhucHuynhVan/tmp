using System.ComponentModel.DataAnnotations.Schema;

namespace Clean.WinF.Domain.Entities.SewingMachine.ConnectedDevice
{
    [Table("DeviceRouting")]
    public class DeviceRouting
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
}
