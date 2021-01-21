using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Task35
    {
        public int SearchInsert(int[] nums, int target)
        {
            for (int i=0;i<nums.Length;i++)
            {
                if (nums[i]>=target)
                {
                    return i;
                }
            }
            return nums.Length;
        }
    }
}
