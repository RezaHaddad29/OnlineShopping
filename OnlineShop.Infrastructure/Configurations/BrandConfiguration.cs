namespace OnlineShop.Infrastructure.Configurations
{
    public class BrandConfiguration : IEntityTypeConfiguration<Brand>
    {
        public void Configure(EntityTypeBuilder<Brand> builder)
        {
            builder.HasKey(b => b.ID);

            builder.Property(b => b.Title)
                .IsRequired()
                .HasMaxLength(100);
        }
    }
}
