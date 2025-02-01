namespace OnlineShop.Infrastructure.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(p => p.ID);

            builder.Property(p => p.Title)
                   .IsRequired()
                   .HasMaxLength(255);

            builder.Property(p => p.Price)
                   .HasColumnType("decimal(18,2)");

            builder.Property(p => p.Desc)
                   .HasColumnType("TEXT");

            builder.Property(p => p.ImageURL)
                   .HasMaxLength(255);

            builder.Property(p => p.CreatedAt)
                   .HasDefaultValueSql("GETDATE()");

            builder.Property(p => p.UpdatedAt)
                   .HasDefaultValueSql("GETDATE()");

            builder.HasOne(p => p.Category)
                   .WithMany(c => c.Products)
                   .HasForeignKey(p => p.CategoryID)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(p => p.Brand)
                   .WithMany(b => b.Products)
                   .HasForeignKey(p => p.BrandID)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(p => p.FlashSale)
                   .WithMany(f => f.Products)
                   .HasForeignKey(p => p.FlashSaleID)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }

}
