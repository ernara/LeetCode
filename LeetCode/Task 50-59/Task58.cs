using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Task_50_59
{
    internal class Task58
    {
        public int LengthOfLastWord(string s)
        {
            if (s.Contains(' '))
            {
                int l = 1;
                for (int i = s.Length - 1; i > 0; i--)
                    if (s[i] != ' ')
                    {
                        i--;
                        for (; i >= 0; i--)
                        {
                            if (s[i] == ' ')
                            {
                                return l;
                            }
                            l++;
                        }
                    }
                return l;
            }

            return s.Length;
            
        }
    }
}
