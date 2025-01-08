using Example.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Example.Infrastructure.Persistence
{
    public class OrderWorkflowDbContext : DbContext
    {
        public OrderWorkflowDbContext(DbContextOptions<OrderWorkflowDbContext> options)
            : base(options)
        {
        }

        public DbSet<Order> Orders { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<Shipment> Shipments { get; set; }
    }
}