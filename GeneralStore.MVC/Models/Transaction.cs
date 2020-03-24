using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GeneralStore.MVC.Models
{
    public class Transaction
    {
        [Key]
        public int TransactionID { get; set; }
        [Required]
        [ForeignKey("CustomerID")]
        public string CustomerID { get; set; }
        public virtual Customer Customer { get; set; }
        [Required]
        [ForeignKey("ProductId")]
        public string ProductId { get; set; }
        public virtual Product Product { get; set; }
        [Required]
        public int Quantity { get; set; }
        public DateTimeOffset TransactionDate { get; set; }
    }
}