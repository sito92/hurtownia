using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hurtownia.Models.ViewModels
{
    public class FilterProduct
    {
        public string Name { get; set; }
        public int? Ammount { get; set; }

        public int UnitId { get; set; }
        public int? MinPrice { get; set; }

        public int? MaxPrice { get; set; }
        public int ProductTypeId { get; set; }

        public bool IsFiltering { get; set; }
    }
}