using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Task_50_59
{
    internal class Task53
    {
        public int MaxSubArray(int[] nums)
        {
            int result = int.MinValue;
            int best = int.MinValue;
            int index = 0;

            for (int i = 0;i<nums.Length;i++)
            {
                if (nums[i]>=0)
                {
                    result = nums[i];
                    best = nums[i];
                    index = i+1;
                    break;
                }
                if (nums[i]>best)
                {
                    best= nums[i];
                }
            }

            if (best<0) { return best; }
            

            for (int i = index; i<nums.Length; i++)
            {
                result += nums[i];
                
                if (result > best)
                {
                    best = result;
                }

                if (result < 0)
                {
                    result = 0;
                }
            }

            return best;
        }
    }
}
