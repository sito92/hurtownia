using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using Hurtownia.Interfaces;
using Hurtownia.Models;

namespace Hurtownia.Repository
{
    public class AddressRepository : GenericRepository<Client,WholeSaleDbContext>,IClientRepository
    {
        private WholeSaleDbContext context;

        public override void Save(Client element)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Client> GetClientBySurname(string surname)
        {
            throw new NotImplementedException();
        }
    }
}