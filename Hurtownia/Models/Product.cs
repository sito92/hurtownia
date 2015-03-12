using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Hurtownia.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Imie")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Jednostka")]
        public Unit Unit { get; set; }

        [Required]
        [Display(Name = "Typ produktu")]
        public ProductType ProductType { get; set; }

        [Required]
        [Display(Name = "Data ważności")]
        public DateTime ExpiryDate { get; set; }

        [Required]
        [Display(Name = "Cena")]
        public float Price { get; set; }
    }

    public class ProductDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
    }
}