using System.ComponentModel.DataAnnotations.Schema;

namespace Clean.WinF.Domain.Entities
{
    [Table("SystemConfiguration")]
    public class SystemConfiguration
    {
        public long ID { get; set; }
        public string FeatureKey { get; set; }
        public string Permission { get; set; }
    }
}
