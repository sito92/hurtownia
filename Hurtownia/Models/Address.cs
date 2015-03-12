using System.ComponentModel.DataAnnotations;

namespace Hurtownia.Models
{
    public class Address
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Miasto")]
        public string City { get; set; }

        [Required]
        [Display(Name = "Ulica")]
        public string Street { get; set; }

        [Required]
        [Display(Name = "Numer domu")]
        public int HomeNumber { get; set; }

        [Display(Name = "Numer mieszkania")]
        public int FlatNumber { get; set; }  
    }
}