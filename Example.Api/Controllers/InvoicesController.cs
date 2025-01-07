using Example.Domain.Commands;
using Example.Domain.Workflows;
using Microsoft.AspNetCore.Mvc;

namespace Example.Api.Controllers
{
    [ApiController]
    [Route("api/invoices")]
    public class InvoicesController : ControllerBase
    {
        private readonly GenerateInvoiceWorkflow generateInvoiceWorkflow;

        public InvoicesController(GenerateInvoiceWorkflow generateInvoiceWorkflow)
        {
            this.generateInvoiceWorkflow = generateInvoiceWorkflow;
        }

        [HttpPost]
        public IActionResult GenerateInvoice([FromBody] GenerateInvoiceCommand command)
        {
            var invoiceEvent = generateInvoiceWorkflow.Execute(command);
            return Ok(invoiceEvent);
        }
    }
}