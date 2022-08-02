
//Shape s1 = new Shape { H = 10, W = 5 };
//s1.Draw();
//Console.WriteLine(s1.CalculateArea());

IShape r1 = new Rectangle { H = 10, W = 6 };
r1.Draw();
Console.WriteLine(r1.CalculateArea());

IShape t1 = new Triangle { W = 10, H = 6 };
t1.Draw();
Console.WriteLine(t1.CalculateArea());


//Rectangle r22 = new Shape();

// Base class ref variable can hold derived type object


interface IShape
{
    int W { get; set; }
    int H { get; set; }

    void Draw();
    //{
    //    Console.WriteLine("Drawing Shape...");
    //}

    int CalculateArea();
    //{
    //    return W * H;
    //}
}

class Rectangle : IShape // Inheritance - IS A - Genaralization
{
    public int W { get; set; }
    public int H { get; set; }
    //public void Draw()
    //{
    //    Console.WriteLine("Drawing Shape...");
    //}
    public void Draw()
    {
        Console.WriteLine("Drawing Rectangle...");
    }
    public int CalculateArea()
    {
        return H * W;
    }
}

class Triangle : IShape // IS-A 
{
    public int W { get; set; }
    public int H { get; set; }
    public void Draw()
    {
        Console.WriteLine("Drawing Triangle...");
    }

    public int CalculateArea()
    {
        int area = H * W;
        return area / 2;
    }
}