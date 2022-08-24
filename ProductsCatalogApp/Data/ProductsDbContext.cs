using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using ProductsCatalogApp.Entities;

namespace ProductsCatalogApp.Data
{

    public class ProductsDbContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\mssqllocaldb;Initial Catalog=ProductsCatalogDb2022EF;Integrated Security=True");
            optionsBuilder.LogTo(Console.WriteLine, LogLevel.Information);
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Catagory> Catagories { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<Customer> Customers { get; set; }


    }
}
