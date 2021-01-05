using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Task17
    {
        public IList<string> LetterCombinations(string digits)
        {

            if (digits.Length==0)
            {
                return new List<string>();
            }

            Dictionary<char, List<char>> numbers = new Dictionary<char, List<char>>();

            numbers.Add('2', new List<char>() { 'a', 'b', 'c' });
            numbers.Add('3', new List<char>() { 'd', 'e', 'f' });
            numbers.Add('4', new List<char>() { 'g', 'h', 'i' });
            numbers.Add('5', new List<char>() { 'j', 'k', 'l' });
            numbers.Add('6', new List<char>() { 'm', 'n', 'o' });
            numbers.Add('7', new List<char>() { 'p', 'q', 'r', 's' });
            numbers.Add('8', new List<char>() { 't', 'u', 'v' });
            numbers.Add('9', new List<char>() { 'w', 'x', 'y', 'z' });

            List<string> result = new List<string>();

            Result("", digits, numbers, result);

            return result;

        }

        public void Result (string s, string digits, Dictionary<char, List<char>> numbers, List<string> list)
        {
            if (s.Length==digits.Length)
            {
                list.Add(s);
            }
            else
            {
                for (int i=0;i<numbers[digits[s.Length]].Count;i++)
                {
                    Result(s +  numbers[digits[s.Length]][i],digits,numbers,list);
                }
               
            }
        }
    }
}
