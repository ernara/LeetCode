using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Task_30_39
{
    internal class Task33
    {
        public int Search(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == target)
                    return i;
            }
            return -1;
        }
    }
}
