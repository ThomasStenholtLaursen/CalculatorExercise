using System;

namespace Calculator.Application
{
    class Program
    {
        static void Main(string[] args)
        {
            Library.Calculator calc = new Library.Calculator();

            var changes = 1;

            changes = 2; //changes

            #region Simple Test of each Method
            double v1 = 5;
            double v2 = 10;

            var t1 = calc.Add(v1, v2);
            var t2 = calc.Subtract(v1, v2);
            var t3 = calc.Multiply(v1, v2);
            var t4 = calc.Power(v1, v2);

            Console.WriteLine("Add test:\nExpected result: " + Convert.ToDouble(v1 + v2) + " Calculator result: " + t1);
            Console.WriteLine("\nSubtract test:\nExpected result: " + Convert.ToDouble(v1 - v2) + " Calculator result: " + t2);
            Console.WriteLine("\nMultiply test:\nExpected result: " + Convert.ToDouble(v1 * v2) + " Calculator result: " + t3);
            Console.WriteLine("\nPower test:\nExpected result: " + Convert.ToDouble(Math.Pow(v1, v2)) + " Calculator result: " + t4);
            #endregion       

            Console.WriteLine("\n");

            #region Sequence of Add-test
            var t_add1 = calc.Add(10, 23);

            if (t_add1 == 10 + 23 && t_add1 == 23 + 10)
            {
                Console.WriteLine("t_add1 success!");
            }
            else
            {
                Console.WriteLine("t_add1 failed!");
            }
            #endregion

            #region Sequence of Subtract-test
            var t_sub1 = calc.Subtract(20, 30);

            if (t_sub1 == 20 - 30 && t_sub1 != 30 - 20)
            {
                Console.WriteLine("t_sub1 success!");
            }
            else
            {
                Console.WriteLine("t_sub1 failed!");
            }
            #endregion

            #region Sequence of Multiply-test

            var t_mul1 = calc.Multiply(5, 2);

            if (t_mul1 == 5 * 2 && t_mul1 == 2 * 5)
            {
                Console.WriteLine("t_mul1 success!");
            }
            else
            {
                Console.WriteLine("t_mul1 failed!");
            }
            #endregion

            #region Sequence of Power-test
            var t_pow1 = calc.Power(2, 5);

            if (t_pow1 == (2 * 2 * 2 * 2 * 2))
            {
                Console.WriteLine("t_pow1 success!");
            }
            else
            {
                Console.WriteLine("t_pow1 failed!");
            }
            #endregion
        }
    }
}
