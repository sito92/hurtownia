using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Hurtownia.Interfaces;
using Hurtownia.Models;

namespace Hurtownia.Repository
{
    public class ClientRepository : IClientRepository
    {
        private WholeSaleDbContext _dbContext;

        public ClientRepository()
        {
            _dbContext = new WholeSaleDbContext();
        }

        public Client GetById(int id)
        {
            return _dbContext.Clients.Find(id);
        }

        public void Add(Client element)
        {
            _dbContext.Clients.Add(element);
        }

        public void Delete(Client element)
        {
            _dbContext.Clients.Remove(element);
        }

        public void SaveChanges()
        {
            _dbContext.SaveChanges();
        }

        public IQueryable<Client> GetClientBySurname(string surname)
        {
            return _dbContext.Clients.Where(client => client.Surname == surname);
        }
    }
}