using Proiect_PSSC.Data;

namespace Proiect_PSSC.Repos;

public interface IOrderRepository
{
    Task AddOrderAsync(Order order);
    Task<Order?> GetOrderByIdAsync(Guid orderId);
}