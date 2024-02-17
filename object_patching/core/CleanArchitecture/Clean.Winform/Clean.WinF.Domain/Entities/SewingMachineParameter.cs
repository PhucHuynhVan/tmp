using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Clean.WinF.Domain.Entities
{
    [Table("SewingMachineParameter")]
    public class SewingMachineParameter : BaseEntity
    {

        [Required]
        public long ArticleID { get; set; }
        public Article Article { get; set; }

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
