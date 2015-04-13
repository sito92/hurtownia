using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Hurtownia.Models.ViewModels
{
    public class FilterProduct
    {
        public string Name { get; set; }
        public int? Ammount { get; set; }

        [Display(Name = "Jednostka")]
        public int UnitId { get; set; }

        public decimal? MinPrice { get; set; }

        public decimal? MaxPrice { get; set; }
        
        [Display(Name = "Typ produktu")]
        public int ProductTypeId { get; set; }

        public bool IsFiltering { get; set; }
    }
}