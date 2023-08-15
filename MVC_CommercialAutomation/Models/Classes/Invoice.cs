using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVC_CommercialAutomation.Models.Classes
{
    public class Invoice
    {
        [Key]
        public int InvoiceID { get; set; }

        [Column(TypeName = "Char")]
        [StringLength(1)]
        public string InvoiceSerialNo { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(6)]
        public string InvoiceOrderNo { get; set; }
        public DateTime Date { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(70)]
        public string TaxAdministration { get; set; }
        public DateTime Clock { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string Submitter { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string Receiver { get; set; }
        public ICollection<InvoiceItem> InvoiceItems { get; set; }
    }
}