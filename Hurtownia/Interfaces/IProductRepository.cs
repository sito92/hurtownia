using System;
using System.Collections.Generic;
using System.Linq;
using Hurtownia.Models;

namespace Hurtownia.Interfaces
{
    public interface IProductRepository:IRepository<Product>
    {
        //Pobranie produktu po nazwie
        Product GetProductByName(string name);
        Product GetProductById(int id);
        //Pobranie produktu po jednostce
        IQueryable<Product> GetProductByUnit(Unit unit);

        //Pobranie produktu po typie produktu
        IQueryable<Product> GetProductByProductType(ProductType productType);

        //Pobranie produktu po dacie ważności
        IQueryable<Product> GetProductByExpiryDate(DateTime expiryDate);

        //Pobranie produktu po cenie
        IQueryable<Product> GetProductByPrice(float price);

        IEnumerable<ProductType> GProductTypes();
    }
}
