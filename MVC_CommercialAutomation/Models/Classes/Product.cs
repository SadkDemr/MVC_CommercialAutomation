using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_CommercialAutomation.Models.Classes
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }
        public string ProductName{ get; set; }
        public string Brand { get; set; }
        public short Stock { get; set; }
        public decimal PurchasePrice { get; set; }
        public decimal SalePrice { get; set; }
        public bool Status { get; set; }
        public string ProductImage { get; set; }
    }
}