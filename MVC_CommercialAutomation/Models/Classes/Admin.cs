using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_CommercialAutomation.Models.Classes
{
    public class Admin
    {
        public int AdminID { get; set; }
        public string AdminName { get; set; }
        public string AdminPass { get; set; }
        public string AdminAuthority { get; set; }
    }
}