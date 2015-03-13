﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Hurtownia.Interfaces
{
    public abstract class GenericRepository<T,C> : IRepository<T> where T : class where C : DbContext, new() 
    {
        private C _entities = new C();

        public IQueryable<T> FindBy(Func<T,bool> predicate)
        {
            var query = (IQueryable<T>) _entities.Set<T>().Where(predicate);
            return query;
        }

        public virtual void Add(T element)
        {
            _entities.Set<T>().Add(element);
        }

        public virtual void Delete(T element)
        {
            _entities.Set<T>().Remove(element);
        }

        public virtual void SaveChanges()
        {
            _entities.SaveChanges();
        }
    }
}