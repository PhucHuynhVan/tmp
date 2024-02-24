using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Clean.WinF.Domain.Entities
{
    [Table("Article")]
    public class Article : BaseEntity
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Endlabel { get; set; }
        public string Version { get; set; }
        public string Description { get; set; }

        public long? SewingMachineParameterID { get; set; }
        public SewingMachineParameter SewingMachineParameter { get; set; }

        [Required]
        public long AutomatID { get; set; }
        public long? FabricLeather1ID { get; set; }
        public long? FabricLeather2ID { get; set; }
        public long? FabricLeather3ID { get; set; }
        public long? FabricLeather4ID { get; set; }
        public long? FabricLeather5ID { get; set; }
        public long? UpperThreadID { get; set; }
        public long? LowerThreadID { get; set; }
        public Automat Automat { get; set; }



        public string StitchLength { get; set; }
        public string Label { get; set; }
        public string LabelDefinition { get; set; }
        public string FreeSeamCountStart { get; set; }
        public string MaxStitchesFreeSeam { get; set; }
        public string SeamProfile { get; set; }
        public string MaxSpeedCritSection { get; set; }
        public string MaxSpeedNotCritSection { get; set; }
        public string Section1Reference { get; set; }
        public string Section1Min { get; set; }
        public string Section1Max { get; set; }
        public bool Section1TolErrAllowed { get; set; }
        public string Section1StitchLength { get; set; }
        public string Section1StepForw { get; set; }
        public string Section1StepBackw { get; set; }
        public string Section1SL { get; set; }
        public string Section1Steps { get; set; }
        public string Section2Reference { get; set; }
        public string Section2Min { get; set; }
        public string Section2Max { get; set; }
        public bool Section2TolErrAllowed { get; set; }
        public string Section2StitchLength { get; set; }
        public string Section2StepForw { get; set; }
        public string Section2StepBackw { get; set; }
        public string Section2SL { get; set; }
        public string Section2Steps { get; set; }
        public string Section3Reference { get; set; }
        public string Section3Min { get; set; }
        public string Section3Max { get; set; }
        public bool Section3TolErrAllowed { get; set; }
        public string Section3StitchLength { get; set; }
        public string Section3StepForw { get; set; }
        public string Section3StepBackw { get; set; }
        public string Section3SL { get; set; }
        public string Section3Steps { get; set; }
        public string Section4Reference { get; set; }
        public string Section4Min { get; set; }
        public string Section4Max { get; set; }
        public bool Section4TolErrAllowed { get; set; }
        public string Section4StitchLength { get; set; }
        public string Section4StepForw { get; set; }
        public string Section4StepBackw { get; set; }
        public string Section4SL { get; set; }
        public string Section4Steps { get; set; }
        public string Section5Reference { get; set; }
        public string Section5Min { get; set; }
        public string Section5Max { get; set; }
        public bool Section5TolErrAllowed { get; set; }
        public string Section5StitchLength { get; set; }
        public string Section5StepForw { get; set; }
        public string Section5StepBackw { get; set; }
        public string Section5SL { get; set; }
        public string Section5Steps { get; set; }
        public string SeamStart { get; set; }
        public string SeamEnd { get; set; }
        public string EndlabelSeamMaxStiche { get; set; }
        public string EndlabelSeamSL { get; set; }
        public string EndlabelSeamSteps { get; set; }
        public string EndlabelStepsBack { get; set; }
        public string FabricLeather1Batch { get; set; }
        public string FabricLeather1MaterialCode { get; set; }
        public string FabricLeather1MaterialName { get; set; }
        public string FabricLeather2Batch { get; set; }
        public string FabricLeather2MaterialCode { get; set; }
        public string FabricLeather2MaterialName { get; set; }
        public string FabricLeather3Batch { get; set; }
        public string FabricLeather3MaterialCode { get; set; }
        public string FabricLeather3MaterialName { get; set; }
        public string FabricLeather4Batch { get; set; }
        public string FabricLeather4MaterialCode { get; set; }
        public string FabricLeather4MaterialName { get; set; }
        public string FabricLeather5Batch { get; set; }
        public string FabricLeather5MaterialCode { get; set; }
        public string FabricLeather5MaterialName { get; set; }
        public string UpperThreadMaterialCode { get; set; }
        public string UpperThreadInfo1 { get; set; }
        public string UpperThreadInfo2 { get; set; }
        public string UpperThreadMaterialName { get; set; }
        public string LowerThreadMaterialCode { get; set; }
        public string LowerThreadInfo1 { get; set; }
        public string LowerThreadInfo2 { get; set; }
        public string LowerThreadMaterialName { get; set; }
        public string ThreadTensionId { get; set; }
        public string ThreadTensionMonitoringType { get; set; }
        public string ThreadTensionSeam1Reference { get; set; }
        public string ThreadTensionSeam1Min { get; set; }
        public string ThreadTensionSeam1Max { get; set; }
        public string ThreadTensionSeam1StopFilter { get; set; }
        public string ThreadTensionSeam1StartMonitoring { get; set; }
        public string ThreadTensionSeam2Reference { get; set; }
        public string ThreadTensionSeam2Min { get; set; }
        public string ThreadTensionSeam2Max { get; set; }
        public string ThreadTensionSeam2StopFilter { get; set; }
        public string ThreadTensionSeam2StartMonitoring { get; set; }
        public string BacktackStartSeam1Forward { get; set; }
        public string BacktackStartSeam1Backward { get; set; }
        public string BacktackStartSeam1Repetition { get; set; }
        public string BacktackEndSeam1Forward { get; set; }
        public string BacktackEndSeam1Backward { get; set; }
        public string BacktackEndSeam1Repetition { get; set; }
        public string BacktackStartSeam2Forward { get; set; }
        public string BacktackStartSeam2Backward { get; set; }
        public string BacktackStartSeam2Repetition { get; set; }
        public string BacktackEndSeam2Forward { get; set; }
        public string BacktackEndSeam2Backward { get; set; }
        public string BacktackEndSeam2Repetition { get; set; }
        public string MiscellaneousInfo1 { get; set; }
        public string MiscellaneousInfo2 { get; set; }
        public string MiscellaneousInfo3 { get; set; }
        public string MiscellaneousInfo4 { get; set; }
        public string MiscellaneousInfo5 { get; set; }
        public string MiscellaneousInfo6 { get; set; }
        public string MiscellaneousInfo7 { get; set; }

        public string BacktackStartFreeSeamForward { get; set; }
        public string BacktackStartFreeSeamBackward { get; set; }

        public string BacktackEndFreeSeamForward { get; set; }
        public string BacktackEndFreeSeamBackward { get; set; }

        public string BacktackStartSABSeamForward { get; set; }
        public string BacktackStartSABSeamBackward { get; set; }

        public string BacktackEndSABSeamForward { get; set; }
        public string BacktackEndSABSeamBackward { get; set; }


        public string BacktackStartEndlabelSeamForward { get; set; }
        public string BacktackStartEndlabelSeamBackward { get; set; }

        public string BacktackEndEndlabelSeamForward { get; set; }
        public string BacktackEndEndlabelSeamBackward { get; set; }

        public string MonitoringFreeSeam { get; set; }
        public string MonitoringSeaction1 { get; set; }
        public string MonitoringSeaction3 { get; set; }
        public string MonitoringEndlabelSeam { get; set; }

    }
}
