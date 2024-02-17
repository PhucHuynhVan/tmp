
using Clean.WinF.Applications.DTOs;

namespace Clean.WinF.Applications.Features.Users.DTOs
{
    public class RoleDto : BaseDTO
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsAdd { get; set; }
        public bool IsEdit { get; set; }
    }
}