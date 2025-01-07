using Proiect_PSSC.Data;
using Proiect_PSSC.Enums;
using Proiect_PSSC.Events;
using Proiect_PSSC.Repos;

namespace Proiect_PSSC.Handlers;

public class OrderShippedEventHandler
{
    private readonly IInvoiceRepository _invoiceRepository;

    public OrderShippedEventHandler(IInvoiceRepository invoiceRepository)
    {
        _invoiceRepository = invoiceRepository;
    }

    public async Task HandleAsync(OrderShippedEvent orderShippedEvent)
    {
        var invoice = new Invoice
        {
            Id = Guid.NewGuid(),
            OrderId = orderShippedEvent.OrderId,
            Amount = 100.00M, // Example amount
            Status = InvoiceStatus.Pending
        };
        await _invoiceRepository.AddInvoiceAsync(invoice);
    }
}