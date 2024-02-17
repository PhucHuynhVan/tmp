using System.ComponentModel.DataAnnotations.Schema;
namespace Clean.WinF.Domain.Entities
{
    [Table("Bobbin")]
    public class Bobbin : BaseEntity
    {
        public int BobbinNo { get; set; }
        public string BobbinLabel { get; set; }
        public string ThreadLabel { get; set; }
        public string StitchCount { get; set; }
        public string Machine { get; set; }
    }
}
