using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Infrastructure.Configurations
{
    public class SliderConfiguration : IEntityTypeConfiguration<Slider>
    {
        public void Configure(EntityTypeBuilder<Slider> builder)
        {
            builder.HasKey(s => s.ID);

            builder.Property(s => s.ImageURL)
                   .IsRequired()
                   .HasMaxLength(255);

            builder.Property(s => s.Title)
                   .IsRequired()
                   .HasMaxLength(255);

            builder.Property(s => s.Link)
                   .HasMaxLength(255);

            builder.Property(s => s.CreatedAt)
                   .IsRequired()
                   .HasDefaultValueSql("GETDATE()");

            builder.Property(s => s.UpdatedAt)
                   .IsRequired()
                   .HasDefaultValueSql("GETDATE()");
        }
    }
}
