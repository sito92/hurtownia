using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Hurtownia.Interfaces;
using Hurtownia.Models;

namespace Hurtownia.Repository
{
    public class ProductRepository : GenericRepository<Product,WholeSaleDbContext>,IProductRepository
    {
        private const string all = "Wszystkie";
        public Product GetProductByName(string name)
        {
            return FindBy(p => p.Name == name).FirstOrDefault();
        }

        public Product GetProductById(int id)
        {
            return FindBy(p => p.Id == id).FirstOrDefault();
        }

        public IQueryable<Product> GetProductByUnit(Unit unit)
        {
            return FindBy(p => p.Unit == unit);
        }

        public IQueryable<Product> GetProductByProductType(ProductType productType)
        {
            return FindBy(p => p.ProductType == productType);
        }

        public IQueryable<Product> GetProductByExpiryDate(DateTime expiryDate)
        {
            return FindBy(p => p.ExpiryDate == expiryDate);
        }

        public IQueryable<Product> GetProductByPrice(decimal price)
        {
            return FindBy(p => p.Price == price);
        }

        public IEnumerable<ProductType> GProductTypes()
        {
            var types = new List<ProductType> {new ProductType() {Name = all}};
            types.AddRange(GetAll().Select(x=>x.ProductType));
            return types;

        }

        public override void Save(Product element)
        {
            Product prod = GetProductById(element.Id);

            if (prod!=null)
            {
                //TODO Uzupełnić przepisywanie propercji
                prod.Name = element.Name;
                prod.Price = element.Price;
                prod.Amount = element.Amount;
                prod.ProductTypeID = element.ProductTypeID;
                prod.UnitId = element.UnitId;

                _entities.SaveChanges();
            }
        }
    }
}