using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using PhoneGames.Configuration;
using PhoneGames.Web;

namespace PhoneGames.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class PhoneGamesDbContextFactory : IDesignTimeDbContextFactory<PhoneGamesDbContext>
    {
        public PhoneGamesDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<PhoneGamesDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            PhoneGamesDbContextConfigurer.Configure(builder, configuration.GetConnectionString(PhoneGamesConsts.ConnectionStringName));

            return new PhoneGamesDbContext(builder.Options);
        }
    }
}
