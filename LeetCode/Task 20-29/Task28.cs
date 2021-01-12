using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Task28
    {
        public int StrStr(string haystack, string needle)
        {

            if (needle.Length<1)
            {
                return 0;
            }

            if (needle.Length==1)
            {
                if (haystack.Contains(needle))
                {
                    if (haystack.Length==1)
                    {
                        return 0;
                    }
                    return 2;
                }
                return -1;
            }

            for (int i=0;i<haystack.Length-needle.Length;i++)
            {
                Console.WriteLine($"{haystack.Substring(i, needle.Length)}");
                if (haystack[i]==needle[0] && haystack.Substring(i,needle.Length)==needle)
                {
                    return 2;
                }
            }

            return -1;
        }
    }
}
