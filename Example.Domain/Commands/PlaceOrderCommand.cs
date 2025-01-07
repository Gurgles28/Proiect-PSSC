namespace Example.Domain.Commands
{
    public class PlaceOrderCommand
    {
        public string CustomerId { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
    }
}