using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace PhoneGames.EntityFrameworkCore
{
    public static class PhoneGamesDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<PhoneGamesDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<PhoneGamesDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
