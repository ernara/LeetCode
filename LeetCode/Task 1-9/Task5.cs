using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    class Task5
    {
        public string LongestPalindrome(string s)
        {
            byte[,] array = new byte[s.Length, s.Length];

            int[] biggestP = new int[] { 0, 0 }; 

            for (int i=0;i<s.Length;i++)
            {
                array[i,i] = 1;
                if (i+1<s.Length && s[i] == s[i+1])
                {
                    array[i, i+1] = 1;
                    biggestP[0] = i;
                    biggestP[1] = i+1;
                }
            }

            for (int i=2;i<s.Length;i++)
            {
                for (int y=0;y+i<s.Length;y++) 
                {
                    if (array[y+1,y+i-1]==1 && s[y]==s[y+i])
                    {
                        array[y, y+i] = 1;
                        biggestP[0] = y;
                        biggestP[1] = y + i;
                    }
                }
            }

            if (s.Length==0)
            {
                return "";
            }

            return s.Substring(biggestP[0],biggestP[1]-biggestP[0]+1);
        }

    }
}
