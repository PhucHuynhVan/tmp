using Clean.WinF.Applications.DTOs;

namespace Clean.WinF.Applications.Features.Users.DTOs
{
    public class UserGroupDto : BaseDTO
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public long RoleID { get; set; }
        public long PermissionID { get; set; }
        public bool IsRead { get; set; }
        public bool IsInsert { get; set; }
        public bool IsDelete { get; set; }
        public bool IsExecute { get; set; }
        public bool IsAdd { get; set; }
        public bool IsEdit { get; set; }
    }
}
