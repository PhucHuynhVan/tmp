using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Clean.WinF.Domain.Entities.Menus
{
    [Table("Menu")]
    public class Menu
    {
        [Key]
        public int ID { get; set; }
        public string ParentName { get; set; }
        [Required]
        public string Name { get; set; }
        public string Tag { get; set; }
        public string IconImg { get; set; }
        public string Desciption { get; set; }
        public string Languages { get; set; }
        public bool IsActive { get; set; }

    }
}
