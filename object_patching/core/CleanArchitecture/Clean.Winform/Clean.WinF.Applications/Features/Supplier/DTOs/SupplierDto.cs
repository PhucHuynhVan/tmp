using Clean.WinF.Applications.DTOs;
using System.Drawing;

namespace Clean.WinF.Applications.Features.Supplier.DTOs
{
    public class SupplierDto : BaseDTO
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Street { get; set; }
        public string Zip { get; set; }
        public string Place { get; set; }
        public string Telephone { get; set; }
        public string Fax { get; set; }
        public string Remark { get; set; }
        public Image Icon { get; set; }
        public bool IsEdit { get; set; }
        public Image StatusIcon { get; set; }
        public bool IsAdd { get; set; }

    }
}
