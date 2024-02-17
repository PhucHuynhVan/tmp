using Clean.WinF.Applications.DTOs;
using System.Drawing;


namespace Clean.WinF.Applications.Features.SewingMachine.DTOs
{
    public class SewingMachineConfigurationDto : BaseDTO
    {
        public int MachineNumber { get; set; }
        public int AlternativeMachine { get; set; }
        public int MaxNoStitchesPerNeedles { get; set; }
        public bool ActivatedFootLiftinCriticalSection { get; set; }
        public ClipSensorActivationDto ClipSenserActivation { get; set; }
        public long ClipSenserActivationId { get; set; }
        public int ClipSenserActivationIdx { get; set; }
        public string ClipSensorActivationName { get; set; }
        public int OnAfterMinStitchesminusXStitch { get; set; }
        public int StitchesAlreadySewn { get; set; }
        public int CSAStitches { get; set; }
        public int ETMLastAdjusted { get; set; }
        public string SerialNumber { get; set; }
        public bool IsEdit { get; set; }
        public Image StatusIcon { get; set; }
        public Image Icon { get; set; }
        public bool IsAdd { get; set; }
        public void updateClipSensorInput()
        {
            if (this.ClipSenserActivation != null)
            {
                this.updateClipSensorInput(this.ClipSenserActivation);
            }
        }

        public void updateClipSensorInput(ClipSensorActivationDto clipSensorInput)
        {
            this.ClipSenserActivation = clipSensorInput;

            this.ClipSensorActivationName = clipSensorInput.Name;
        }
    }
}
