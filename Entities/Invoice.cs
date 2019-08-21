using System;
using System.Collections.Generic;

namespace PractiaTest.Models.Entities
{
    public class Invoice
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public DateTime IssueDate { get; set; }
        public bool Paid { get; set; }
        public decimal? Total { get; set; }
    }
}