using System.ComponentModel.DataAnnotations;

namespace Hurtownia.Models
{
    public class ProductType
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Typ produktu")]
        public string Name { get; set; }
    }
}