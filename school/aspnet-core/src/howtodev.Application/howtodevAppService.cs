using System;
using System.Collections.Generic;
using System.Text;
using howtodev.Localization;
using Volo.Abp.Application.Services;

namespace howtodev;

/* Inherit your application services from this class.
 */
public abstract class howtodevAppService : ApplicationService
{
    protected howtodevAppService()
    {
        LocalizationResource = typeof(howtodevResource);
    }
}
