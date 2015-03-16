﻿using System;
using System.Linq;

namespace Hurtownia.Interfaces
{
    public interface IRepository<T>
    {
        IQueryable<T> FindBy(System.Linq.Expressions.Expression<Func<T, bool>> predicate);
 
        void Add(T element);

        void Delete(T element);

        void SaveChanges();
    }
}
