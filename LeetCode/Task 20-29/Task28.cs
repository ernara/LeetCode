using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Task28
    {
        public int StrStr(string haystack, string needle)
        {
            if (haystack.Contains(needle))
            {
                for (int i = 0; i < haystack.Length; i++)
                {
                    if (haystack[i..(needle.Length + i)] == needle)
                    {
                        return i;
                    }
                }
            }
            return -1;
        }
    }
}
