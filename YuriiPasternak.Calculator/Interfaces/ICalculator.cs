namespace YuriiPasternak.Calculator.Interfaces
{
    public interface ICalculator<T>
    {
        public T Sum(T x, T y);

        public T Min(T x, T y);

        public T Mult(T x, T y);

        public T Div(T x, T y);
    }
}
