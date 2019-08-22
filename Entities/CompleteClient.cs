using System;
using System.Collections.Generic;

namespace PractiaTest.Models.Entities
{
    public class CompleteClient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public DateTime BornDate { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public List<Invoice> Invoices = new List<Invoice>();
        public decimal Has10PercentDiscount { get; set; }
    }
}