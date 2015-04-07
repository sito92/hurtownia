using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hurtownia.Models
{
    public class Cart
    {
        public Cart()
        {
            Products = new List<Product>();
        }
        public List<Product> Products { get; set; }
    }
}