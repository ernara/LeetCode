using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Task_30_39
{
    internal class Task30
    {
        public IList<int> FindSubstring(string s, string[] words)
        {
            List<int> result = new List<int>();

            Dictionary<string, int> d = words
           .GroupBy(word => word)
           .ToDictionary(group => group.Key, group => group.Count());


            int wordsLength = words[0].Length;
            int wordsCount = words.Length;

            Dictionary<string, int> now;
            int sum;
            int y;
            string current;

            for (int i = 0; i < s.Length + 1 - (wordsLength * wordsCount); i++)
            {
                now = new Dictionary<string, int>();
                sum = 0;
                y = i;

                while (sum < wordsCount)
                {
                    current = s.Substring(y, wordsLength);
                    if (!now.ContainsKey(current))
                    {
                        now.Add(current, 1);
                    }
                    else
                    {
                        now[current]++;
                    }
                    sum++;
                    y += wordsLength;
                }

                if (DictionariesAreEqual(d, now))
                {
                    result.Add(i);
                }
            }

            return result;
        }

        static bool DictionariesAreEqual(Dictionary<string, int> dict1, Dictionary<string, int> dict2)
        {
            return dict1.Count == dict2.Count && dict1.All(item => dict2.ContainsKey(item.Key) && dict2[item.Key] == item.Value);
        }
    }
}
