using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    class Task18
    {
        public IList<IList<int>> FourSum(int[] nums, int target)
        {
            Dictionary<int, int> numbers2 = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (numbers2.ContainsKey(nums[i]))
                {
                    numbers2[nums[i]]++;
                }
                else
                {
                    numbers2.Add(nums[i], 1);
                }
            }

            List<int> numbers = new List<int>();

            foreach (var v in numbers2)
            {
                int count = Math.Min(4, v.Value);

                for (int i = 0; i < count; i++)
                {
                    numbers.Add(v.Key);
                }
            }

            numbers.Sort();

            HashSet<string> checkResult = new HashSet<string>();

            int difference;

            List<int> list;

            for (int i = 0; i < numbers.Count - 3; i++)
            {
                for (int y = i + 1; y < numbers.Count - 2; y++)
                {
                    for (int z = y + 1; z < numbers.Count-1; z++)
                    {
                        for (int q = z + 1; q < numbers.Count; q++)
                        {
                            difference = numbers[i] + numbers[y] + numbers[z] + numbers[q];

                            if (difference==target)
                            {
                                list = new List<int>() { numbers[i], numbers[y], numbers[z], numbers[q] };
                                list.Sort();
                                checkResult.Add(String.Join(",",list));
                                break;
                            }
                        }
                    }

                }
            }

            int[][] result = new int[checkResult.Count][];

            int ii = 0;

            foreach (var v in checkResult)
            {
                result[ii] = new int[4];
                result[ii++] = v.Split(',').Select(Int32.Parse).ToArray();
            }

            return result;
        }
    }
}
