using System.Reflection;
using GamesDrop.Data.Entities;
using GamesDrop.Data.Seeders;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GamesDrop.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartItem> CartItem { get; set; }
        public DbSet<Device> Devices { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<GameCategory> GameCategories { get; set; }
        public DbSet<GamePlatform> GamePlatforms { get; set; }
        public DbSet<Key> Keys { get; set; }
        public DbSet<OperatingSystem> OperatingSystems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderGame> OrderGames { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<PaymentMethod> PaymentMethods { get; set; }
        public DbSet<Sale> Sales { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder
                .ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            builder
                .SeedUsers();

            builder
                .SeedDevices();

            builder
                .SeedOperatingSystems();

            builder
                .SeedPlatforms();

            builder
                .SeedCategories();

            builder
                .SeedPaymentsMethods();
        }
    }
}