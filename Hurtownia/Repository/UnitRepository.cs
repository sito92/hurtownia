using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Hurtownia.Interfaces;
using Hurtownia.Models;

namespace Hurtownia.Repository
{
    public class UnitRepository : GenericRepository<Unit,WholeSaleDbContext>,IUnitRepository
    {
        public IQueryable<Unit> GetUnitByName(string name)
        {
            return FindBy(u => u.Name == name);
        }
    }
}