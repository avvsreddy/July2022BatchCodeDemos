// See https://aka.ms/new-console-template for more information
class Program
{
    public static void Main()
    {

        // Object Initialization Syntax

        var p1 = new
        {
            Id = 111,
            Name = "IPhone X",
            Price = 90000
        };

        Console.WriteLine(p1.Id);
        Console.WriteLine(p1.Name);
        Console.WriteLine(p1.Price);
        //p.Id = 111;
        //p.Name = "IPhone X";
        //p.Price = 90000;

        //Product p2 = new Product { Name = "IWatch" };
        //Product p3 = new Product { Id = 222 };
        //Product p33 = new Product { Id = 234, Name = "Abc" };
        //Product p4 = new Product { Price = 80000, Name = "Xyz" };

    }
}


//class Product
//{
//    public int Id { get; set; }
//    public string Name { get; set; }
//    public int Price { get; set; }

//    //private Product()
//    //{

//    //}

//    //public Product()
//    //{
//    //    Id = 1;
//    //    Name = "Unknown";
//    //    Price = 100;
//    //}

//    //public Product(int id)
//    //{
//    //    Id = id;
//    //}

//    //public Product(int id, string name) : this(id)
//    //{
//    //    //Id = id;
//    //    //Product(id);
//    //    Name = name;
//    //}

//    //public Product(int id, string name, int price) : this(id, name)
//    //{
//    //    //Id = id;
//    //    //Name = name;
//    //    Price = price;
//    //}

//    //public Product(string name)
//    //{
//    //    Name = name;
//    //}

//    //public Product(int price, string name)
//    //{

//    //}
//}