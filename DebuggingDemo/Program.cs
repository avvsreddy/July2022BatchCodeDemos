namespace DebuggingDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Calculator calc = new Calculator();
            int sum = calc.FindSum(1, 1, 1, 1, 1);
            Console.WriteLine($"The sum is {sum}");
        }
    }

    class Calculator
    {
        public int FindSum(params int[] numbers)
        {
            int sum = 0;
            for (int i = 1; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }
    }
}

// Sidharth
// Paras Jain
// Shashanksagar singh
