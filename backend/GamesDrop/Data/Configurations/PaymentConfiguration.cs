using System;
using GamesDrop.Data.Entities;
using GamesDrop.Data.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GamesDrop.Data.Configurations
{
    public class PaymentConfiguration : IEntityTypeConfiguration<Payment>
    {
        public void Configure(EntityTypeBuilder<Payment> builder)
        {
            builder
                .HasKey(payment => payment.Id);

            builder
                .Property(e => e.PaymentStatus)
                .HasConversion(
                    v => v.ToString(),
                    v => (PaymentStatus) Enum.Parse(typeof(PaymentStatus), v));

            builder
                .HasOne(payment => payment.Order)
                .WithOne(order => order.Payment)
                .HasForeignKey<Payment>(payment => payment.OrderId);

            builder
                .HasOne(payment => payment.PaymentMethod)
                .WithMany(paymentMethod => paymentMethod.Payments)
                .HasForeignKey(payment => payment.PaymentMethodId);
        }
    }
}