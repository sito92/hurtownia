using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Hurtownia.Models.ViewModels
{
    public class FakerAmountViewModel
    {
        //[Range(1,500)]
        public int Amount { get; set; }
    }
}