using System;

namespace Calculator.Library
{
    public class Calculator
    {
        public double Accumulator { get; private set; }

        public void Clear()
        {
            Accumulator = 0.0;
        }

        public double Add(double a, double b)
        {
            Accumulator = a + b;
            return Accumulator;
        }

        public double Subtract(double a, double b)
        {
            Accumulator = a - b;
            return Accumulator;
        }
        public double Multiply(double a, double b)
        {
            Accumulator = a * b;
            return Accumulator;
        }

        public double Power(double x, double exp)
        {
            Accumulator = Math.Pow(x, exp);
            return Accumulator;
        }

        public double Divide(double dividend, double divisor)
        {

            if (divisor == 0)
            {
                throw new DivideByZeroException("Cannot divide by ZERO");
            }

            Accumulator = (dividend / divisor);
            return Accumulator;

        }

        public double Add(double addend)
        {
            return addend + Accumulator;
        }
        public double Subtract(double subtractor)
        {
            return Accumulator - subtractor;
        }
        public double Multiply(double multiplier)
        {
            return multiplier * Accumulator;
        }

        public double Power(double exponent)
        {
            return Math.Pow(exponent, Accumulator);
        }

        public double Divide(double divisor)
        {
            return (Accumulator / divisor);
        }
    }
}
