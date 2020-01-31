using Abp.Authorization;
using PhoneGames.Authorization.Roles;
using PhoneGames.Authorization.Users;

namespace PhoneGames.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
