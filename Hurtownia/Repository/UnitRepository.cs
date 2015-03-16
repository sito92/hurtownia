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
        public Unit GetUnitByName(string name)
        {
            return FindBy(u => u.Name == name).FirstOrDefault();
        }

        public override void Save(Unit element)
        {
            throw new NotImplementedException();
        }
    }
}