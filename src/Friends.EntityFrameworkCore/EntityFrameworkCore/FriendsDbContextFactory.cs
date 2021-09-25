using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Friends.Configuration;
using Friends.Web;

namespace Friends.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class FriendsDbContextFactory : IDesignTimeDbContextFactory<FriendsDbContext>
    {
        public FriendsDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<FriendsDbContext>();
            
            /*
             You can provide an environmentName parameter to the AppConfigurations.Get method. 
             In this case, AppConfigurations will try to read appsettings.{environmentName}.json.
             Use Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") method or from string[] args to get environment if necessary.
             https://docs.microsoft.com/en-us/ef/core/cli/dbcontext-creation?tabs=dotnet-core-cli#args
             */
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            FriendsDbContextConfigurer.Configure(builder, configuration.GetConnectionString(FriendsConsts.ConnectionStringName));

            return new FriendsDbContext(builder.Options);
        }
    }
}
