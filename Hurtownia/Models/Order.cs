namespace Hurtownia.Models
{
    public class Order
    {
        public int Id { get; set; }


        public int ClientId { get; set; }
        public int PaymentTypeId { get; set; }
        public int EmployeeId { get; set; }
        public virtual Client Client { get; set; }

        public virtual PaymentType PaymentType { get; set; }

        public virtual Employee Employee { get; set; }
    }
}