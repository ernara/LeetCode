using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    class Task15
    {
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            Dictionary<int, List<int>> numbers = new Dictionary<int, List<int>>();

            HashSet<string> check = new HashSet<string>();

            List<List<int>> result = new List<List<int>>();

            Dictionary<int, int> howmany = new Dictionary<int, int>();
           
           
            for (int i=0;i<nums.Length;i++)
            {
                if (howmany.ContainsKey(nums[i]))
                {
                    howmany[nums[i]]++;
                }
                else
                {
                    howmany.Add(nums[i], 1);
                }
            }


            List<int> nums2 = new List<int>();
            int value;

            foreach (var v in howmany)
            {
                value = Math.Min(3, v.Value);
                for (int i=0;i<value;i++)
                {
                    nums2.Add(v.Key);
                }    
            }

            for (int i = 0; i < nums2.Count; i++)
            {
                if (numbers.ContainsKey(nums2[i]))
                {
                    numbers[nums2[i]].Add(i);
                }
                else
                {
                    numbers.Add(nums2[i],new List<int>() { i });
                }
            }

            List<int> list;

            for (int i = 0; i < nums2.Count; i++)
            {
                for (int y = i + 1; y < nums2.Count; y++)
                {
                    value = -nums2[i] - nums2[y];
                    if (numbers.ContainsKey(value))
                    {
                       for (int z=0;z<numbers[value].Count;z++)
                        {
                            if (y<numbers[value][z])
                            {
                                list = new List<int>() { nums2[i], nums2[y], value };
                                list.Sort();

                                string a = string.Join(',', list);

                                check.Add(a);
                                break;
                            }
                        }
                    }
                }
            }

            foreach (var v in check)
            {
                var number = v.Split(',').Select(Int32.Parse).ToList();
                result.Add(number);
            }

            return result.ToArray();
        }
    }
}
