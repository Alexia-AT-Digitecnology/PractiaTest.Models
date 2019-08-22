using System;
using System.Collections.Generic;

namespace PractiaTest.Models.Entities
{
    public class CompleteInvoice
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public string ClientName { get; set; }
        public DateTime IssueDate { get; set; }
        public bool Paid { get; set; }
        public decimal? Total { get; set; }
        public List<InvoiceDetail> InvoiceDetail = new List<InvoiceDetail>(); 
            
    }
}