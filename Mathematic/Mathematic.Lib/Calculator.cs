namespace Mathematic.Lib
{
    public class Calculator
    {
        public IArithmeticEngine ArithmeticEngine { get; }

        public Calculator(IArithmeticEngine arithmeticEngine)
        {
            ArithmeticEngine = arithmeticEngine;
        }

        public int CircumferenceOfRectangle(int numA, int numB)
        {
            // C = 2 * (a + b)
            return this.ArithmeticEngine.Multiply(2, this.ArithmeticEngine.Add(numA, numB));
        }
    }
}
