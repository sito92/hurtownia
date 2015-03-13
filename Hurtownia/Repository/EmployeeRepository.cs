using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Hurtownia.Interfaces;
using Hurtownia.Models;

namespace Hurtownia.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private WholeSaleDbContext _dbContext;

        public EmployeeRepository()
        {
            _dbContext = new WholeSaleDbContext();
        }

        public Employee GetById(int id)
        {
            return _dbContext.Employees.Find(id);
        }

        public IQueryable<Employee> FindBy(Func<Employee, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public void Add(Employee element)
        {
            _dbContext.Employees.Add(element);
        }

        public void Delete(Employee element)
        {
            _dbContext.Employees.Remove(element);
        }

        public void SaveChanges()
        {
            _dbContext.SaveChanges();
        }

        public IQueryable<Employee> GetEmployeeByName(string name)
        {
            return _dbContext.Employees.Where(employee => employee.Name == name);
        }
    }
}