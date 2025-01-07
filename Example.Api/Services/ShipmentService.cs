namespace Example.Api.Services
{
    public class ShipmentService
    {
        public bool ValidateShipment(string trackingNumber)
        {
            // Example validation logic for shipments
            return !string.IsNullOrEmpty(trackingNumber);
        }
    }
}