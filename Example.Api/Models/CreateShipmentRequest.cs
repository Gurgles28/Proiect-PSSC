namespace Example.Api.Models
{
    public class CreateShipmentRequest
    {
        public string InvoiceId { get; set; }
        public string TrackingNumber { get; set; }
    }
}