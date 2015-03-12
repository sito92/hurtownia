using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Hurtownia.Interfaces;
using Hurtownia.Models;

namespace Hurtownia.Repository
{
    public class PaymentTypeRepository :IPaymentTypeRepository
    {
        private WholeSaleDbContext _dbContext;

        public PaymentTypeRepository()
        {
            _dbContext = new WholeSaleDbContext();
        }

        public PaymentType GetById(int id)
        {
            return _dbContext.PaymentTypes.Find(id);
        }

        public PaymentType GetPaymentTypeByPaymentTypeName(string paymentTypeName)
        {
            return _dbContext.PaymentTypes.FirstOrDefault(paymentType => paymentType.Type == paymentTypeName);
        }

        public void Add(PaymentType element)
        {
            _dbContext.PaymentTypes.Add(element);
        }

        public void Delete(PaymentType element)
        {
            _dbContext.PaymentTypes.Remove(element);
        }

        public void SaveChanges()
        {
            _dbContext.SaveChanges();
        }
    }
}