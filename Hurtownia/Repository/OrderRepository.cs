using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Hurtownia.Interfaces;
using Hurtownia.Models;

namespace Hurtownia.Repository
{
    public class OrderRepository : GenericRepository<Order,WholeSaleDbContext>,IOrderRepository
    {
        public IQueryable<Order> GerOrderByClient(Client client)
        {
            return FindBy(o => o.Client == client);
        }

        public IQueryable<Order> GetOrderByPaymentType(PaymentType paymentType)
        {
            return FindBy(o => o.PaymentType == paymentType);
        }

        public IQueryable<Order> GetOrderByEmployee(Employee employee)
        {
            return FindBy(o => o.Employee == employee);
        }

        public override void Save(Order element)
        {
            throw new NotImplementedException();
        }
    }
}