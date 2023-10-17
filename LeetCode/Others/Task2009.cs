using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    internal class Task2009
    {
        public int MinOperations(int[] nums)
        {
            HashSet<int> hashset = new HashSet<int>();

            for (int i = 0;i<nums.Length;i++)
            {
                hashset.Add(nums[i]);
            }

            int changes = nums.Length-1;

            for (int i = 0; i < nums.Length; i++)
            {
                int cchanges= nums.Length - 1;
                for (int y = nums[i]+1; y < nums[i]+nums.Length;y++)
                {
                    if (hashset.Contains(y))
                    {
                        cchanges--;
                    }
                }
                if (cchanges<changes)
                {
                    changes= cchanges;
                }
            }

            return changes;
        }
    }
}
