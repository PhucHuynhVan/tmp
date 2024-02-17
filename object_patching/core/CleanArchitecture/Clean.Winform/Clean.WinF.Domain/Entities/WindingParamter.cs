using System;
using System.ComponentModel.DataAnnotations.Schema;
namespace Clean.WinF.Domain.Entities
{
    [Table("WindingParamter")]
    public class WindingParamter : BaseEntity
    {
        public string Name { get; set; }
        public Boolean NeedleThread { get; set; }
        public Boolean BobbinThread { get; set; }
        public string StitchesOnFullBobbin { get; set; }
        public string WindingDurationOnMachine { get; set; }
        public string Remark { get; set; }
    }
}
