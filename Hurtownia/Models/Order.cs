using System;
using System.ComponentModel.DataAnnotations;
namespace Hurtownia.Models
{
    public class Order
    {
        public int Id { get; set; }

        [Range(1, Int32.MaxValue, ErrorMessage = "Musisz podać konkretnego klienta")]
        [Display(Name = "Klient")]
        public int ClientId { get; set; }

        [Range(1, Int32.MaxValue, ErrorMessage = "Musisz podać konkretny typ płatności")]
        [Display(Name = "Typ płatności")]
        public int PaymentTypeId { get; set; }

        [Range(1, Int32.MaxValue, ErrorMessage = "Musisz podać konkretnego pracownika")]
        [Display(Name = "Pracownik")]
        public int EmployeeId { get; set; }

        public virtual Client Client { get; set; }

        public virtual PaymentType PaymentType { get; set; }

        public virtual Employee Employee { get; set; }
    }
}