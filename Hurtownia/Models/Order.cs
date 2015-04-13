using System.ComponentModel.DataAnnotations;
namespace Hurtownia.Models
{
    public class Order
    {
        public int Id { get; set; }

        [Display(Name = "Klient")]
        public int ClientId { get; set; }

        [Display(Name = "Typ płatności")]
        public int PaymentTypeId { get; set; }

        [Display(Name = "Pracownik")]
        public int EmployeeId { get; set; }

        public virtual Client Client { get; set; }

        public virtual PaymentType PaymentType { get; set; }

        public virtual Employee Employee { get; set; }
    }
}