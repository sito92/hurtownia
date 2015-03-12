using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

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