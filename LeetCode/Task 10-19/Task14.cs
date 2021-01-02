using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    class Task14
    {
        public string LongestCommonPrefix(string[] strs)
        {
            string s = "";

            char c = ' ';

            if(strs.Length==0)
            {
                return s;
            }

            int smallestWord = 200;
            int biggestWord = 0;
            int biggestWordIndex = 0;

            for (int i=0;i<strs.Length;i++)
            {
                if (strs[i].Length<smallestWord)
                {
                    smallestWord = strs[i].Length;
                }
                if (strs[i].Length>biggestWord)
                {
                    biggestWord = strs[i].Length;
                    biggestWordIndex = i;
                }
            }

            if (biggestWord==0)
            {
                return s;
            }


            for (int i=0;i< smallestWord; i++)
            {
                c = strs[biggestWordIndex][i];
                for (int y = 0; y < strs.Length; y++)
                {
                    if (strs[y].Length>i)
                    {
                        if (strs[y][i] !=c)
                        {
                            return s;
                        }
                    }
                }
                s += c;
            }

            return s;
        }
    }
}
