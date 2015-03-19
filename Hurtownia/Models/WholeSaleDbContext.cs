using System.Data.Entity;

namespace Hurtownia.Models
{
    public class WholeSaleDbContext : DbContext
    {
        public WholeSaleDbContext()
            : base("LocalConnection")
        {
            
        }

        public DbSet<Address> Addresses { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<PaymentType> PaymentTypes { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductList> ProductLists { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }
        public DbSet<Unit> Units { get; set; }
    }
}