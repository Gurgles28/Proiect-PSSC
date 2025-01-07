using Example.Domain.Commands;
using Example.Domain.Workflows;
using Microsoft.AspNetCore.Mvc;

namespace Example.Api.Controllers
{
    [ApiController]
    [Route("api/shipments")]
    public class ShipmentsController : ControllerBase
    {
        private readonly CreateShipmentWorkflow createShipmentWorkflow;

        public ShipmentsController(CreateShipmentWorkflow createShipmentWorkflow)
        {
            this.createShipmentWorkflow = createShipmentWorkflow;
        }

        [HttpPost]
        public IActionResult CreateShipment([FromBody] CreateShipmentCommand command)
        {
            var shipmentEvent = createShipmentWorkflow.Execute(command);
            return Ok(shipmentEvent);
        }
    }
}