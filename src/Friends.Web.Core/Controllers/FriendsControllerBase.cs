using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace Friends.Controllers
{
    public abstract class FriendsControllerBase: AbpController
    {
        protected FriendsControllerBase()
        {
            LocalizationSourceName = FriendsConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
