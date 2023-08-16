using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_CommercialAutomation.Models.Classes
{
    public class SalesMovement
    {
        [Key]
        public int SalesMovementID { get; set; }
        //ürüm
        //Cari
        //personel
        public DateTime Date { get; set; }
        public int Unit { get; set; }
        public decimal Piece { get; set; }
        public decimal Total { get; set; }

        public Product Product { get; set; }
        public Current Current { get; set; }
        public Employee Employee { get; set; }
    }
}