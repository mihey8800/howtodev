using howtodev.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace howtodev.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class howtodevController : AbpControllerBase
{
    protected howtodevController()
    {
        LocalizationResource = typeof(howtodevResource);
    }
}
