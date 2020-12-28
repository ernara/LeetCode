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
            string s = Reverse(x.ToString());

            Console.WriteLine(s);
            return 0;
        }

        public string Reverse(string text)
        {
            if (text == null) return null;

            char[] array = text.ToCharArray();
            Array.Reverse(array);
            return new String(array);
        }
    }
}
