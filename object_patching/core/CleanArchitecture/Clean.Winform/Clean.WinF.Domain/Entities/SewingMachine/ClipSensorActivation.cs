using System.ComponentModel.DataAnnotations.Schema;

namespace Clean.WinF.Domain.Entities.SewingMachine
{
    [Table("ClipSenSorActivation")]
    public class ClipSenSorActivation : BaseEntity
    {
        public string Name { get; set; }
    }
}
