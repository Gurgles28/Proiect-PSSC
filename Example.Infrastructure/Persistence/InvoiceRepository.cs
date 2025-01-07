using Example.Domain.Models;
using Example.Domain.Repositories;

namespace Example.Infrastructure.Persistence
{
    public class InvoiceRepository : IInvoiceRepository
    {
        private readonly List<Invoice> invoices = new();

        public Task SaveInvoiceAsync(Invoice invoice)
        {
            invoices.Add(invoice);
            return Task.CompletedTask;
        }

        public Task<Invoice> GetInvoiceByIdAsync(string invoiceId)
        {
            return Task.FromResult(invoices.FirstOrDefault(i => i.InvoiceId == invoiceId));
        }
    }
}