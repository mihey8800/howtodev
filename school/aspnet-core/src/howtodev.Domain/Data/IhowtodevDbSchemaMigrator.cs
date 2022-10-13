using System.Threading.Tasks;

namespace howtodev.Data;

public interface IhowtodevDbSchemaMigrator
{
    Task MigrateAsync();
}
