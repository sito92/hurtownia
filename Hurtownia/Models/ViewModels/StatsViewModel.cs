using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hurtownia.Models.ViewModels
{
    public class StatsViewModel
    {
        public Employee Employee { get; set; }

        public List<Order> Orders { get; set; }

        public List<int> OrderHelperList { get; set; }
    }
}