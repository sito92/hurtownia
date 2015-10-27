using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using Hurtownia.Interfaces;
using Hurtownia.Models;
using Hurtownia.Repository;

namespace Hurtownia.Repository
{
    public class ClientRepository : GenericRepository<Client,WholeSaleDbContext>,IClientRepository
    {
        private WholeSaleDbContext context;

        public ClientRepository()
        {
            context = new WholeSaleDbContext();
        }

        public IQueryable<Client> GetClientBySurname(string surname)
        {
            return FindBy(c => c.Surname == surname);
        }

        public override void Save(Client element)
        {
            throw new NotImplementedException();
        }

        public void ClientFakerInsert(int amountOfClients)
        {
            context.Clients.AddOrUpdate(x => x.Name, Enumerable.Range(1, amountOfClients).Select(p => new Client()
            {
                Name = Faker.NameFaker.FirstName(),
                ClientType = Faker.NameFaker.FemaleFirstName(),
                Surname = Faker.NameFaker.LastName(),
                ClientContactInfoId = ClientContactInfoFaker(),
                CompanyContactInfoId = CompanyContactInfoFaker(),
                AddressId = AddressFaker()
            }).ToArray());

            //var a = new Client()
            //{
            //    Name = Faker.NameFaker.FirstName(),
            //    ClientType = Faker.NameFaker.FemaleFirstName(),
            //    Surname = Faker.NameFaker.LastName(),
            //    ClientContactInfoId = ClientContactInfoFaker(),
            //    CompanyContactInfoId = CompanyContactInfoFaker(),
            //    AddressId = AddressFaker()
            //};

            context.SaveChanges();
        }

        private int ClientContactInfoFaker()
        {
            var clientContactInfo = new ClientContactInfo()
            {
                EMail = Faker.InternetFaker.Email(),
                TelephoneNumber = Faker.PhoneFaker.Phone()
            };

            context.ClientContactInfos.AddOrUpdate(clientContactInfo);
            context.SaveChanges();

            return clientContactInfo.Id;
        }

        private int CompanyContactInfoFaker()
        {
            var companyContactInfo = new CompanyContactInfo()
            {
                CompanyName = Faker.CompanyFaker.Name(),
                NIP = Faker.StringFaker.Numeric(10)
            };

            context.CompanyContactInfos.AddOrUpdate(companyContactInfo);
            context.SaveChanges();

            return companyContactInfo.Id;
        }

        public int AddressFaker()
        {
            var address = new Address()
            {
                City = Faker.LocationFaker.City(),
                FlatNumber = Faker.LocationFaker.StreetNumber(),
                HomeNumber = Faker.NumberFaker.Number(1, 150),
                Street = Faker.LocationFaker.Street()
            };

            context.Addresses.AddOrUpdate(address);
            context.SaveChanges();

            return address.Id;
        }
    }
}