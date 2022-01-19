using GamesDrop.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GamesDrop.Data.Configurations
{
    public class CartItemConfiguration : IEntityTypeConfiguration<CartItem>
    {
        public void Configure(EntityTypeBuilder<CartItem> builder)
        {
            builder
                .HasKey(x => x.Id);

            builder
                .HasOne(cartItem => cartItem.Cart)
                .WithMany(cart => cart.CartItems)
                .HasForeignKey(item => item.CardId);

            builder
                .HasOne(cartItem => cartItem.Game)
                .WithMany(cart => cart.CartItems)
                .HasForeignKey(item => item.GameId);
        }
    }
}