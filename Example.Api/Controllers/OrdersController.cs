using Example.Domain.Commands;
using Example.Domain.Workflows;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

[ApiController]
[Route("api/orders")] 
public class OrdersController : ControllerBase
{
    private readonly PlaceOrderWorkflow placeOrderWorkflow;

    private readonly ILogger<OrdersController> logger;

    public OrdersController(PlaceOrderWorkflow placeOrderWorkflow, ILogger<OrdersController> logger)
    {
        this.placeOrderWorkflow = placeOrderWorkflow;
        this.logger = logger;
    }

    [HttpPost]
    public IActionResult PlaceOrder([FromBody] PlaceOrderCommand command)
    {
        // Log when the endpoint is hit
        logger.LogInformation("PlaceOrder endpoint hit with data: {CustomerId}", command.CustomerId);

        // Execute the workflow and return the result
        var orderEvent = placeOrderWorkflow.Execute(command);
        return Ok(orderEvent);
    }



}