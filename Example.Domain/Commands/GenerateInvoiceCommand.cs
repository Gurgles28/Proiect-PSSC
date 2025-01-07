namespace Example.Domain.Commands
{
    public class GenerateInvoiceCommand
    {
        public string OrderId { get; set; }
        public decimal TotalAmount { get; set; }
    }
}