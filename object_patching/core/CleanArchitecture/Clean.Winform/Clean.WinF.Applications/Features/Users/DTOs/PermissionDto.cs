
using Clean.WinF.Applications.DTOs;

namespace Clean.WinF.Applications.Features.Users.DTOs
{
    public class PermissionDto : BaseDTO
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public bool IsAdd { get; set; }
        public bool IsEdit { get; set; }
    }
}
