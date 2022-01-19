using GamesDrop.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GamesDrop.Data.Configurations
{
    public class KeyConfiguration : IEntityTypeConfiguration<Key>
    {
        public void Configure(EntityTypeBuilder<Key> builder)
        {
            builder
                .HasKey(x => x.Id);

            builder
                .HasOne(key => key.Game)
                .WithMany(game => game.Keys)
                .HasForeignKey(key => key.GameId);
        }
    }
}