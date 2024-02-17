using System.ComponentModel.DataAnnotations.Schema;

namespace Clean.WinF.Domain.Entities.Users
{
    [Table("Permission")]
    public class Permission : BaseEntity
    {
        public string Code { get; set; }
        public string Name { get; set; }
    }
}
