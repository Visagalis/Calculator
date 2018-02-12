using System;
using Calculator.Lib.Handlers;
using Calculator.Modules;
using Unity;

namespace Calculator
{
    class Program
    {

        static void Main(string[] args)
        {
            Calculate();
            Console.ReadLine();
        }

        private static void Calculate()
        {
            UnityBootstrapper containerBootstrapper = new UnityBootstrapper();
            var defaultHandler = containerBootstrapper.Container.Resolve<ICalculationHandler>();
            Lib.Calculator calc = new Lib.Calculator(defaultHandler);
            string a = "5", b = "5";
            Console.WriteLine(calc.Calculate(a, b));
        }
    }
}
