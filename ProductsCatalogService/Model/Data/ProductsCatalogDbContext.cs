using Microsoft.EntityFrameworkCore;
using ProductsCatalogService.Model.Entities;

namespace ProductsCatalogService.Model.Data
{
    public class ProductsCatalogDbContext : DbContext
    {
        // configure the db
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\mssqllocaldb;Initial Catalog=ProductsCatalogDb2022July;Integrated Security=True");
        }

        // configure the tables
        public DbSet<Product> Products { get; set; }
    }
}
