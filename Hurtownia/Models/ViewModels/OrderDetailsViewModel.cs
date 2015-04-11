using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hurtownia.Models.ViewModels
{
    public class OrderDetailsViewModel
    {
        public Order Order { get; set; }
        public List<ProductGroup> ProductGroups { get; set; } 
    }
}