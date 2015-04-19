using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Hurtownia.Models.ViewModels
{
    public class FilterProduct
    {
        [Display(Name = "Nazwa produktu")]
        public string Name { get; set; }

        [Range(1, Int32.MaxValue, ErrorMessage = "Ilość musi być liczbą naturalną")]
        [Display(Name = "Ilość")]
        public int? Ammount { get; set; }

        [Display(Name = "Jednostka")]
        public int UnitId { get; set; }

        [Range(0, Int32.MaxValue, ErrorMessage = "Cena minimalna nie może być mniejsza od 0")]
        [Display(Name = "Cena minimalna")]
        public decimal? MinPrice { get; set; }


        [Range(1, Int32.MaxValue, ErrorMessage = "Cena maksymalna musi być większa od 0")] //tu powinnismy urzyć MinPrice, ale dzikie rozwiązania są na stackoverflow
        [Display(Name = "Cena maksymalna")]
        public decimal? MaxPrice { get; set; }
        
        [Display(Name = "Typ produktu")]
        public int ProductTypeId { get; set; }

        public bool IsFiltering { get; set; }
    }
}