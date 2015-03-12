using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Hurtownia.Models
{
    public class ProductList
    {
        public int Id { get; set; }

        [Display(Name = "Produkt")]
        public Product Product { get; set; }

        [Display(Name = "Ilość")]
        public int Amount { get; set; }
    }
}