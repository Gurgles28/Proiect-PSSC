using Example.Domain.Models;
using Example.Domain.Repositories;

namespace Example.Infrastructure.Persistence
{
    public class ShipmentRepository : IShipmentRepository
    {
        private readonly List<Shipment> shipments = new();

        public Task SaveShipmentAsync(Shipment shipment)
        {
            shipments.Add(shipment);
            return Task.CompletedTask;
        }

        public Task<Shipment> GetShipmentByIdAsync(string shipmentId)
        {
            return Task.FromResult(shipments.FirstOrDefault(s => s.ShipmentId == shipmentId));
        }
    }
}