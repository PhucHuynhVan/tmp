using System.ComponentModel.DataAnnotations.Schema;

namespace Clean.WinF.Domain.Entities
{
    [Table("Supplier")]
    public class Supplier : BaseEntity
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Street { get; set; }
        public string Zip { get; set; }
        public string Place { get; set; }
        public string Telephone { get; set; }
        public string Fax { get; set; }
        public string Remark { get; set; }
    }
}
