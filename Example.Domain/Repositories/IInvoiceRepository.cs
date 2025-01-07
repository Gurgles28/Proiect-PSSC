using Example.Domain.Models;

namespace Example.Domain.Repositories
{
    public interface IInvoiceRepository
    {
        Task SaveInvoiceAsync(Invoice invoice);
        Task<Invoice> GetInvoiceByIdAsync(string invoiceId);
    }
}