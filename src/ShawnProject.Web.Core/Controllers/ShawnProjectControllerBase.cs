using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace ShawnProject.Controllers
{
    public abstract class ShawnProjectControllerBase: AbpController
    {
        protected ShawnProjectControllerBase()
        {
            LocalizationSourceName = ShawnProjectConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
