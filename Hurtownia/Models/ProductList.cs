using System.ComponentModel.DataAnnotations;

namespace Hurtownia.Models
{
    public class ProductList
    {
        public int Id { get; set; }

        [Display(Name = "Produkt")]
        public Product Product { get; set; }

        [Display(Name = "Zamówienie")]
        public Order Order { get; set; }

        [Display(Name = "Ilość")]
        public int Amount { get; set; }
    }
}