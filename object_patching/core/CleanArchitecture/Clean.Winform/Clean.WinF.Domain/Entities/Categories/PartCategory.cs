using System.ComponentModel.DataAnnotations.Schema;

namespace Clean.WinF.Domain.Entities.Categories
{
    [Table("Part_Category")]
    public class PartCategory : BaseEntity
    {
        public string SABLabel { get; set; }
        public string LabelDefinition { get; set; }
        public bool IsSelected { get; set; }
        public bool IsActive { get; set; }
    }
}
