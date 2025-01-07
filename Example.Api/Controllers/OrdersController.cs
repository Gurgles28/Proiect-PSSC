using Example.Domain.Commands;
using Example.Domain.Workflows;
using Microsoft.AspNetCore.Mvc;

namespace Example.Api.Controllers
{
    [ApiController]
    [Route("api/orders")]
    public class OrdersController : ControllerBase
    {
        private readonly PlaceOrderWorkflow placeOrderWorkflow;

        public OrdersController(PlaceOrderWorkflow placeOrderWorkflow)
        {
            this.placeOrderWorkflow = placeOrderWorkflow;
        }

        [HttpPost]
        public IActionResult PlaceOrder([FromBody] PlaceOrderCommand command)
        {
            var orderEvent = placeOrderWorkflow.Execute(command);
            return Ok(orderEvent);
        }
    }
}