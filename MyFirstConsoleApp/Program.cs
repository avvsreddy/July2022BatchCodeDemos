// IO Operations

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine("Welcome to my first console app");
}

//while (true)
//{

//}

//do
//{

//} while (true);

// accept two ints and calculate the sum and display the result

int fno;
int sno;
int sum = 0;

Console.Write("Enter first no: ");
fno = int.Parse(Console.ReadLine());
Console.Write("Enter second no: ");
sno = int.Parse(Console.ReadLine());

sum = fno + sno;

Console.WriteLine($"The sum of {fno} and {sno} is {sum}");

int max = 0;

if (fno > sno)
    max = fno;
else
    max = sno;

Console.WriteLine($"The maximum of {fno} and {sno} is {max}");


