using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Infrastructure.Configurations
{
    public class OrderStatusConfiguration : IEntityTypeConfiguration<OrderStatus>
    {
        public void Configure(EntityTypeBuilder<OrderStatus> builder)
        {
            builder.HasKey(a => a.ID);

            builder.Property(a => a.Title)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(a => a.Desc)
                .IsRequired()
                .HasMaxLength(500);
        }
    }
}
