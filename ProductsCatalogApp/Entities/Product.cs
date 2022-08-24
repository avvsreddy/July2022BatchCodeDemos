using System.ComponentModel.DataAnnotations;

namespace ProductsCatalogApp.Entities
{
    public class Product
    {
        public int ProductID { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        public int Price { get; set; }
        public string Brand { get; set; }
        public Catagory Catagory { get; set; }

        public List<Supplier> Suppliers { get; set; } = new List<Supplier>();
    }
    public class Catagory
    {
        public int CatagoryID { get; set; }
        public string Name { get; set; }
        public List<Product> Products { get; set; } = new List<Product>();
    }
    public class Supplier : Person
    {
        //public int SupplierID { get; set; }
        //public string Name { get; set; }

        public int Rank { get; set; }
        public string GST { get; set; }
        public List<Product> Products { get; set; } = new List<Product>();
    }

    public class Customer : Person
    {
        public string CustomerType { get; set; }
        public double Discount { get; set; }
    }

    public class Person
    {
        public int PersonID { get; set; }
        public string Name { get; set; }

    }
}
