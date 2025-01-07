namespace Example.Domain.Commands
{
    public class CreateShipmentCommand
    {
        public string InvoiceId { get; set; }
        public string TrackingNumber { get; set; }
    }
}