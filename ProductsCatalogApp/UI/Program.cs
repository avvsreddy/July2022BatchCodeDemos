using ProductsCatalogApp.Data;
using ProductsCatalogApp.Entities;

namespace ProductsCatalogApp.UI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // add new catagory and new product
            // oo code
            //Catagory c = new Catagory { Name = "Laptop" };
            //Product p = new Product { Name = "Dell XPS 12", Price = 75000, Brand = "Dell", Catagory = c };

            ProductsDbContext db = new ProductsDbContext();
            //db.Products.Add(p);
            //db.Catagories.Add(c);
            //db.SaveChanges();

            // Add new product with the existing catagory
            // get existing catagory

            // LINQ
            var catagory = (from cat in db.Catagories
                            where cat.Name == "Laptop"
                            select cat).FirstOrDefault();
            // create new product
            Product p1 = new Product { Name = "MacBookPro", Price = 999999, Brand = "Apple", Catagory = catagory };

            db.Products.Add(p1);
            db.SaveChanges();
        }
    }
}