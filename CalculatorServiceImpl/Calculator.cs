using CalculatorServiceContract;

namespace CalculatorServiceImpl
{
    public class Calculator : ICalculator
    {
        public double Divide(int a, int b)
        {
            return a / b;
        }

        public int Multiply(int a, int b)
        {
            return a * b;
        }

        public int Subtact(int a, int b)
        {
            return a - b;
        }

        public int Sum(int a, int b)
        {
            return a + b;
        }
    }
}
