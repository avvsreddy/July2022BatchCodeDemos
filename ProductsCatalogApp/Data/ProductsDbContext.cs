using Microsoft.EntityFrameworkCore;
using ProductsCatalogApp.Entities;

namespace ProductsCatalogApp.Data
{

    public class ProductsDbContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\mssqllocaldb;Initial Catalog=ProductsCatalogDb2022EF;Integrated Security=True");
            //optionsBuilder.LogTo(Console.WriteLine, LogLevel.Information);
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Catagory> Catagories { get; set; }


    }
}
