﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CalculatorClientApp.CalculatorServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CalculatorServiceReference.ICalculator")]
    public interface ICalculator {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculator/Sum", ReplyAction="http://tempuri.org/ICalculator/SumResponse")]
        int Sum(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculator/Sum", ReplyAction="http://tempuri.org/ICalculator/SumResponse")]
        System.Threading.Tasks.Task<int> SumAsync(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculator/Subtact", ReplyAction="http://tempuri.org/ICalculator/SubtactResponse")]
        int Subtact(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculator/Subtact", ReplyAction="http://tempuri.org/ICalculator/SubtactResponse")]
        System.Threading.Tasks.Task<int> SubtactAsync(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculator/Multiply", ReplyAction="http://tempuri.org/ICalculator/MultiplyResponse")]
        int Multiply(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculator/Multiply", ReplyAction="http://tempuri.org/ICalculator/MultiplyResponse")]
        System.Threading.Tasks.Task<int> MultiplyAsync(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculator/Divide", ReplyAction="http://tempuri.org/ICalculator/DivideResponse")]
        double Divide(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculator/Divide", ReplyAction="http://tempuri.org/ICalculator/DivideResponse")]
        System.Threading.Tasks.Task<double> DivideAsync(int a, int b);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICalculatorChannel : CalculatorClientApp.CalculatorServiceReference.ICalculator, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CalculatorClient : System.ServiceModel.ClientBase<CalculatorClientApp.CalculatorServiceReference.ICalculator>, CalculatorClientApp.CalculatorServiceReference.ICalculator {
        
        public CalculatorClient() {
        }
        
        public CalculatorClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CalculatorClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CalculatorClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CalculatorClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int Sum(int a, int b) {
            return base.Channel.Sum(a, b);
        }
        
        public System.Threading.Tasks.Task<int> SumAsync(int a, int b) {
            return base.Channel.SumAsync(a, b);
        }
        
        public int Subtact(int a, int b) {
            return base.Channel.Subtact(a, b);
        }
        
        public System.Threading.Tasks.Task<int> SubtactAsync(int a, int b) {
            return base.Channel.SubtactAsync(a, b);
        }
        
        public int Multiply(int a, int b) {
            return base.Channel.Multiply(a, b);
        }
        
        public System.Threading.Tasks.Task<int> MultiplyAsync(int a, int b) {
            return base.Channel.MultiplyAsync(a, b);
        }
        
        public double Divide(int a, int b) {
            return base.Channel.Divide(a, b);
        }
        
        public System.Threading.Tasks.Task<double> DivideAsync(int a, int b) {
            return base.Channel.DivideAsync(a, b);
        }
    }
}
