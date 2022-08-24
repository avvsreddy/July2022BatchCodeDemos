using Microsoft.EntityFrameworkCore;
using ProductsCatalogApp.Data;
using ProductsCatalogApp.Entities;

namespace ProductsCatalogApp.UI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Get all customers

            ProductsDbContext db = new ProductsDbContext();
            var customers = from c in db.Customers
                            select c;

            foreach (Customer cust in customers)
            {
                Console.WriteLine(cust.Name);
            }
        }

        private static void PeopleInsert()
        {
            // add customer info
            Customer c = new Customer { Name = "customer 1", CustomerType = "silver", Discount = 5 };
            Supplier s = new Supplier { Name = "supplier 1", GST = "423423sdfsdf34", Rank = 3 };
            ProductsDbContext db = new ProductsDbContext();
            db.Customers.Add(c);
            db.Suppliers.Add(s);

            db.SaveChanges();
        }

        private static void insert2()
        {
            // add one new catagory with two new products
            Catagory c = new Catagory { Name = "Smart Watch" };
            Product p1 = new Product { Name = "IWatch", Price = 67000, Brand = "Apple" };
            Product p2 = new Product { Name = "Galaxy Gear", Price = 70000, Brand = "Samsum" };
            c.Products.Add(p1);
            c.Products.Add(p2);

            ProductsDbContext db = new ProductsDbContext();
            db.Catagories.Add(c);
            //db.Products.Add(p1);
            //db.Products.Add(p2);
            db.SaveChanges();
        }

        private static void Select2()
        {
            ProductsDbContext db = new ProductsDbContext();
            // display pname and cname
            var allProducts = from p in db.Products.Include("Catagory")

                              select p;

            foreach (var p in allProducts)
            {
                Console.WriteLine($"{p.Name}\t{p.Catagory.Name}");
            }
        }

        private static void Add2()
        {
            ProductsDbContext db = new ProductsDbContext();
            var catagory = (from cat in db.Catagories
                            where cat.Name == "Laptop"
                            select cat).FirstOrDefault();
            // create new product
            Product p1 = new Product { Name = "MacBookPro", Price = 999999, Brand = "Apple", Catagory = catagory };

            db.Products.Add(p1);
            db.SaveChanges();
        }

        private static ProductsDbContext Add()
        {
            // add new catagory and new product
            // oo code
            Catagory c = new Catagory { Name = "Laptop" };
            Product p = new Product { Name = "Dell XPS 12", Price = 75000, Brand = "Dell", Catagory = c };

            ProductsDbContext db = new ProductsDbContext();
            db.Products.Add(p);
            db.Catagories.Add(c);
            db.SaveChanges();
            return db;
        }
    }
}