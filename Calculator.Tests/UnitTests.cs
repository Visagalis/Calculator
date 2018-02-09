using Calculator.Lib.Handlers;
using Moq;
using NUnit.Framework;

namespace Calculator.Tests
{
    [TestFixture]
    public class UnitTests
    {
        private ICalculationHandler _calculationHandler;
        private Mock<ICalculationHandler> _calculationHandlerMock;

        [SetUp]
        public void Setup()
        {
            _calculationHandlerMock = new Mock<ICalculationHandler>();
            _calculationHandler = _calculationHandlerMock.Object;
        }

        [Test]
        public void calculate_calls_calculation_handler()
        {
            Lib.Calculator calc = new Lib.Calculator(_calculationHandler);
            calc.Calculate("a", "b");
            _calculationHandlerMock.Verify(m => m.Calculate("a","b"), Times.Once);
        }
    }
}
