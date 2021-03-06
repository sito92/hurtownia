﻿using System.ComponentModel.DataAnnotations;

namespace Hurtownia.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Imie")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Nazwisko")]
        public string Surname { get; set; }

        [Required]
        [Display(Name = "Login")]
        public string Login { get; set; }

        [Required]
        [Display(Name = "Hasło")]
        public string Password { get; set; }

        [Required]
        [Display(Name = "Numer telefonu")]
        public string TelephoneNumber { get; set; }

        [Required]
        [Display(Name = "Adres e-mail")]
        public string EMail { get; set; }
    }
}