using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Hurtownia.Models
{
    public class Unit
    {

        public int Id { get; set; }

        [Required]
        [Display(Name = "Imie")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Minimalna wartość")]
        public int MinimalAmount { get; set; }
    }
}