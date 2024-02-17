using System.ComponentModel.DataAnnotations.Schema;

namespace Clean.WinF.Domain.Entities.SewingMachine.ConnectedDevice
{
    [Table("DeviceType")]
    public class DeviceType
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
}
