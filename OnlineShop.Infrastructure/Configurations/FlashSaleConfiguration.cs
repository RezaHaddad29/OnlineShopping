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
            builder.ToTable("FlashSales");

            builder.HasKey(f => f.ID);

            builder.Property(f => f.StartDate)
                   .IsRequired();

            builder.Property(f => f.EndDate)
                   .IsRequired();

            builder.Property(f => f.CreatedAt)
                   .HasDefaultValueSql("GETDATE()")
                   .IsRequired();

            builder.Property(f => f.UpdatedAt)
                   .HasDefaultValueSql("GETDATE()")
                   .IsRequired();
        }
    }
}
