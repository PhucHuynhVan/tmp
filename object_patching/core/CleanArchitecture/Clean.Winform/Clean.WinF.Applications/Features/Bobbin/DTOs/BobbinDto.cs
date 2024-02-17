using Clean.WinF.Applications.DTOs;

namespace Clean.WinF.Applications.Features.Bobbin.DTOs
{
    public class BobbinDto : BaseDTO
    {
        public int BobbinNo { get; set; }
        public string BobbinLabel { get; set; }
        public string ThreadLabel { get; set; }
        public string StitchCount { get; set; }
        public string Machine { get; set; }
    }
}
