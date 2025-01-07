using Microsoft.EntityFrameworkCore;

namespace Proiect_PSSC.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
        // Initialize any additional setup, if needed
    }

    public DbSet<Order> Orders { get; set; }
    public DbSet<Invoice> Invoices { get; set; }
    public DbSet<Shipment> Shipments { get; set; }
}
