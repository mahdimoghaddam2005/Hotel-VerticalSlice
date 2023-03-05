namespace Application.Infrastructure.Persistence;
public class HotelContext : DbContext
{
    public HotelContext(DbContextOptions<HotelContext> options) : base(options)
    {
        
    }
    public DbSet<Customer> Customers { get; set; }
}