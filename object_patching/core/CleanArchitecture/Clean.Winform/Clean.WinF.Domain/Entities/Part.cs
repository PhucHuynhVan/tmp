using System.ComponentModel.DataAnnotations.Schema;

namespace Clean.WinF.Domain.Entities
{
    [Table("Part")]
    public class Part : BaseEntity
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Info1 { get; set; }
        public string Info2 { get; set; }
        public string Info3 { get; set; }
        public string Info4 { get; set; }
        public string Info5 { get; set; }
        public string SABLabel { get; set; }
        public string LabelDefinition { get; set; }
    }
}
