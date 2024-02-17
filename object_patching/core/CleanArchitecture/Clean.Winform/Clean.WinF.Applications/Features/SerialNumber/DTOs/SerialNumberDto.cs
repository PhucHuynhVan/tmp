using System;

namespace Clean.WinF.Applications.Features.SerialNumber.DTOs
{
    public class SerialNumberDto
    {
        public long ID { get; set; }
        public string Name { get; set; }
        public string InternalName { get; set; }
        public string CounterTypeName { get; set; }
        public string ResetTypeName { get; set; }
        public long CurrentSerialNumber { get; set; }
        public DateTime ResetDate { get; set; }
        public long MaximumValue { get; set; }
        public string MessageRet { get; set; }
    }
}
