using GamesDrop.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GamesDrop.Data.Configurations
{
    public class SaleConfiguration : IEntityTypeConfiguration<Sale>
    {
        public void Configure(EntityTypeBuilder<Sale> builder)
        {
            builder
                .HasKey(sale => sale.Id);

            builder
                .HasOne(sale => sale.Game)
                .WithMany(game => game.Sales)
                .HasForeignKey(sale => sale.GameId);
        }
    }
}