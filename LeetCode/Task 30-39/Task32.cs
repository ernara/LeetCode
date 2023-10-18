using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Task_30_39
{
    internal class Task32
    {
        public int LongestValidParentheses(string s)
        {

            int max = 0;

            for (int i = 0; i < s.Length; i++)
            {
                int current = 0;
                int open = 0;
                int closed = 0;
                for (int y=i;y<s.Length;y++)
                {
                    if (s[y] =='(')
                    {
                        open++;
                    }
                    else if (open>closed)
                    {
                        closed++;
                        current++;
                        if (current * 2 > max && open == closed)
                        {
                            max = current * 2;
                        }
                    }
                    else
                    {
                        break;
                    }
                }
                
            }
            return max;
        }
    }
}
