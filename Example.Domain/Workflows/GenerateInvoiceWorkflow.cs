using Example.Domain.Commands;
using Example.Domain.Events;

namespace Example.Domain.Workflows
{
    public class GenerateInvoiceWorkflow
    {
        public InvoiceGeneratedEvent Execute(GenerateInvoiceCommand command)
        {
            // Simulated workflow logic
            return new InvoiceGeneratedEvent
            {
                InvoiceId = Guid.NewGuid().ToString(),
                OrderId = command.OrderId,
                TotalAmount = command.TotalAmount
            };
        }
    }
}