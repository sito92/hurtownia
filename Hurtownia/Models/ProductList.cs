using System.ComponentModel.DataAnnotations;

namespace Hurtownia.Models
{
    public class ProductList
    {
        public int Id { get; set; }

        [Display(Name = "Produkt")]
        public virtual Product Product { get; set; }

        [Display(Name = "Zamówienie")]
        public virtual Order Order { get; set; }

        [Display(Name = "Ilość")]
        public int Amount { get; set; }
    }
}