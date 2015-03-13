using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Hurtownia.Interfaces;
using Hurtownia.Models;

namespace Hurtownia.Repository
{
    public class ClientRepository : GenericRepository<Client,WholeSaleDbContext>,IClientRepository
    {
        public IQueryable<Client> GetClientBySurname(string surname)
        {
            return FindBy(c => c.Surname == surname);
        }
    }
}