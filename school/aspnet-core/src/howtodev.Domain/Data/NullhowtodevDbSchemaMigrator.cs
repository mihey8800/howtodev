using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace howtodev.Data;

/* This is used if database provider does't define
 * IhowtodevDbSchemaMigrator implementation.
 */
public class NullhowtodevDbSchemaMigrator : IhowtodevDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
