namespace Example.Domain.Events
{
    public class ShipmentCreatedEvent
    {
        public string ShipmentId { get; set; }
        public string InvoiceId { get; set; }
        public string TrackingNumber { get; set; }
    }
}