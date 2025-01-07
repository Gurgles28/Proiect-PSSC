namespace Proiect_PSSC.Events;

public class OrderPlacedEvent
{
    public Guid OrderId { get; set; }
    public string CustomerName { get; set; } = string.Empty;
}