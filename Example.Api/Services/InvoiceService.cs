namespace Example.Api.Services
{
    public class InvoiceService
    {
        public bool ValidateInvoice(decimal totalAmount)
        {
            // Example validation logic for invoices
            return totalAmount > 0;
        }
    }
}