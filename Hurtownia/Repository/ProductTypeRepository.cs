using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Hurtownia.Interfaces;
using Hurtownia.Models;

namespace Hurtownia.Repository
{
    public class ProductTypeRepository : GenericRepository<ProductType,WholeSaleDbContext>,IProductTypeRepository
    {
        public ProductType GetProductTypeByName(string name)
        {
            return FindBy(p => p.Name == name).FirstOrDefault();
        }


        public override void Save(ProductType element)
        {
            throw new NotImplementedException();
        }
    }
}