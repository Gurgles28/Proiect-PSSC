namespace Example.Api.Models
{
    public class CreateOrderRequest
    {
        public string CustomerId { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
    }
}