// <auto-generated />
using System;
using GamesDrop.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GamesDrop.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GamesDrop.Data.Entities.Cart", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique()
                        .HasFilter("[UserId] IS NOT NULL");

                    b.ToTable("Carts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            UserId = "BBF17FF9-151E-449B-822E-05A80274AF0E"
                        },
                        new
                        {
                            Id = 2,
                            UserId = "72B00045-7186-44C0-BDE6-568C370B7753"
                        });
                });

            modelBuilder.Entity("GamesDrop.Data.Entities.CartItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CardId")
                        .HasColumnType("int");

                    b.Property<int>("GameId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CardId");

                    b.HasIndex("GameId");

                    b.ToTable("CartItem");
                });

            modelBuilder.Entity("GamesDrop.Data.Entities.Device", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Devices");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "PC"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Playstation"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Xbox"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Nintendo"
                        });
                });

            modelBuilder.Entity("GamesDrop.Data.Entities.Game", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("CoverUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PlatformId")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("money");

                    b.Property<bool>("Recommended")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TrailerUrl")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("PlatformId");

                    b.ToTable("Games");
                });

            modelBuilder.Entity("GamesDrop.Data.Entities.GameCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("GameCategories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Akcji"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Przygodowa"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Jednoosobowa"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Indie"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Strategiczna"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Symulacja"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Wieloosobowa"
                        },
                        new
                        {
                            Id = 8,
                            Name = "RPG"
                        },
                        new
                        {
                            Id = 9,
                            Name = "Casual"
                        });
                });

            modelBuilder.Entity("GamesDrop.Data.Entities.GamePlatform", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OperatingSystemId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OperatingSystemId");

                    b.ToTable("GamePlatforms");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Steam",
                            OperatingSystemId = 1
                        },
                        new
                        {
                            Id = 2,
                            Name = "Epic Games",
                            OperatingSystemId = 1
                        },
                        new
                        {
                            Id = 3,
                            Name = "Origin",
                            OperatingSystemId = 1
                        },
                        new
                        {
                            Id = 4,
                            Name = "Playstation network",
                            OperatingSystemId = 2
                        },
                        new
                        {
                            Id = 5,
                            Name = "Playstation network",
                            OperatingSystemId = 3
                        },
                        new
                        {
                            Id = 6,
                            Name = "Xbox live",
                            OperatingSystemId = 4
                        },
                        new
                        {
                            Id = 7,
                            Name = "Xbox live",
                            OperatingSystemId = 5
                        },
                        new
                        {
                            Id = 8,
                            Name = "Nintendo",
                            OperatingSystemId = 6
                        });
                });

            modelBuilder.Entity("GamesDrop.Data.Entities.Key", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("GameId")
                        .HasColumnType("int");

                    b.Property<string>("GameKey")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("GameId");

                    b.ToTable("Keys");
                });

            modelBuilder.Entity("GamesDrop.Data.Entities.OperatingSystem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DeviceId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DeviceId");

                    b.ToTable("OperatingSystems");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DeviceId = 1,
                            Name = "Windows 10"
                        },
                        new
                        {
                            Id = 2,
                            DeviceId = 2,
                            Name = "PS4"
                        },
                        new
                        {
                            Id = 3,
                            DeviceId = 2,
                            Name = "PS5"
                        },
                        new
                        {
                            Id = 4,
                            DeviceId = 3,
                            Name = "One"
                        },
                        new
                        {
                            Id = 5,
                            DeviceId = 3,
                            Name = "Series"
                        },
                        new
                        {
                            Id = 6,
                            DeviceId = 4,
                            Name = "Switch"
                        });
                });

            modelBuilder.Entity("GamesDrop.Data.Entities.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("GamesDrop.Data.Entities.OrderGame", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("GameId")
                        .HasColumnType("int");

                    b.Property<int>("KeyId")
                        .HasColumnType("int");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("PercentDiscount")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("money");

                    b.HasKey("Id");

                    b.HasIndex("GameId");

                    b.HasIndex("KeyId")
                        .IsUnique();

                    b.HasIndex("OrderId");

                    b.ToTable("OrderGames");
                });

            modelBuilder.Entity("GamesDrop.Data.Entities.Payment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("PaymentMethodId")
                        .HasColumnType("int");

                    b.Property<string>("PaymentStatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("OrderId")
                        .IsUnique();

                    b.HasIndex("PaymentMethodId");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("GamesDrop.Data.Entities.PaymentMethod", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("PaymentMethods");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Przelew tradycyjny"
                        },
                        new
                        {
                            Id = 2,
                            Name = "BLIK"
                        },
                        new
                        {
                            Id = 3,
                            Name = "przelewy24"
                        });
                });

            modelBuilder.Entity("GamesDrop.Data.Entities.Sale", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("GameId")
                        .HasColumnType("int");

                    b.Property<int>("PercentDiscount")
                        .HasColumnType("int");

                    b.Property<DateTime>("ValidFrom")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ValidTo")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("GameId");

                    b.ToTable("Sales");
                });

            modelBuilder.Entity("GamesDrop.Data.Entities.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");

                    b.HasData(
                        new
                        {
                            Id = "BBF17FF9-151E-449B-822E-05A80274AF0E",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "0d93700a-d264-48d7-bf70-252a94c4e784",
                            Email = "admin@example.com",
                            EmailConfirmed = false,
                            FirstName = "Bill",
                            LastName = "Gates",
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@EXAMPLE.COM",
                            NormalizedUserName = "ADMIN@EXAMPLE.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAELAxQQWWzuHE7bV1ea+lEQzXmdpMX31XSlg+nwNpIkebGtlrhi++5MfXq3c1WO0i7A==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "AE3EAA41-29C2-49BE-97EC-B5D5A38593D2",
                            TwoFactorEnabled = false,
                            UserName = "admin@example.com"
                        },
                        new
                        {
                            Id = "72B00045-7186-44C0-BDE6-568C370B7753",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "13cdd86d-f061-48a9-8950-7eb4433ceb63",
                            Email = "user@example.com",
                            EmailConfirmed = false,
                            FirstName = "Will",
                            LastName = "Smith",
                            LockoutEnabled = false,
                            NormalizedEmail = "USER@EXAMPLE.COM",
                            NormalizedUserName = "USER@EXAMPLE.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAECszLmEIgBc/ahcw3xmJxSUOySb75sWanxySSiOtjh/nqs67Ie0ZYjK++00DalQQNg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "17BA0B4A-BDB2-44BF-ADBD-E1B66083D4D9",
                            TwoFactorEnabled = false,
                            UserName = "user@example.com"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");

                    b.HasData(
                        new
                        {
                            Id = "ddff8859-63af-4353-9ebc-a0f76014b93e",
                            ConcurrencyStamp = "6e4ce9a3-5194-4809-9c12-6f9ab5fcb1ea",
                            Name = "User",
                            NormalizedName = "User"
                        },
                        new
                        {
                            Id = "bf74082f-8008-470d-92a3-41b56ac3e204",
                            ConcurrencyStamp = "443cb481-c2ad-446b-9f82-de44f29f1fd5",
                            Name = "Admin",
                            NormalizedName = "Admin"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");

                    b.HasData(
                        new
                        {
                            UserId = "72B00045-7186-44C0-BDE6-568C370B7753",
                            RoleId = "ddff8859-63af-4353-9ebc-a0f76014b93e"
                        },
                        new
                        {
                            UserId = "BBF17FF9-151E-449B-822E-05A80274AF0E",
                            RoleId = "bf74082f-8008-470d-92a3-41b56ac3e204"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("GamesDrop.Data.Entities.Cart", b =>
                {
                    b.HasOne("GamesDrop.Data.Entities.User", "User")
                        .WithOne("Cart")
                        .HasForeignKey("GamesDrop.Data.Entities.Cart", "UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("GamesDrop.Data.Entities.CartItem", b =>
                {
                    b.HasOne("GamesDrop.Data.Entities.Cart", "Cart")
                        .WithMany("CartItems")
                        .HasForeignKey("CardId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GamesDrop.Data.Entities.Game", "Game")
                        .WithMany("CartItems")
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cart");

                    b.Navigation("Game");
                });

            modelBuilder.Entity("GamesDrop.Data.Entities.Game", b =>
                {
                    b.HasOne("GamesDrop.Data.Entities.GameCategory", "GameCategory")
                        .WithMany("Games")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GamesDrop.Data.Entities.GamePlatform", "GamePlatform")
                        .WithMany("Games")
                        .HasForeignKey("PlatformId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("GameCategory");

                    b.Navigation("GamePlatform");
                });

            modelBuilder.Entity("GamesDrop.Data.Entities.GamePlatform", b =>
                {
                    b.HasOne("GamesDrop.Data.Entities.OperatingSystem", "OperatingSystem")
                        .WithMany("GamePlatforms")
                        .HasForeignKey("OperatingSystemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("OperatingSystem");
                });

            modelBuilder.Entity("GamesDrop.Data.Entities.Key", b =>
                {
                    b.HasOne("GamesDrop.Data.Entities.Game", "Game")
                        .WithMany("Keys")
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Game");
                });

            modelBuilder.Entity("GamesDrop.Data.Entities.OperatingSystem", b =>
                {
                    b.HasOne("GamesDrop.Data.Entities.Device", "Device")
                        .WithMany("OperatingSystems")
                        .HasForeignKey("DeviceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Device");
                });

            modelBuilder.Entity("GamesDrop.Data.Entities.Order", b =>
                {
                    b.HasOne("GamesDrop.Data.Entities.User", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("GamesDrop.Data.Entities.OrderGame", b =>
                {
                    b.HasOne("GamesDrop.Data.Entities.Game", "Game")
                        .WithMany("OrderGames")
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GamesDrop.Data.Entities.Key", "Key")
                        .WithOne("OrderGame")
                        .HasForeignKey("GamesDrop.Data.Entities.OrderGame", "KeyId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("GamesDrop.Data.Entities.Order", "Order")
                        .WithMany("OrderGames")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Game");

                    b.Navigation("Key");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("GamesDrop.Data.Entities.Payment", b =>
                {
                    b.HasOne("GamesDrop.Data.Entities.Order", "Order")
                        .WithOne("Payment")
                        .HasForeignKey("GamesDrop.Data.Entities.Payment", "OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GamesDrop.Data.Entities.PaymentMethod", "PaymentMethod")
                        .WithMany("Payments")
                        .HasForeignKey("PaymentMethodId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("PaymentMethod");
                });

            modelBuilder.Entity("GamesDrop.Data.Entities.Sale", b =>
                {
                    b.HasOne("GamesDrop.Data.Entities.Game", "Game")
                        .WithMany("Sales")
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Game");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("GamesDrop.Data.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("GamesDrop.Data.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GamesDrop.Data.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("GamesDrop.Data.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GamesDrop.Data.Entities.Cart", b =>
                {
                    b.Navigation("CartItems");
                });

            modelBuilder.Entity("GamesDrop.Data.Entities.Device", b =>
                {
                    b.Navigation("OperatingSystems");
                });

            modelBuilder.Entity("GamesDrop.Data.Entities.Game", b =>
                {
                    b.Navigation("CartItems");

                    b.Navigation("Keys");

                    b.Navigation("OrderGames");

                    b.Navigation("Sales");
                });

            modelBuilder.Entity("GamesDrop.Data.Entities.GameCategory", b =>
                {
                    b.Navigation("Games");
                });

            modelBuilder.Entity("GamesDrop.Data.Entities.GamePlatform", b =>
                {
                    b.Navigation("Games");
                });

            modelBuilder.Entity("GamesDrop.Data.Entities.Key", b =>
                {
                    b.Navigation("OrderGame");
                });

            modelBuilder.Entity("GamesDrop.Data.Entities.OperatingSystem", b =>
                {
                    b.Navigation("GamePlatforms");
                });

            modelBuilder.Entity("GamesDrop.Data.Entities.Order", b =>
                {
                    b.Navigation("OrderGames");

                    b.Navigation("Payment");
                });

            modelBuilder.Entity("GamesDrop.Data.Entities.PaymentMethod", b =>
                {
                    b.Navigation("Payments");
                });

            modelBuilder.Entity("GamesDrop.Data.Entities.User", b =>
                {
                    b.Navigation("Cart");

                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}
