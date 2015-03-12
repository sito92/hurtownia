using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Hurtownia.Models
{
    public class PaymentType
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Typ płatności")]
        public string Type { get; set; }
    }

    public class PaymentTypeDbContext : DbContext
    {
        public DbSet<PaymentType> PaymentTypes { get; set; }
    }
}