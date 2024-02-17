using System.ComponentModel.DataAnnotations.Schema;

namespace Clean.WinF.Domain.Entities.Users
{
    [Table("Role")]
    public class Role : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
