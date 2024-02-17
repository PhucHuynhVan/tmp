using System;
using System.Drawing;

namespace Clean.WinF.Applications.Features.Users.DTOs
{
    public class UserDto
    {
        public int ID { get; set; }
        public bool IsActive { get; set; }
        public DateTime ExpiryDate { get; set; }
        public string Name { get; set; }
        public string FirstName { get; set; }
        public string Telephone { get; set; }
        public string UserID { get; set; }
        public string Password { get; set; }

        public RoleDto role { get; set; }
        public int RoleID { get; set; }
        public int RoleIdx { get; set; }

        public UserGroupDto userGroup { get; set; }
        public int UserGroupID { get; set; }
        public int UserGroupIdx { get; set; }

        public string WinAccount01 { get; set; }
        public string WinAccount02 { get; set; }

        public bool LoginAllowed { get; set; }
        public bool FingerDataAvailable { get; set; }
        public string FirstFinger { get; set; }
        public string SecondFinger { get; set; }
        public string ThirdFinger { get; set; }

        public string UserImage { get; set; }


        // used for gridview binding
        public Image ExpiryDateIcon { get; set; }
        public Image DeleteIcon { get; set; }
        public Image PasswordIcon { get; set; }
        public Image ChangeGroupIcon { get; set; }

        public string RoleName { get; set; }

        public void updateRole()
        {
            if (this.role != null)
            {
                this.updateRole(this.role);
            }
        }

        public void updateRole(RoleDto role)
        {
            this.role = role;
            this.RoleID = (int)role.ID;
            this.RoleName = role.Name;
        }

        public string GroupName { get; set; }

        public void updateUserGroup()
        {
            if (this.userGroup != null)
            {
                this.updateUserGroup(this.userGroup);
            }
        }

        public void updateUserGroup(UserGroupDto userGroup)
        {
            this.userGroup = userGroup;

            this.GroupName = userGroup.Name;
        }
        public bool IsAdd { get; set; }
        public bool IsUpdatePassword { get; set; }
        public bool IsUpdateGroup { get; set; }

        public string MessageRet { get; set; }

        public bool IsEdit { get; set; }
        public Image StatusIcon { get; set; }
    }
}
