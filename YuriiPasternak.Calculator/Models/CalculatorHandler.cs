using YuriiPasternak.Calculator.Interfaces;

namespace YuriiPasternak.Calculator.Models
{
    public static class CalculatorHandler<T>
    {
        public static void Calculate(T a, T b, string operation, ICalculator<T> calc, out T? result)
        {
            result = operation switch
            {
                "+" => calc.Sum(a, b),
                "-" => calc.Min(a, b),
                "*" => calc.Mult(a, b),
                "/" => calc.Div(a, b),
                _ => default
            };
        }
    }
}
