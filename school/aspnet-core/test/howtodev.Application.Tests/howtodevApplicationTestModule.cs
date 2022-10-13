using Volo.Abp.Modularity;

namespace howtodev;

[DependsOn(
    typeof(howtodevApplicationModule),
    typeof(howtodevDomainTestModule)
    )]
public class howtodevApplicationTestModule : AbpModule
{

}
