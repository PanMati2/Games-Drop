using GamesDrop.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GamesDrop.Data.Configurations
{
    public class GamePlatformConfiguration : IEntityTypeConfiguration<GamePlatform>
    {
        public void Configure(EntityTypeBuilder<GamePlatform> builder)
        {
            builder
                .HasKey(x => x.Id);

            builder
                .HasOne(platform => platform.OperatingSystem)
                .WithMany(os => os.GamePlatforms)
                .HasForeignKey(platform => platform.OperatingSystemId);
        }
    }
}