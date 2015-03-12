using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Hurtownia.Models
{
    public class ProductType
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Imie")]
        public string Name { get; set; }
    }

    public class ProductTypeDbContext : DbContext
    {
        public DbSet<ProductType> ProductTypes { get; set; }
    }
}