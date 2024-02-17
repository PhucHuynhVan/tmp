using System;
using System.ComponentModel.DataAnnotations.Schema;
namespace Clean.WinF.Domain.Entities
{
    [Table("Thread")]
    public class Thread : BaseEntity
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Colour { get; set; }
        public string WindingParameterName { get; set; }
        public Boolean NeedleThread { get; set; }
        public Boolean BobbinThread { get; set; }
    }
}
