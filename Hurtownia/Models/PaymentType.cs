using System.ComponentModel.DataAnnotations;

namespace Hurtownia.Models
{
    public class PaymentType
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Typ płatności")]
        public string Type { get; set; }
    }
}