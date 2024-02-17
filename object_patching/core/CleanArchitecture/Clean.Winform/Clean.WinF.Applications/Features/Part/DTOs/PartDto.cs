using Clean.WinF.Applications.DTOs;
using System.Drawing;

namespace Clean.WinF.Applications.Features.Part.DTOs
{
    public class PartDto : BaseDTO
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public bool IsUpdated { get; set; }
        public bool IsCreated { get; set; }
        public bool IsDeleted { get; set; }

        public bool IsEdit { get; set; }
        public Image StatusIcon { get; set; }
        public bool IsAdd { get; set; }
    }
}
