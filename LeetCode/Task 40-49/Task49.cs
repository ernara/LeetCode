using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Task_40_49
{
    internal class Task49
    {
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            List<IList<string>> list = new List<IList<string>>();
            for (int i = 0; i < strs.Length; i++)
            {
                bool flag = false;
                string s = SortStringAscending(strs[i]);
                for(int j = 0; j < list.Count; j++)
                {
                    if ((s == list[j][0]))
                    {
                        flag = true;
                        list[j].Add(strs[i]);
                        break;
                    }
                }

                if (flag==false)
                {
                    list.Add(new List<string>() { s, strs[i] });
                }
            }

            for (int j = 0; j < list.Count; j++)
            {
                list[j].RemoveAt(0);
            }

                return list;
        }

        public static string SortStringAscending(string input)
        {
            char[] characters = input.ToCharArray();
            Array.Sort(characters);
            return new string(characters);
        }

    }
}
