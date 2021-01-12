using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Task20
    {
        public bool IsValid(string s)
        {
            if (s.Length % 2 != 0)
            {
                return false;
            }

            Stack<char> stack = new Stack<char>();

            Dictionary<char, char> dicionary = new Dictionary<char, char>();
            dicionary.Add(']', '[');
            dicionary.Add(')', '(');
            dicionary.Add('}', '{');

            for (int i = 0; i < s.Length; i++)
            {
                if (stack.Count != 0 && dicionary.ContainsKey(s[i]) && stack.Peek() == dicionary[s[i]])
                {
                    stack.Pop();
                }
                else
                {
                    stack.Push(s[i]);
                }
            }

            return stack.Count == 0;
        }
    }
}
