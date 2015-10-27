using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Hurtownia.Models
{
    public class ClientContactInfo
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Numer telefonu")]
        public string TelephoneNumber { get; set; }

        [Required]
        [Display(Name = "Adres e-mail")]
        public string EMail { get; set; }
    }
}