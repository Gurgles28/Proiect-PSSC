using Proiect_PSSC.Enums;

namespace Proiect_PSSC.Data;

public class Invoice
{
    public Guid Id { get; set; }
    public Guid OrderId { get; set; }
    public decimal Amount { get; set; }
    public InvoiceStatus Status { get; set; }
}