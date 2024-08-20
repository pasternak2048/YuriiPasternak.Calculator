using YuriiPasternak.Calculator.Interfaces;

namespace YuriiPasternak.Calculator.Models
{
    public class CalculatorDouble : ICalculator<double>
    {
        public double Sum(double x, double y)
        {
            return x + y;
        }

        public double Min(double x, double y)
        {
            return x - y;
        }

        public double Mult(double x, double y)
        {
            return x * y;
        }

        public double Div(double x, double y)
        {
            if(y == 0)
            {
                Console.WriteLine("ERROR: YOU ARE NOT ABLE TO DIVIDE FOR ZERO.");
            }

            return x / y;
        }
    }
}
