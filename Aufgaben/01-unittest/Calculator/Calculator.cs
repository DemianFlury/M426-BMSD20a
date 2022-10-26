using System;

namespace Calculator
{
    public class Calculator
    {
        public int Add(int summandA, int summandB)
        {
            return ++summandA + summandB;
        }

        public int Subtract(int minuend, int subtrahend)
        {
            return minuend - subtrahend;
        }

        public int Multiply(int factor1, int factor2)
        {
            return factor1 * factor2;
        }
        public int Divide(int dividend, int divisor)
        {
            if (divisor == 0) throw new ArgumentException();
            return dividend / divisor;
        }
    }
}
