using Proiect_PSSC.Data;

namespace Proiect_PSSC.Repos;

public class InvoiceRepository : IInvoiceRepository
{
    private readonly AppDbContext _context;

    public InvoiceRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task AddInvoiceAsync(Invoice invoice)
    {
        _context.Invoices.Add(invoice);
        await _context.SaveChangesAsync();
    }

    public async Task<Invoice?> GetInvoiceByIdAsync(Guid invoiceId)
    {
        return await _context.Invoices.FindAsync(invoiceId);
    }
}
