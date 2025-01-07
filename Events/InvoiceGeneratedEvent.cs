namespace Proiect_PSSC.Events;

public class InvoiceGeneratedEvent
{
    public Guid InvoiceId { get; set; }
    public decimal Amount { get; set; }
}