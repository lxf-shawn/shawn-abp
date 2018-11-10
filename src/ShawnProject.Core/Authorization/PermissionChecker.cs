using Abp.Authorization;
using ShawnProject.Authorization.Roles;
using ShawnProject.Authorization.Users;

namespace ShawnProject.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
