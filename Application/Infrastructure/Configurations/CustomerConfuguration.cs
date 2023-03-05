namespace Application.Infrastructure.Configuration;
public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
{
    public void Configure(EntityTypeBuilder<Customer> builder)
    {
        builder.HasKey(p => p.Id);
        // builder.OwnsOne(p => p.Reserves);
    }
}