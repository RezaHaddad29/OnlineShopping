using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Infrastructure.Configurations
{
    public class PopularBrandConfiguration : IEntityTypeConfiguration<PopularBrand>
    {
        public void Configure(EntityTypeBuilder<PopularBrand> builder)
        {
            builder.HasKey(pb => pb.ID);

            builder.Property(pb => pb.CreatedAt)
                   .HasDefaultValueSql("GETDATE()")
                   .IsRequired();

            builder.HasOne(pb => pb.Brand)
                   .WithMany(b => b.PopularBrands)
                   .HasForeignKey(pb => pb.BrandID)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
