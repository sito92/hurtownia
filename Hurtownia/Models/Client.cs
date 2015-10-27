using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

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

        //[Display(Name = "NIP")]
        //[StringLength(10, ErrorMessage = "NIP musi się składać z dziesięciu znaków")]
        //public string NIP { get; set; }

        //[Display(Name = "Nazwa firmy")]
        //public string CompanyName { get; set; }

        //[Required]
        //[Display(Name = "Numer telefonu")]
        //public string TelephoneNumber { get; set; }

        //[Required]
        //[Display(Name = "Adres e-mail")]
        //public string EMail {get; set;}

        [Required]
        [Display(Name = "Dane firmy")]
        public int CompanyContactInfoId { get; set; }

        [Required]
        [Display(Name = "Dane kontaktowe")]
        public int ClientContactInfoId { get; set; }

        [Required]
        [Display(Name = "Adres")]
        public int AddressId { get; set; } 

        [Required]
        [Display(Name = "Typ klienta")]
        public string ClientType { get; set; }

        public virtual CompanyContactInfo CompanyContactInfo { get; set; }
        public virtual ClientContactInfo ClientContactInfo { get; set; }
        public virtual Address Address { get; set; }
    }
}