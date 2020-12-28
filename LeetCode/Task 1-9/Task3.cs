using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Task3
    {
        public int LengthOfLongestSubstring(string s)
        {
            int max = 0;
            int pointer = 0;

            HashSet<char> hash = new HashSet<char>();

            for (int i=0;i<s.Length;i++)
            {
                if (!hash.Contains(s[i]))
                {
                    hash.Add(s[i]); 
                }
                else
                {
                    if (hash.Count>max)
                    {
                        max = hash.Count; 
                    }
                    while (hash.Contains(s[i]))
                    {
                        hash.Remove(s[pointer]);
                        pointer++;
                    }
                    hash.Add(s[i]);
                }
            }

            if (hash.Count > max)
            {
                max = hash.Count;
            }

            return max;
        }
    }
}
