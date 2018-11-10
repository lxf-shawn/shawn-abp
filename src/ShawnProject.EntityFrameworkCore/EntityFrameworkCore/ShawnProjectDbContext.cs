using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using ShawnProject.Authorization.Roles;
using ShawnProject.Authorization.Users;
using ShawnProject.MultiTenancy;

namespace ShawnProject.EntityFrameworkCore
{
    public class ShawnProjectDbContext : AbpZeroDbContext<Tenant, Role, User, ShawnProjectDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public ShawnProjectDbContext(DbContextOptions<ShawnProjectDbContext> options)
            : base(options)
        {
        }
    }
}
