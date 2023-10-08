using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Task_50_59
{
    internal class Task50
    {
        public double MyPow(double x, int n)
        {
            if (n == 0 || x == 1) return 1;
            if (n < 0)
            {
                x = 1 / x;
                n *= -n;
            }
            return CalculatePow(x, n);
        }

        private double CalculatePow(double x, long n)
        {
            if (n == 1) return x;
            double halfPow = CalculatePow(x, n / 2);

            return (n % 2 == 0) ? halfPow * halfPow : x * halfPow * halfPow;
        }
    }
}
