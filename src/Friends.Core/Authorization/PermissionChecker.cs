using Abp.Authorization;
using Friends.Authorization.Roles;
using Friends.Authorization.Users;

namespace Friends.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
