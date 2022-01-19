using System;
using GamesDrop.Data.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using OperatingSystem = GamesDrop.Data.Entities.OperatingSystem;

namespace GamesDrop.Data.Seeders
{
    public static class DataSeeder
    {
        public static void SeedUsers(this ModelBuilder modelBuilder)
        {
            var userRole = new IdentityRole {Id = Guid.NewGuid().ToString(), Name = "User", NormalizedName = "User"};
            var adminRole = new IdentityRole {Id = Guid.NewGuid().ToString(), Name = "Admin", NormalizedName = "Admin"};

            modelBuilder.Entity<IdentityRole>().HasData(
                userRole, adminRole
            );

            var admin = new User
            {
                Id = "BBF17FF9-151E-449B-822E-05A80274AF0E",
                Email = "admin@example.com",
                NormalizedEmail = "admin@example.com".ToUpper(),
                UserName = "admin@example.com",
                NormalizedUserName = "admin@example.com".ToUpper(),
                FirstName = "Bill",
                LastName = "Gates",
                SecurityStamp = "AE3EAA41-29C2-49BE-97EC-B5D5A38593D2",
                EmailConfirmed = false
            };

            var user = new User
            {
                Id = "72B00045-7186-44C0-BDE6-568C370B7753",
                Email = "user@example.com",
                NormalizedEmail = "user@example.com".ToUpper(),
                UserName = "user@example.com",
                NormalizedUserName = "user@example.com".ToUpper(),
                FirstName = "Will",
                LastName = "Smith",
                SecurityStamp = "17BA0B4A-BDB2-44BF-ADBD-E1B66083D4D9",
                EmailConfirmed = false
            };

            var passwordHasher = new PasswordHasher<User>();
            admin.PasswordHash = passwordHasher.HashPassword(admin, "zaq1@WSX");
            user.PasswordHash = passwordHasher.HashPassword(user, "zaq1@WSX");

            modelBuilder.Entity<User>().HasData(
                admin, user
            );

            var userRole1 = new IdentityUserRole<string>
            {
                RoleId = userRole.Id, UserId = user.Id
            };

            var userRole2 = new IdentityUserRole<string>
            {
                RoleId = adminRole.Id, UserId = admin.Id
            };

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                userRole1, userRole2
            );

            modelBuilder.Entity<Cart>().HasData(
                new Cart {Id = 1, UserId = admin.Id},
                new Cart {Id = 2, UserId = user.Id}
            );
        }

        public static void SeedDevices(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Device>().HasData(
                new Device {Id = 1, Name = "PC"},
                new Device {Id = 2, Name = "Playstation"},
                new Device {Id = 3, Name = "Xbox"},
                new Device {Id = 4, Name = "Nintendo"}
            );
        }

        public static void SeedOperatingSystems(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OperatingSystem>().HasData(
                new OperatingSystem {Id = 1, DeviceId = 1, Name = "Windows 10"},
                new OperatingSystem {Id = 2, DeviceId = 2, Name = "PS4"},
                new OperatingSystem {Id = 3, DeviceId = 2, Name = "PS5"},
                new OperatingSystem {Id = 4, DeviceId = 3, Name = "One"},
                new OperatingSystem {Id = 5, DeviceId = 3, Name = "Series"},
                new OperatingSystem {Id = 6, DeviceId = 4, Name = "Switch"}
            );
        }

        public static void SeedPlatforms(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GamePlatform>().HasData(
                new GamePlatform {Id = 1, Name = "Steam", OperatingSystemId = 1},
                new GamePlatform {Id = 2, Name = "Epic Games", OperatingSystemId = 1},
                new GamePlatform {Id = 3, Name = "Origin", OperatingSystemId = 1},
                new GamePlatform {Id = 4, Name = "Playstation network", OperatingSystemId = 2},
                new GamePlatform {Id = 5, Name = "Playstation network", OperatingSystemId = 3},
                new GamePlatform {Id = 6, Name = "Xbox live", OperatingSystemId = 4},
                new GamePlatform {Id = 7, Name = "Xbox live", OperatingSystemId = 5},
                new GamePlatform {Id = 8, Name = "Nintendo", OperatingSystemId = 6}
            );
        }

        public static void SeedCategories(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GameCategory>().HasData(
                new GameCategory {Id = 1, Name = "Akcji"},
                new GameCategory {Id = 2, Name = "Przygodowa"},
                new GameCategory {Id = 3, Name = "Jednoosobowa"},
                new GameCategory {Id = 4, Name = "Indie"},
                new GameCategory {Id = 5, Name = "Strategiczna"},
                new GameCategory {Id = 6, Name = "Symulacja"},
                new GameCategory {Id = 7, Name = "Wieloosobowa"},
                new GameCategory {Id = 8, Name = "RPG"},
                new GameCategory {Id = 9, Name = "Casual"}
            );
        }

        public static void SeedPaymentsMethods(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PaymentMethod>().HasData(
                new PaymentMethod {Id = 1, Name = "Przelew tradycyjny"},
                new PaymentMethod {Id = 2, Name = "BLIK"},
                new PaymentMethod {Id = 3, Name = "przelewy24"}
            );
        }
    }
}