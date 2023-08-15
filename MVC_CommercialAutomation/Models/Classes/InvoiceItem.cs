using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_CommercialAutomation.Models.Classes
{
    public class InvoiceItem
    {
        [Key]
        public int InvoiceItemID { get; set; }
        public string InvoiceItemExplanation { get; set; }
        public string InvoiceItemQuantity { get; set; }
        public string InvoiceItemUnitPrice { get; set; }
        public string InvoiceItemAmount { get; set; }
    }
}