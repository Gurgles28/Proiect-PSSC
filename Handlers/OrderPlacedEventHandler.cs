using Proiect_PSSC.Events;
using Proiect_PSSC.Services;

namespace Proiect_PSSC.Handlers;

public class OrderPlacedEventHandler
{
    private readonly IShipmentService _shipmentService;

    public OrderPlacedEventHandler(IShipmentService shipmentService)
    {
        _shipmentService = shipmentService;
    }

    public async Task HandleAsync(OrderPlacedEvent orderPlacedEvent)
    {
        await _shipmentService.CreateShipmentAsync(orderPlacedEvent.OrderId, "TRK123456789");
    }
}