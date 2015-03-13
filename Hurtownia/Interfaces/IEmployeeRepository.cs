using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hurtownia.Models;

namespace Hurtownia.Interfaces
{
    public interface IEmployeeRepository
    {
        //Pobranie pracownika po imieniu
        IQueryable<Employee> GetEmployeeByName(string name);
    }
}
