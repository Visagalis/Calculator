using Calculator.Lib.Handlers;
using Unity;
using Unity.Extension;

namespace Calculator.Modules
{
    class CalculatorModule : UnityContainerExtension
    {
        protected override void Initialize()
        {
            Container.RegisterInstance<ICalculationHandler>(new AdditionCalculationHandler());
        }
    }
}
