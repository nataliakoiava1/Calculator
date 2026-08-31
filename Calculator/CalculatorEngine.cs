using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace projectsBeginer
{
    public class CalculatorEngine
    {
        private readonly Dictionary<string, Func<double, double, double>> Operation =
           new Dictionary<string, Func<double, double, double>>
           {
                { "+", (a, b) => a + b},
                { "-", (a, b) => a - b},
                { "*", (a, b) => a * b},
                { "/", (a, b) => b == 0 ? throw new DivideByZeroException() : a / b},
                { "sqrt", (a, b) => a < 0 ? throw new ArgumentException("Invalide input") : Math.Sqrt(a) },
           };

        public bool IsValidOperator(string op) => Operation.ContainsKey(op);

        public double Calculate(string op, double first, double second)
        {
            if (!Operation.ContainsKey(op))
            {
                throw new InvalidOperationException($"Unsupported operator: {op}");
            }
            return Operation[op](first, second);
        }
    }
}

