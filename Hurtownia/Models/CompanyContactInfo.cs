using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Hurtownia.Models
{
    public class CompanyContactInfo
    {
        public int Id { get; set; }

        [Display(Name = "NIP")]
        [StringLength(10, ErrorMessage = "NIP musi się składać z dziesięciu znaków")]
        public string NIP { get; set; }

        [Display(Name = "Nazwa firmy")]
        public string CompanyName { get; set; }
    }
}