using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Infrastructure.Configurations
{
    public class ShippingStatusConfiguration : IEntityTypeConfiguration<ShippingStatus>
    {
        public void Configure(EntityTypeBuilder<ShippingStatus> builder)
        {
            builder.HasKey(s => s.ID);

            builder.Property(s => s.Title).IsRequired().HasMaxLength(50);
            builder.Property(s => s.Desc).IsRequired().HasMaxLength(500);
        }
    
    }
}
