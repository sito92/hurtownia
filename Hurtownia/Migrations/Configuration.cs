using Hurtownia.Models;

namespace Hurtownia.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Hurtownia.Models.WholeSaleDbContext>
    {
        private WholeSaleDbContext context;

        public Configuration()
        {
            context = new WholeSaleDbContext();
            AutomaticMigrationsEnabled = true;
            ContextKey = "Hurtownia.Models.WholeSaleDbContext";
        }

        protected override void Seed(Hurtownia.Models.WholeSaleDbContext context)
        {

        }
    }
}
