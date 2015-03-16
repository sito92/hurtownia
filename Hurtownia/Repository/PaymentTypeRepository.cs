using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Hurtownia.Interfaces;
using Hurtownia.Models;

namespace Hurtownia.Repository
{
    public class PaymentTypeRepository :GenericRepository<PaymentType,WholeSaleDbContext>,IPaymentTypeRepository
    {
        public PaymentType GetPaymentTypeByPaymentTypeName(string paymentTypeName)
        {
            return FindBy(p => p.Type == paymentTypeName).FirstOrDefault();
        }

        public override void Save(PaymentType element)
        {
            throw new NotImplementedException();
        }
    }
}