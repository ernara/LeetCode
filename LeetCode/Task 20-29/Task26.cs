using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    class Task26
    {
        public int RemoveDuplicates(int[] nums)
        {
            if (nums.Length==0)
                return 0;

            int count = 0;

            for (int i=1;i<nums.Length;i++)
            {
                if (nums[i]>nums[count])
                {
                    nums[++count] = nums[i];
                }
            }

            return ++count;
        }
    }
}
