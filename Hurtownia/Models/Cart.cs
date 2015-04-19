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
            Products = new List<ProductGroup>();


        }

        public void Add(Product product)
        {
            if (Products.Exists(x => x.Product.Id == product.Id))
            {
                var pg = Products.Find(x => x.Product.Id == product.Id);
                pg.Amount++;
            }
            else
            {
                Products.Add(new ProductGroup() { Amount = 1, Product = product });
            }
        }

        public List<ProductGroup> Products { get; set; }
        
        public double TotalCost
        {
            get
            {
                var summary = 0.0;

                foreach (var g in Products)
                {
                   summary += g.OrderCost;
                };

                return summary;
            }
        }
    }
}