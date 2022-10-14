using System;

namespace CalculatorClientApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CalculatorServiceReference.CalculatorClient calculator = new CalculatorServiceReference.CalculatorClient();
            Console.WriteLine(calculator.Sum(10, 20));
        }
    }
}
