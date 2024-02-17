using Clean.WinF.Applications.DTOs;
using System;
namespace Clean.WinF.Applications.Features.Thread.DTOs
{
    public class ThreadWindingParamDto : BaseDTO
    {
        public string Name { get; set; }
        public Boolean NeedleThread { get; set; }
        public Boolean BobbinThread { get; set; }
        public string StitchesOnFullBobbin { get; set; }
        public string WindingDurationOnMachine { get; set; }
        public string Remark { get; set; }

        public String IDStr { get; set; }
    }
}
