using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Task41
    {
        public int FirstMissingPositive(int[] nums)
        {
            Dictionary<int, int> d = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (!d.ContainsKey(nums[i]))
                {
                    d.Add(nums[i], nums[i]);
                }

            }

            bool b = true;
            int ii = 1;

            while (b)
            {
                if (!d.ContainsKey(ii))
                {
                    return ii;
                }
                ii++;
            }
            return 0;
        }
    }
}
