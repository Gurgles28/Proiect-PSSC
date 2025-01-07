using Example.Domain.Commands;
using Example.Domain.Events;

namespace Example.Domain.Workflows
{
    public class PlaceOrderWorkflow
    {
        public OrderPlacedEvent Execute(PlaceOrderCommand command)
        {
            // Simulated workflow logic
            return new OrderPlacedEvent
            {
                OrderId = Guid.NewGuid().ToString(),
                CustomerId = command.CustomerId,
                ProductName = command.ProductName,
                Quantity = command.Quantity
            };
        }
    }
}