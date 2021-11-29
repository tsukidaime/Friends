using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Friends.Authorization.Roles;
using Friends.Authorization.Users;
using Friends.MultiTenancy;
using Friends.Entities;

namespace Friends.EntityFrameworkCore
{
    public class FriendsDbContext : AbpZeroDbContext<Tenant, Role, User, FriendsDbContext>
    {
        /* Define a DbSet for each entity of the application */
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<UserRoom> UserRooms { get; set; }
        public DbSet<UserEvent> UserEvents { get; set; }

        public FriendsDbContext(DbContextOptions<FriendsDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Room>()
                .HasMany<Event>(x => x.Events)
                .WithOne(x => x.Room)
                .HasForeignKey(x => x.RoomId);

            modelBuilder.Entity<User>()
                .HasMany<UserRoom>(x => x.UserRooms)
                .WithOne(x => x.User)
                .HasForeignKey(x=>x.UserId);
            modelBuilder.Entity<UserEvent>()
                .HasKey(x => new { x.EventId, x.UserId });
            modelBuilder.Entity<UserRoom>()
                .HasKey(x => new { x.RoomId, x.UserId });
            modelBuilder.Entity<Room>()
                .HasMany<UserRoom>(x => x.UserRooms)
                .WithOne(x => x.Room)
                .HasForeignKey(x => x.RoomId);

            modelBuilder.Entity<User>()
                .HasMany<UserEvent>(x => x.UserEvents)
                .WithOne(x => x.User)
                .HasForeignKey(x => x.UserId);
            modelBuilder.Entity<Event>()
                .HasMany<UserEvent>(x => x.UserEvents)
                .WithOne(x => x.Event)
                .HasForeignKey(x => x.EventId);
        }
    }
}
