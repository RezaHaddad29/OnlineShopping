using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Infrastructure.Configurations
{
    public class FlashSaleConfiguration : IEntityTypeConfiguration<FlashSale>
    {
        public void Configure(EntityTypeBuilder<FlashSale> builder)
        {
            builder.HasKey(f => f.ID);

            builder.Property(f => f.DiscountPercentage)
                   .HasColumnType("decimal(5,2)");

            builder.Property(f => f.StartDate)
                   .IsRequired();

            builder.Property(f => f.EndDate)
                   .IsRequired();

            builder.Property(f => f.CreatedAt)
                   .HasDefaultValueSql("GETDATE()");

            builder.Property(f => f.UpdatedAt)
                   .HasDefaultValueSql("GETDATE()");

            builder.HasOne(f => f.Product)
                   .WithOne(p => p.FlashSale)
                   .HasForeignKey<FlashSale>(f => f.ProductID)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
