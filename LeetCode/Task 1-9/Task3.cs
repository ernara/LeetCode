using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    /*Given a string s, find the length of the longest substring without repeating characters.
     
    Constraints:

    0 <= s.length <= 5 * 104
    s consists of English letters, digits, symbols and spaces.*/
    class Task3
    {
        public int LengthOfLongestSubstring(string s)
        {
            int max = 0;
            //to know where the substring started
            int pointer = 0;
            //to collect substring letters
            HashSet<char> hash = new HashSet<char>();
            for (int i=0;i<s.Length;i++)
            {
                if (!hash.Contains(s[i]))
                {
                    hash.Add(s[i]); 
                }
                else
                {
                    //to check if it was biggest substring
                    if (hash.Count>max)
                    {
                        max = hash.Count; 
                    }
                    //remove letters from substring beggining
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
