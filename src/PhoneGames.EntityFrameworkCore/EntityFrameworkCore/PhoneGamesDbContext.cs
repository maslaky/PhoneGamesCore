using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using PhoneGames.Authorization.Roles;
using PhoneGames.Authorization.Users;
using PhoneGames.Business.GameInstances;
using PhoneGames.Business.Questions;
using PhoneGames.MultiTenancy;

namespace PhoneGames.EntityFrameworkCore
{
    public class PhoneGamesDbContext : AbpZeroDbContext<Tenant, Role, User, PhoneGamesDbContext>
    {
        /* Define a DbSet for each entity of the application */
        public DbSet<Question> Questions { get; set; }
        public DbSet<GameInstance> GameInstances { get; set; }
        public PhoneGamesDbContext(DbContextOptions<PhoneGamesDbContext> options)
            : base(options)
        {
        }
    }
}
