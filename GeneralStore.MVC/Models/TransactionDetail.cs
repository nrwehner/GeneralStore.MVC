using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GeneralStore.MVC.Models
{
    public class TransactionDetail
    {
        public int TransactionID { get; set; }
        public string CustomerID { get; set; }
        public string CustomerFullName { get; set; }
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public DateTimeOffset TransactionDate { get; set; }
    }
}