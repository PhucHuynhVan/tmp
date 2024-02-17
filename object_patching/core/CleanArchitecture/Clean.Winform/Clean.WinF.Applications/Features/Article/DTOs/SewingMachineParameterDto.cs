using Clean.WinF.Applications.DTOs;

namespace Clean.WinF.Applications.Features.Article.DTOs
{
    public class SewingMachineParameterDto : BaseDTO
    {
        public ArticleDto Article { get; set; }
        public string StitchLength { get; set; }
        public string NonCriticalSection { get; set; }
        public string CriticalSection { get; set; }
        public string MinTolerance { get; set; }
        public string ReferenceTension { get; set; }
        public string MaxTolerance { get; set; }
        public string StopFilter { get; set; }
        public string StartMonitoring { get; set; }
        public string StitchForwardSeam1Front { get; set; }
        public string StitchBackwardSeam1Front { get; set; }
        public string RepetitionSeam1Front { get; set; }
        public string StitchForwardSeam2Front { get; set; }
        public string StitchBackwardSeam2Front { get; set; }
        public string RepetitionSeam2Front { get; set; }
        public string StitchForwardSeam1End { get; set; }
        public string StitchBackwardSeam1End { get; set; }
        public string RepetitionSeam1End { get; set; }
        public string StitchForwardSeam2End { get; set; }
        public string StitchBackwardSeam2End { get; set; }
        public string RepetitionSeam2End { get; set; }
        public string Description { get; set; }
    }
}
