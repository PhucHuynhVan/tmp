using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Clean.WinF.Domain.Entities.Users
{
    [Table("users")]
    public class User
    {
        [Key]
        public long ID { get; set; }
        public Boolean IsActive { get; set; }
        public DateTime ExpiryDate { get; set; }
        public string Name { get; set; }
        public string FirstName { get; set; }
        public string Telephone { get; set; }
        public string UserID { get; set; }
        public string Password { get; set; }
        public string WinAccount01 { get; set; }
        public string WinAccount02 { get; set; }
        public Boolean LoginAllowed { get; set; }
        public Boolean FingerDataAvailable { get; set; }
        public string FirstFinger { get; set; }
        public string SecondFinger { get; set; }
        public string ThirdFinger { get; set; }
        public string UserImage { get; set; }
        public string RoleID { get; set; }
    }
}
