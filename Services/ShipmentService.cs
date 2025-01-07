using Proiect_PSSC.Data;
using Proiect_PSSC.Enums;

namespace Proiect_PSSC.Services;

public class ShipmentService : IShipmentService
{
    private readonly AppDbContext _context;

    public ShipmentService(AppDbContext context)
    {
        _context = context;
    }

    public async Task<Shipment> CreateShipmentAsync(Guid orderId, string trackingNumber)
    {
        var shipment = new Shipment
        {
            Id = Guid.NewGuid(),
            OrderId = orderId,
            TrackingNumber = trackingNumber,
            Status = ShipmentStatus.Pending
        };
        _context.Shipments.Add(shipment);
        await _context.SaveChangesAsync();
        return shipment;
    }

    public async Task UpdateShipmentStatusAsync(Guid shipmentId, ShipmentStatus status)
    {
        var shipment = await _context.Shipments.FindAsync(shipmentId);
        if (shipment != null)
        {
            shipment.Status = status;
            await _context.SaveChangesAsync();
        }
    }
}