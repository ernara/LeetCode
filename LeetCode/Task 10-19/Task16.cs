using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Task16
    {
        public int ThreeSumClosest(int[] nums, int target)
        {
            Dictionary<int, int> numbers2 = new Dictionary<int, int>();

            for (int i=0;i<nums.Length;i++)
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
                int count = Math.Min(3, v.Value);

                for (int i=0;i<count;i++)
                {
                    numbers.Add(v.Key);
                }
            }

            numbers.Sort();

            int best = numbers[0] + numbers[1] + numbers[2];

            int difference;

            int difference2;

            for (int i=0;i<numbers.Count-2;i++)
            {
                for (int y=i+1;y<numbers.Count-1;y++)
                {
                    difference = numbers[i] + numbers[y] + numbers[y + 1];
                    

                    for (int z=y+1;z<numbers.Count;z++)
                    {
                       
                        difference2 = numbers[i] + numbers[y] + numbers[z];

                        if (Math.Abs(target - difference2) < Math.Abs(target - best))
                        {
                            best = difference2;
                        }

                        if (Math.Abs(target-difference)<Math.Abs(target-difference2))
                        {
                            break;
                        }
                        else
                        {
                            difference = difference2;
                        }
                    }
                }
            }

            return best;
        }
    }
}
