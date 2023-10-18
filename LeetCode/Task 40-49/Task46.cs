using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace LeetCode.Task_40_49
{
    internal class Task46
    {
        public List<IList<int>> Permute(int[] nums)
        {
            List<IList<int>> result = new List<IList<int>>();
            int k = nums.Length;
            Permute(k,nums.ToList(),new List<int>(), result);
            return result;
        }
        public void Permute(int length,List<int> nums, List<int> list, List<IList<int>> result)
        {
            if (list.Count == length)
            {
                result.Add(list.ToList());
                return;
            }
            else if(nums.Count == 0)
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
                    Permute(length,new List<int>(nums), new List<int>(list), result);
                    list.RemoveAt(list.Count-1);
                    nums.Insert(0,o);
                }
            }

            return;
        }
    }
}
