
int fno;
int sno;
int sum = 0;
while (true)
{
    try
    {

        Console.Write("Enter First No: ");
        fno = int.Parse(Console.ReadLine());

        Console.Write("Enter Second No: ");
        sno = int.Parse(Console.ReadLine());
        SimpleMath sm = new SimpleMath();
        sum = sm.Sum(fno, sno);

        Console.WriteLine($"The sum of {fno} and {sno} is {sum}");
    }

    catch (FormatException ex)
    {
        Console.WriteLine("Enter only numbers");
    }
    //catch (OverflowException ex)
    //{
    //    Console.WriteLine("Enter small int numbers only");
    //}
    //catch (IOException ex)
    //{

    //}
    //catch (OutOfMemoryException ex)
    //{

    //}
    catch (Exception ex) // catch all 
    {
        Console.WriteLine("Some error occured, try later");
    }
}
