using howtodev.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace howtodev;

[DependsOn(
    typeof(howtodevEntityFrameworkCoreTestModule)
    )]
public class howtodevDomainTestModule : AbpModule
{

}
