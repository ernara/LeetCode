using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Task_40_49
{
    internal class Task47
    {
        public List<IList<int>> PermuteUnique(int[] nums)
        {
            List<IList<int>> result = new List<IList<int>>();
            int k = nums.Length;
            PermuteUnique(k, nums.ToList(), new List<int>(), result, new HashSet<string>());
            return result;
        }
        public void PermuteUnique(int length, List<int> nums, List<int> list, List<IList<int>> result, HashSet<string> h)
        {
            if (list.Count == length)
            {
                string s = string.Join(",", list);
                if (!h.Contains(s))
                {
                    h.Add(s);
                    result.Add(list);
                    return;
                }
                else
                {
                    return;
                }
            }
            else if (nums.Count == 0)
            {
                return;
            }
            else
            {
                for (int i = 0; i < nums.Count; i++)
                {
                    int o = nums[i];
                    list.Add(o);
                    nums.RemoveAt(i);
                    PermuteUnique(length, new List<int>(nums), new List<int>(list), result, h);
                    list.RemoveAt(list.Count - 1);
                    nums.Insert(0, o);
                }
            }

            return;
        }
    }
}
