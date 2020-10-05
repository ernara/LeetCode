using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Task1
    {
        public int[] TwoSum(int[] nums, int target)
        {
            HashSet<int> h = new HashSet<int>(nums);

            for (int i=0;i<nums.Length;i++)
            {
                if (h.Contains(target-nums[i]))
                {
                    for (int y=i+1;y<nums.Length;y++)
                    {
                        if (nums[i]+nums[y]==target)
                        {
                            return new int[] { i, y };
                        }
                    }
                }
            }

            return new int[] { };

        }
    }
}
