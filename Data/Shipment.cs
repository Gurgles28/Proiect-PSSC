using Proiect_PSSC.Enums;

namespace Proiect_PSSC.Data;

public class Shipment
{
    public Guid Id { get; set; }
    public Guid OrderId { get; set; }
    public string TrackingNumber { get; set; } = string.Empty;
    public ShipmentStatus Status { get; set; }
}