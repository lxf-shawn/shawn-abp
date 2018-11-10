using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace ShawnProject.EntityFrameworkCore
{
    public static class ShawnProjectDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<ShawnProjectDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<ShawnProjectDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
