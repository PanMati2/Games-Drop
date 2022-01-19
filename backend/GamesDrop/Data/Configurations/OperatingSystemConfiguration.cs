using GamesDrop.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GamesDrop.Data.Configurations
{
    public class OperatingSystemConfiguration : IEntityTypeConfiguration<OperatingSystem>
    {
        public void Configure(EntityTypeBuilder<OperatingSystem> builder)
        {
            builder
                .HasKey(system => system.Id);

            builder
                .HasOne(os => os.Device)
                .WithMany(device => device.OperatingSystems)
                .HasForeignKey(system => system.DeviceId);
        }
    }
}