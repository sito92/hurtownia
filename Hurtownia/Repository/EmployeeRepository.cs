using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Hurtownia.Interfaces;
using Hurtownia.Models;

namespace Hurtownia.Repository
{
    public class EmployeeRepository : GenericRepository<Employee,WholeSaleDbContext>,IEmployeeRepository
    {
        public IQueryable<Employee> GetEmployeeByName(string name)
        {
            return FindBy(e => e.Name == name);
        }

        public override void Save(Employee element)
        {
            throw new NotImplementedException();
        }
    }
}