using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hurtownia.Models
{
    public class ProductGroup
    {
        public Product Product { get; set; }
        public int Amount { get; set; }
        public double OrderCost { get { return Amount * (double)Product.Price; }}
    }
}