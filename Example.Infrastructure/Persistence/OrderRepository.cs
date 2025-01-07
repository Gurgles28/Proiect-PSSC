using Example.Domain.Models;
using Example.Domain.Repositories;

namespace Example.Infrastructure.Persistence
{
    public class OrderRepository : IOrderRepository
    {
        private readonly List<Order> orders = new();

        public Task SaveOrderAsync(Order order)
        {
            orders.Add(order);
            return Task.CompletedTask;
        }

        public Task<Order> GetOrderByIdAsync(string orderId)
        {
            return Task.FromResult(orders.FirstOrDefault(o => o.OrderId == orderId));
        }
    }
}