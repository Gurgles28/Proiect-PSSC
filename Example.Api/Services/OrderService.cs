namespace Example.Api.Services
{
    public class OrderService
    {
        public bool ValidateOrder(string customerId, int quantity)
        {
            // Example validation logic
            return !string.IsNullOrEmpty(customerId) && quantity > 0;
        }
    }
}