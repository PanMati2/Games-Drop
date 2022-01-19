using GamesDrop.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GamesDrop.Data.Configurations
{
    public class OrderGameConfiguration : IEntityTypeConfiguration<OrderGame>
    {
        public void Configure(EntityTypeBuilder<OrderGame> builder)
        {
            builder
                .HasKey(orderGame => orderGame.Id);

            builder
                .Property(e => e.Price).HasColumnType("money");

            builder
                .HasOne(orderGame => orderGame.Game)
                .WithMany(game => game.OrderGames)
                .HasForeignKey(orderGame => orderGame.GameId);

            builder
                .HasOne(orderGame => orderGame.Order)
                .WithMany(game => game.OrderGames)
                .HasForeignKey(orderGame => orderGame.OrderId);

            builder
                .HasOne(orderGame => orderGame.Key)
                .WithOne(key => key.OrderGame)
                .HasForeignKey<OrderGame>(orderGame => orderGame.KeyId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}