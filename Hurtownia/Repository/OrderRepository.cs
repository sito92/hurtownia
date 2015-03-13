using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Hurtownia.Interfaces;
using Hurtownia.Models;

namespace Hurtownia.Repository
{
    public class OrderRepository : IOrderRepository
    {
        private WholeSaleDbContext _dbContext;

        public OrderRepository()
        {
            _dbContext = new WholeSaleDbContext();
        }

        public Order GetById(int id)
        {
            return _dbContext.Orders.Find(id);
        }

        public IQueryable<Order> FindBy(Func<Order, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public void Add(Order element)
        {
            _dbContext.Orders.Add(element);
        }

        public void Delete(Order element)
        {
            _dbContext.Orders.Remove(element);
        }

        public void SaveChanges()
        {
            _dbContext.SaveChanges();
        }

        public IQueryable<Order> GerOrderByClient(Client client)
        {
            return _dbContext.Orders.Where(order => order.Client == client);
        }

        public IQueryable<Order> GetOrderByPaymentType(PaymentType paymentType)
        {
            return _dbContext.Orders.Where(order => order.PaymentType == paymentType);
        }

        public IQueryable<Order> GetOrderByEmployee(Employee employee)
        {
            return _dbContext.Orders.Where(order => order.Employee == employee);
        }
    }
}