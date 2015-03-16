﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Hurtownia.Interfaces;
using Hurtownia.Models;

namespace Hurtownia.Repository
{
    public class ProductRepository : GenericRepository<Product,WholeSaleDbContext>,IProductRepository
    {
        public Product GetProductByName(string name)
        {
            return FindBy(p => p.Name == name).FirstOrDefault();
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

        public IQueryable<Product> GetProductByPrice(float price)
        {
            return FindBy(p => p.Price == price);
        }
    }
}