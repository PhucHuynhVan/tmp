using System.ComponentModel.DataAnnotations.Schema;

namespace Clean.WinF.Domain.Entities.SewingMachine.ConnectedDevice
{
    [Table("ConnectedDevice")]
    public class ConnectedDevice
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int DeviceRoutingID { get; set; }
        public int DeviceTypeID { get; set; }
        public int PortID { get; set; }
        public string ZebraScannerSerialNumber { get; set; }
        public bool IsExit { get; set; }
    }
}
