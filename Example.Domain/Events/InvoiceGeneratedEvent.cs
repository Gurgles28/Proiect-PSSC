namespace Example.Domain.Events
{
    public class InvoiceGeneratedEvent
    {
        public string InvoiceId { get; set; }
        public string OrderId { get; set; }
        public decimal TotalAmount { get; set; }
    }
}