using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.Lib.Handlers
{
    public interface ICalculationHandler
    {
        object Calculate(string a, string b);
    }
}
