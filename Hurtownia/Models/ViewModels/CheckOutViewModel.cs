using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hurtownia.Models.ViewModels
{
    public class CheckOutViewModel
    {
        public Cart Cart { get; set; }

        public Order Order { get; set; }
    }
}