namespace Hurtownia.Models
{
    public class Order
    {
        public int Id { get; set; }

        public Client Client { get; set; }

        public PaymentType PaymentType { get; set; }

        public Employee Employee { get; set; }
    }
}