using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVC_CommercialAutomation.Models.Classes
{
    public class Expense
    {
        [Key]
        public int ExpenseID { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(200)]
        public string ExpenseIExplanation { get; set; }
        public DateTime Date { get; set; }
        public decimal ExpenseAmount { get; set; }

    }
}