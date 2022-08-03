// store n number of ints
//declare
DynamicIntArray numbers = new DynamicIntArray();

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