using System;
using System.ComponentModel.DataAnnotations;

namespace Hurtownia.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Nazwa produktu")]
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

        public int Amount { get; set; }
    }
}