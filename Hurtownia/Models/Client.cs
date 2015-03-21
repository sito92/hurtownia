using System.ComponentModel.DataAnnotations;

namespace Hurtownia.Models
{
    public class Client
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Imie")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Nazwisko")]
        public string Surname { get; set; }

        [Display(Name = "NIP")]
        [StringLength(10, ErrorMessage = "NIP musi się składać z dziesięciu znaków")]
        public string NIP { get; set; }

        [Display(Name = "Nazwa firmy")]
        public string CompanyName { get; set; }

        [Required]
        [Display(Name = "Numer telefonu")]
        public string TelephoneNumber { get; set; }

        [Required]
        [Display(Name = "Adres e-mail")]
        public string EMail {get; set;}

        [Required]
        public int AdressId { get; set; } 

        [Required]
        [Display(Name = "Typ klienta")]
        public string ClientType { get; set; }


        public Address Address { get; set; }
    }
}