using Proiect_PSSC.Data;

namespace Proiect_PSSC.Repos;

public interface IInvoiceRepository
{
    Task AddInvoiceAsync(Invoice invoice);
    Task<Invoice?> GetInvoiceByIdAsync(Guid invoiceId);
}