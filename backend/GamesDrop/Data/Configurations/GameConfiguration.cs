using GamesDrop.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GamesDrop.Data.Configurations
{
    public class GameConfiguration : IEntityTypeConfiguration<Game>
    {
        public void Configure(EntityTypeBuilder<Game> builder)
        {
            builder
                .HasKey(e => e.Id);

            builder
                .Property(e => e.Price).HasColumnType("money");

            builder
                .HasOne(s => s.GameCategory)
                .WithMany(c => c.Games)
                .HasForeignKey(s => s.CategoryId);

            builder
                .HasOne(s => s.GamePlatform)
                .WithMany(c => c.Games)
                .HasForeignKey(s => s.PlatformId);
        }
    }
}