using Example.Domain.Commands;
using Example.Domain.Events;

namespace Example.Domain.Workflows
{
    public class CreateShipmentWorkflow
    {
        public ShipmentCreatedEvent Execute(CreateShipmentCommand command)
        {
            // Simulated workflow logic
            return new ShipmentCreatedEvent
            {
                ShipmentId = Guid.NewGuid().ToString(),
                InvoiceId = command.InvoiceId,
                TrackingNumber = command.TrackingNumber
            };
        }
    }
}