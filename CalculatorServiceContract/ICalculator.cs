using System.ServiceModel;

namespace CalculatorServiceContract
{
    [ServiceContract]
    public interface ICalculator
    {
        [OperationContract]
        int Sum(int a, int b);
        [OperationContract]
        int Subtact(int a, int b);
        [OperationContract]
        int Multiply(int a, int b);
        [OperationContract]
        double Divide(int a, int b);


    }
}
