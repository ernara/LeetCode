using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    class Task7
    {
        public int Reverse(int x)
        {
            long sum = 0;

            while (x != 0)
            {
                if (Math.Abs(sum * 10) > Int32.MaxValue)
                {
                    return 0;
                }
                sum *= 10;
                sum += x % 10;
                x /= 10;
            }

            return (int)sum;
        }
    }
}
