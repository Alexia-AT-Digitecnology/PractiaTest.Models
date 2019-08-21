namespace PractiaTest.Models.Entities
{
    public class InvoiceDetail
    {
        public int InvoiceId { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int Amount { get; set; }
        public decimal SellPrice { get; set; }
        public decimal? Total { get; set; }
    }
}