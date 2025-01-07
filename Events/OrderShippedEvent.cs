namespace Proiect_PSSC.Events;

public class OrderShippedEvent
{
    public Guid OrderId { get; set; }
    public string TrackingNumber { get; set; } = string.Empty;
}