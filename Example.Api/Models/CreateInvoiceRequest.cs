namespace Example.Api.Models
{
    public class CreateInvoiceRequest
    {
        public string OrderId { get; set; }
        public decimal TotalAmount { get; set; }
    }
}