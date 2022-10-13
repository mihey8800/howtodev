using howtodev.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace howtodev.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(howtodevEntityFrameworkCoreModule),
    typeof(howtodevApplicationContractsModule)
    )]
public class howtodevDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
