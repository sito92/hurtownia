using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Hurtownia.Models
{
    public class Order
    {
        public int Id { get; set; }

        public Client Client { get; set; }

        public PaymentType PaymentType { get; set; }

        public Employee Employee { get; set; }

        public ProductList ProductList { get; set; }
    }
}