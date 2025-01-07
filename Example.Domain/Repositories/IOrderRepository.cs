using Example.Domain.Models;

namespace Example.Domain.Repositories
{
    public interface IOrderRepository
    {
        Task SaveOrderAsync(Order order);
        Task<Order> GetOrderByIdAsync(string orderId);
    }
}