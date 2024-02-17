using Clean.WinF.Applications.DTOs;
using System;
using System.Drawing;

namespace Clean.WinF.Applications.Features.Thread.DTOs
{
    public class ThreadDto : BaseDTO
    {
        public string Code { get; set; }

        public string Name { get; set; }

        public int WindingParamIdx { get; set; }

        public ThreadWindingParamDto WindingParam { get; set; }

        public string Colour { get; set; }

        // 
        public string WindingParameterName { get; set; }
        public Boolean NeedleThread { get; set; }
        public Boolean BobbinThread { get; set; }
        public string StitchesOnFullBobbin { get; set; }
        public string WindingDurationOnMachine { get; set; }
        public string Remark { get; set; }
        public Image Icon { get; set; }

        public void updateWindingParam()
        {
            if (this.WindingParam != null)
            {
                this.updateWindingParam(this.WindingParam);
            }
        }

        public void updateWindingParam(ThreadWindingParamDto windingParam)
        {
            this.WindingParam = windingParam;

            this.WindingParameterName = windingParam.Name;
            this.NeedleThread = windingParam.NeedleThread;
            this.BobbinThread = windingParam.BobbinThread;
            this.StitchesOnFullBobbin = windingParam.StitchesOnFullBobbin;
            this.WindingDurationOnMachine = windingParam.WindingDurationOnMachine;
            this.Remark = windingParam.Remark;
        }

        public bool IsEdit { get; set; }
        public Image StatusIcon { get; set; }
        public bool IsAdd { get; set; }
    }
}
