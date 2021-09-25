using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Friends.EntityFrameworkCore
{
    public static class FriendsDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<FriendsDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<FriendsDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
