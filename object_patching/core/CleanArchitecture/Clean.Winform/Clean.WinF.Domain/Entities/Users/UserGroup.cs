using System.ComponentModel.DataAnnotations.Schema;

namespace Clean.WinF.Domain.Entities.Users
{
    [Table("UserGroup")]
    public class UserGroup
    {
        public long ID { get; set; }
        public long RoleID { get; set; }
        public long PermissionID { get; set; }
        public bool IsRead { get; set; }
        public bool IsInsert { get; set; }
        public bool IsDelete { get; set; }
        public bool IsExecute { get; set; }
        public bool IsActive { get; set; }

    }
}
