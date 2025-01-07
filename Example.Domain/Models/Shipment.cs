namespace Example.Domain.Models
{
    public class Shipment
    {
        public string ShipmentId { get; set; }
        public string InvoiceId { get; set; }
        public string TrackingNumber { get; set; }
        public DateTime ShippedAt { get; set; }
    }
}