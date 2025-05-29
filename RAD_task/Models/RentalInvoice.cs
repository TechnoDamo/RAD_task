using System;
using System.Collections.Generic;

namespace RAD_task.Models
{
    public class RentalInvoice
    {
        public int Id { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        public string CustomerName { get; set; }
        public string CustomerPhone { get; set; }
        public decimal TotalAmount { get; set; }
        public bool IsLost { get; set; }
        public bool IsPaid { get; set; }
        public int RentalPointId { get; set; }
        public RentalPoint RentalPoint { get; set; }
        public List<RentalInvoiceItem> Items { get; set; } = new List<RentalInvoiceItem>();
    }

    public class RentalInvoiceItem
    {
        public int Id { get; set; }
        public int RentalItemId { get; set; }
        public RentalItem RentalItem { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
} 