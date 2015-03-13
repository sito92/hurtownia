using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hurtownia.Models;

namespace Hurtownia.Interfaces
{
    public interface IPaymentTypeRepository
    {
        //Pobranie typu płatności po nazwie płatności
        PaymentType GetPaymentTypeByPaymentTypeName(string paymentTypeName);
    }
}
