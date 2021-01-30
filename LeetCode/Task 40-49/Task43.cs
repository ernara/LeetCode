using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;

namespace LeetCode
{
    class Task43
    {
        public string Multiply(string num1, string num2)
        {
            return (BigInteger.Parse(num1)* BigInteger.Parse(num2)).ToString();
        }
    }
}
