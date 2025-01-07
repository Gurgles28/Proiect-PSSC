using Proiect_PSSC.Data;
using Proiect_PSSC.Enums;
using Proiect_PSSC.Repos;

namespace Proiect_PSSC.Handlers;

public class PlaceOrderCommandHandler
{
    private readonly IOrderRepository _repository;

    public PlaceOrderCommandHandler(IOrderRepository repository)
    {
        _repository = repository;
    }

    public async Task HandleAsync(Order order)
    {
        if (string.IsNullOrEmpty(order.CustomerName))
        {
            order.Status = OrderStatus.Invalid;
        }
        else
        {
            order.Status = OrderStatus.Validated;
            await _repository.AddOrderAsync(order);
        }
    }
}