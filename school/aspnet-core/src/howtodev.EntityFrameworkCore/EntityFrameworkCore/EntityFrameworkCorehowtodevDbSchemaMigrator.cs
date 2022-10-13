using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using howtodev.Data;
using Volo.Abp.DependencyInjection;

namespace howtodev.EntityFrameworkCore;

public class EntityFrameworkCorehowtodevDbSchemaMigrator
    : IhowtodevDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCorehowtodevDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the howtodevDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<howtodevDbContext>()
            .Database
            .MigrateAsync();
    }
}
