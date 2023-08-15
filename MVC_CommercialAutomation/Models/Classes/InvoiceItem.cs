using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVC_CommercialAutomation.Models.Classes
{
    public class InvoiceItem
    {
        [Key]
        public int InvoiceItemID { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(100)]
        public string InvoiceItemExplanation { get; set; }
        public int InvoiceItemQuantity { get; set; }
        public decimal InvoiceItemUnitPrice { get; set; }
        public decimal InvoiceItemAmount { get; set; }
        public Invoice Invoice { get; set; }
    }
}