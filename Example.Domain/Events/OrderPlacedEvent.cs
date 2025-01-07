namespace Example.Domain.Events
{
    public class OrderPlacedEvent
    {
        public string OrderId { get; set; }
        public string CustomerId { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
    }
}