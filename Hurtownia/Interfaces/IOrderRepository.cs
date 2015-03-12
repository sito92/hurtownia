using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hurtownia.Models;

namespace Hurtownia.Interfaces
{
    public interface IOrderRepository : IRepository<Order>
    {
        //Pobranie zamówienia po kliencie
        IQueryable<Order> GerOrderByClient(Client client);

        //Pobranie zamówienia po typie płatności
        IQueryable<Order> GetOrderByPaymentType(PaymentType paymentType);

        //Pobranie zamówienia po pracowniku odpowiedzialnym za nie
        IQueryable<Order> GetOrderByEmployee(Employee employee);
    }
}
