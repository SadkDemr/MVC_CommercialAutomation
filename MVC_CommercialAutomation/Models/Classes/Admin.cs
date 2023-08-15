using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_CommercialAutomation.Models.Classes
{
    public class Admin
    {
        [Key]
        public int AdminID { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(10)]
        public string AdminName { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string AdminPass { get; set; }

        [Column(TypeName = "Char")]
        [StringLength(1)]
        public string AdminAuthority { get; set; }
    }
}