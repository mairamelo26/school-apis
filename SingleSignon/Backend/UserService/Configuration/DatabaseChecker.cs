using IdentityServer4.EntityFramework.Entities;
using JPProject.EntityFrameworkCore.MigrationHelper;
using Microsoft.Extensions.DependencyInjection;
using Serilog;
using System.Threading.Tasks;
using UserServiceDatabase.Context;

namespace UserService.Configuration
{
    public class DatabaseChecker
    {
        public static async Task EnsureDatabaseIsReady(IServiceScope serviceScope)
        {
            var services = serviceScope.ServiceProvider;
            var ssoContext = services.GetRequiredService<SsoContext>();

            Log.Information("Testing conection with database");
            await DbHealthChecker.TestConnection(ssoContext);
            Log.Information("Connection successfull");

            Log.Information("Check if database contains Client (ConfigurationDbStore) table");
            await DbHealthChecker.WaitForTable<Client>(ssoContext);

            Log.Information("Check if database contains PersistedGrant (PersistedGrantDbStore) table");
            await DbHealthChecker.WaitForTable<PersistedGrant>(ssoContext);
            Log.Information("Checks done");
        }
    }
}
