// store n number of ints
//declare
//DynamicIntArray numbers = new DynamicIntArray();
DynamicArray<int> numbers = new DynamicArray<int>();
//store
numbers.Add(101);
numbers.Add(202);
numbers.Add(203);
numbers.Add(204);
numbers.Add(205);
numbers.Add(206);
numbers.Add(207);
numbers.Add(208);
numbers.Add(209);
numbers.Add(210);
numbers.Add(211);
numbers.Add(212);
numbers.Add(213);

numbers.Add(101);
numbers.Add(202);
numbers.Add(203);
numbers.Add(204);
numbers.Add(205);
numbers.Add(206);
numbers.Add(207);
numbers.Add(208);
numbers.Add(209);
numbers.Add(210);
numbers.Add(211);
numbers.Add(212);
numbers.Add(213);


//read
for (int i = 0; i < numbers.Count; i++)
{
    Console.WriteLine(numbers.Get(i));
}


DynamicDoubleArray dArray = new DynamicDoubleArray();
dArray.Add(10.5);

double d = dArray.Get(0);


DynamicArray<int> da = new DynamicArray<int>();
DynamicArray<double> dd = new DynamicArray<double>();
//DynamicArray<Product> dp = new DynamicArray<Product>();


public class DynamicArray<T> // generic class
{
    private T[] data = new T[10];
    int count = 0;
    public void Add(T n)
    {
        if (count < data.Length) // its empty
        {
            data[count++] = n;
        }
        else // its full
        {
            Array.Resize(ref data, data.Length * 2);
        }
    }

    public T Get(int i)
    {
        return data[i];
    }

    public int Count
    {
        get { return count; }

    }
}


public class DynamicIntArray
{
    private int[] data = new int[10];
    int count = 0;
    public void Add(int n)
    {
        if (count < data.Length) // its empty
        {
            data[count++] = n;
        }
        else // its full
        {
            //// create a new array
            //int[] temp = new int[data.Length * 2];
            //// copy old data into new array
            //Array.Copy(data, temp, data.Length);
            //temp[count++] = n;
            //data = temp;

            Array.Resize(ref data, data.Length * 2);
        }
    }

    public int Get(int i)
    {
        return data[i];
    }

    public int Count
    {
        get { return count; }

    }
}

public class DynamicDoubleArray
{
    private double[] data = new double[10];
    int count = 0;
    public void Add(double n)
    {
        if (count < data.Length) // its empty
        {
            data[count++] = n;
        }
        else // its full
        {
            Array.Resize(ref data, data.Length * 2);
        }
    }

    public double Get(int i)
    {
        return data[i];
    }

    public int Count
    {
        get { return count; }

    }
}

public class DynamicStringArray
{
    private string[] data = new string[10];
    int count = 0;
    public void Add(string n)
    {
        if (count < data.Length) // its empty
        {
            data[count++] = n;
        }
        else // its full
        {
            Array.Resize(ref data, data.Length * 2);
        }
    }

    public string Get(int i)
    {
        return data[i];
    }

    public int Count
    {
        get { return count; }

    }
}

