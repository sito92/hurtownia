using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Hurtownia.Infrastructure;

namespace Hurtownia.Models.ViewModels
{
    public class ProductsViewModel
    {
        public IEnumerable<Product> Products { get; set; }

        public FilterProduct FilterProduct { get; set; }

    }
}