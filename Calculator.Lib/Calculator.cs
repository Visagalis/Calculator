using Calculator.Lib.Handlers;

namespace Calculator.Lib
{
    public class Calculator
    {
        private ICalculationHandler _calculationHandler;

        public Calculator(ICalculationHandler calculationHandler)
        {
            _calculationHandler = calculationHandler;
        }

        public string Calculate(string a, string b)
        {
            var result = _calculationHandler.Calculate(a, b);
            return $"Calculated result: {result}";
        }
    }
}
