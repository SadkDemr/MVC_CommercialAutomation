using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_CommercialAutomation.Models.Classes
{
    public class Invoice
    {
        [Key]
        public int InvoiceID { get; set; }
        public string InvoiceSerialNo { get; set; }
        public string InvoiceOrderNo { get; set; }
        public DateTime Date { get; set; }
        public string TaxAdministration { get; set; }
        public DateTime Clock { get; set; }
        public string Submitter { get; set; }
        public string Receiver { get; set; }
    }
}