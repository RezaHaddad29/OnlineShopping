namespace OnlineShop.Infrastructure.Configurations
{
    public class AddressConfiguration : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.HasKey(a => a.ID);

            builder.Property(a => a.City)
                .IsRequired()
                .HasMaxLength(100);
            builder.Property(a => a.AddressText)
                .IsRequired()
                .HasMaxLength(300);
            builder.Property(a => a.PostalCode)
                .IsRequired()
                .HasMaxLength(32);
        }
    }
}
