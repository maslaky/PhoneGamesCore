using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace PhoneGames.Controllers
{
    public abstract class PhoneGamesControllerBase: AbpController
    {
        protected PhoneGamesControllerBase()
        {
            LocalizationSourceName = PhoneGamesConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
