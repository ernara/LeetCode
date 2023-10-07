using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    internal class Task55
    {
        public bool CanJump(int[] nums)
        {
            int jumps = nums[0]-1;
            for (int i=1;i<nums.Length; i++)
            {
                if (jumps == -1)
                {
                    return false;
                }

                if (nums[i] > jumps)
                {
                    jumps = nums[i];
                }

                jumps--;
            }

            return true;
        }
    }
}
