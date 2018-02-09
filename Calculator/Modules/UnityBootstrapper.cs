using System;
using Unity;

namespace Calculator.Modules
{
    class UnityBootstrapper : IDisposable
    {
        public IUnityContainer Container { get; }

        public UnityBootstrapper()
        {
            Container = new UnityContainer();
            Container.AddExtension(new CalculatorModule());
        }

        public void Dispose()
        {
            Container.Dispose();
        }
    }
}
