using System;

namespace CalculatorIISConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;
            int sum = 0;
            ServiceReference1.CalculatorClient proxy = new ServiceReference1.CalculatorClient();
            sum = proxy.Sum(a, b);
            Console.WriteLine($"the sum of {a} and {b} is {sum}");
        }
    }
}
