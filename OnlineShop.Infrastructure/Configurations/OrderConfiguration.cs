using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Infrastructure.Configurations
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasKey(o => o.ID);
            builder.Property(o => o.OrderDate).IsRequired();

            builder.HasOne(o => o.User)
               .WithMany(u => u.Orders)
               .HasForeignKey(o => o.UserID)
               .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(o => o.Address)
               .WithMany()
               .HasForeignKey(o => o.AddressID)
               .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(o => o.Status)
               .WithMany()
               .HasForeignKey(o => o.StatusID);

            builder.HasOne(o => o.PaymentStatus)
                   .WithMany()
                   .HasForeignKey(o => o.PaymentStatusID);

            builder.HasOne(o => o.ShippingStatus)
                   .WithMany()
                   .HasForeignKey(o => o.ShippingStatusID);
        }
    }
}
