using CalculatorServiceImpl;
using System;
using System.ServiceModel;

namespace CalculatorServiceHost
{
    public class Program
    {
        static void Main(string[] args)
        {
            Uri baseUri = new Uri("http://localhost:8733/CalculatorServiceContract/Service/");
            ServiceHost host = new ServiceHost(typeof(Calculator), baseUri);
            Console.WriteLine($"Calculator service is running at {baseUri.ToString()}");
            host.Open();
            Console.WriteLine("Press enter key to stop...");
            Console.ReadLine();
        }
    }
}
