using Clean.WinF.Applications.DTOs;

namespace Clean.WinF.Applications.Features.SewingMachine.DTOs
{
    public class ConnectedDeviceDto : BaseDTO
    {
        public string Name { get; set; }
        public DeviceRoutingDto DeviceRouting { get; set; }
        public int DeviceRoutingID { get; set; }
        public string DeviceRoutingName { get; set; }
        public DeviceTypeDto DeviceType { get; set; }
        public int DeviceTypeID { get; set; }
        public string DeviceTypeName { get; set; }
        public PortDto Port { get; set; }
        public int PortID { get; set; }
        public string PortName { get; set; }
        public string ZebraScannerSerialNumber { get; set; }
        public bool IsExit { get; set; }
        public bool IsEdit { get; set; }
        public bool IsAdd { get; set; }
    }
}
