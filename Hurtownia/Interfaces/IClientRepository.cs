using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hurtownia.Models;

namespace Hurtownia.Interfaces
{
    public interface IClientRepository : IRepository<Client>
    {
        //Pobranie klienta po imieniu
        IQueryable<Client> GetClientBySurname(string surname);
    }
}
