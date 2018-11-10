using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using ShawnProject.Configuration;
using ShawnProject.Web;

namespace ShawnProject.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class ShawnProjectDbContextFactory : IDesignTimeDbContextFactory<ShawnProjectDbContext>
    {
        public ShawnProjectDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<ShawnProjectDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            ShawnProjectDbContextConfigurer.Configure(builder, configuration.GetConnectionString(ShawnProjectConsts.ConnectionStringName));

            return new ShawnProjectDbContext(builder.Options);
        }
    }
}
