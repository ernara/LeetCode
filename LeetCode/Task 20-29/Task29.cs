using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Task_20_29
{
    internal class Task29
    {
        public int Divide(int dividend, int divisor)
        {
            if (dividend == int.MaxValue && divisor == 1)
                return int.MaxValue;
            else if (dividend == int.MaxValue && divisor == -1)
                return int.MinValue + 1;
            else if ((dividend == int.MinValue && divisor == -1))
                return int.MaxValue;
            else if (((dividend == int.MinValue && divisor == 1)))
                return int.MinValue;
            else return dividend / divisor;
        }
    }
}
