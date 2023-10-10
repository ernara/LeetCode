using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Task_20_29
{
    internal class Task22
    {
        public IList<string> GenerateParenthesis(int n)
        {
            List<string> result = new List<string>();
            GenerateParenthesis(n, 0, 0, "", result);
            return result; 
        }
        public void GenerateParenthesis(int n,int left, int right, string s, IList<string> result)
        {
            if (n == left && left==right)
            {
                result.Add(s);
            }
            else
            {
                if (left < n)
                {
                    GenerateParenthesis(n, left + 1, right, s + "(", result);
                }
                if (right < left)
                {
                    GenerateParenthesis(n, left, right+1, s + ")", result);
                }
            }
        }
    }
}
