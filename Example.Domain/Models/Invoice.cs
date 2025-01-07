namespace Example.Domain.Models
{
    public class Invoice
    {
        public string InvoiceId { get; set; }
        public string OrderId { get; set; }
        public decimal TotalAmount { get; set; }
        public DateTime IssuedAt { get; set; }
    }
}