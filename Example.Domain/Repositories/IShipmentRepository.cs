using Example.Domain.Models;

namespace Example.Domain.Repositories
{
    public interface IShipmentRepository
    {
        Task SaveShipmentAsync(Shipment shipment);
        Task<Shipment> GetShipmentByIdAsync(string shipmentId);
    }
}