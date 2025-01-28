namespace OnlineShop.Infrastructure.Configurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(c => c.ID);

            builder.Property(c => c.Title)
                .IsRequired()
                .HasMaxLength(100);

            builder.HasOne(c => c.ParentCategory)
                .WithMany(c => c.SubCategories)
                .HasForeignKey(c => c.ParentID)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
