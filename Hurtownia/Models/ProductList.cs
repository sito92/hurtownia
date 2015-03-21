using System.ComponentModel.DataAnnotations;

namespace Hurtownia.Models
{
    public class ProductList
    {
        public int Id { get; set; }

        [Display(Name = "Produkt")]
        public int ProductId { get; set; }


        [Display(Name = "Zamówienie")]
        public int OrderId { get; set; }

        [Display(Name = "Ilość")]
        public int Amount { get; set; }


        public virtual Product Product { get; set; }
        public virtual Order Order { get; set; }
    }
}