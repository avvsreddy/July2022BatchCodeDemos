﻿using System.Xml.Linq;

namespace LanguageEnhancements
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. List all products whose price in between 50K to 80K

            //2. Extract all products belongs to Laptops catagory
            //3. Extract/Show Product Name and Catagory Name only
            //4. Show the costliest product name 
            //5. Show the cheepest product name and its price
            //6. Show the 2nd and 3rd product details
            //7. List all products in assending order of their price
            //8. Count the no. of products belong to Tablets
            //9. Show which catagory has costly product
            //10. Show which catagory has less products
            //11. Save all products into XML document	

            // <products>
            //  <product>
            //        <productid>111</productid>
            //        <name>IPhone x</name>
            //        <price>70000</price>
            //   <product>
            //   <product>
            //

            //

            XDocument xml = new XDocument(new XElement("products",
                    from p in ProductsDB.GetProducts()
                    select new XElement("product",
                    new XElement("productid", p.ProductID), new XElement("name", p.Name), new XElement("price", p.Price)))
            );

            xml.Save("e:/products.xml");



        }

    }
    class ProductsDB
    {
        public static List<Product> GetProducts()
        {
            Catagory cat1 = new Catagory { CatagoryID = 101, Name = "Laptops" };
            Catagory cat2 = new Catagory { CatagoryID = 201, Name = "Mobiles" };
            Catagory cat3 = new Catagory { CatagoryID = 301, Name = "Tablets" };

            Product p1 = new Product { ProductID = 1, Name = "Dell XPS 13", Catagory = cat1, Price = 90000 };
            Product p2 = new Product { ProductID = 2, Name = "HP 430", Catagory = cat1, Price = 50000 };
            Product p3 = new Product { ProductID = 3, Name = "IPhone 6", Catagory = cat2, Price = 80000 };
            Product p4 = new Product { ProductID = 4, Name = "Galaxy S6", Catagory = cat2, Price = 74000 };
            Product p5 = new Product { ProductID = 5, Name = "IPad Pro", Catagory = cat3, Price = 44000 };

            cat1.Products.Add(p1);
            cat1.Products.Add(p2);
            cat2.Products.Add(p3);
            cat2.Products.Add(p4);
            cat3.Products.Add(p5);

            List<Product> products = new List<Product>();
            products.Add(p1);
            products.Add(p2);
            products.Add(p3);
            products.Add(p4);
            products.Add(p5);

            return products;
        }
    }
    class Product
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public Catagory Catagory { get; set; }
    }
    class Catagory
    {
        public int CatagoryID { get; set; }
        public string Name { get; set; }
        public List<Product> Products = new List<Product>();
    }
}
