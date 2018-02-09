namespace Calculator.Lib.Handlers
{
    public class AdditionCalculationHandler: ICalculationHandler
    {
        public object Calculate(string a, string b)
        {
            return int.Parse(a) + int.Parse(b);
        }
    }
}
