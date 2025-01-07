using Proiect_PSSC.Data;
using Proiect_PSSC.Enums;

namespace Proiect_PSSC.Services;

public interface IShipmentService
{
    Task<Shipment> CreateShipmentAsync(Guid orderId, string trackingNumber);
    Task UpdateShipmentStatusAsync(Guid shipmentId, ShipmentStatus status);
}