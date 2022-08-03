


// store single int

int a = 10; //scalar

// store 10 ints
Console.Write("Enter how many numbers you want to store :");
int size = int.Parse(Console.ReadLine());
int[] numbers = new int[size];

// store the data

for (int i = 0; i < numbers.Length; i++)
{
    Console.Write($"Enter number {i + 1}: ");
    numbers[i] = int.Parse(Console.ReadLine());
}

// find the sum

int sum = 0;
for (int i = 0; i < numbers.Length; i++)
{
    sum += numbers[i];
}
Console.WriteLine($"Sum of all numbers {sum}");

// display all values

foreach (int item in numbers)
{
    Console.WriteLine(item);
}

// find avg
double avg = numbers.Average();
sum = numbers.Sum();
int max = numbers.Max();
int min = numbers.Min();

// sort
Array.Sort(numbers);
int[] numbers2 = new int[numbers.Length];
Array.Copy(numbers, numbers2, numbers.Length);


string[] words = new string[5];
words[0] = "one";
words[1] = "two";

string[] words1 = new string[3] { "one", "two", "three" };
string[] words2 = new string[] { "one", "two", "three" };
string[] words3 = { "one", "two", "three" };

// multi dimentional arrays
int[,] twod = new int[3, 5];

// Jagged Arrays
int[][] scores = new int[3][];
scores[0] = new int[5];
scores[1] = new int[2];
scores[2] = new int[10];
