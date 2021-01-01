using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Task13
    {
        public int RomanToInt(string s)
        {
            int result = 0;
            Dictionary<string, int> Numbers = new Dictionary<string, int>() {
                {"I",1},
                {"IV",4},
                {"V",5},
                {"IX",9},
                {"X",10},
                {"XL",40},
                {"L",50},
                {"XC",90},
                {"C",100},
                {"CD",400},
                {"D",500},
                {"CM",900},
                {"M",1000},
            };

            for (int i=0;i<s.Length;i++)
            {
                if (i+1<s.Length && Numbers.ContainsKey(s[i].ToString() + s[i + 1].ToString()))
                {
                    result += Numbers[s[i].ToString() + s[i + 1].ToString()];
                    i++;
                }
                else
                {
                    result += Numbers[s[i].ToString()];
                }
            }

            return result;
        }
    }
}
