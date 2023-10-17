using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Task_40_49
{
    internal class Task45
    {
        public int Jump(int[] nums)
        {
            if (nums.Length == 1) return 0;

            Dictionary<int, int> d = new Dictionary<int, int>();
            Jump(nums, 0, 0, d);
            return d[nums.Length - 1];
        }

        public void Jump(int[] nums, int i, int jumps, Dictionary<int, int> d)
        {
            if (i>=nums.Length-1)
            {
                return;
            }
            else if (nums[i]==0)
            {
                return;
            }
            else
            {
                for (int y = nums[i];y>0;y--)
                {
                    if (!d.ContainsKey(i+y))
                    {
                        d.Add(i + y, jumps + 1);
                        Jump(nums, i + y, jumps + 1, d);
                    }
                    else if (d[i+y] > jumps+1)
                    {
                        d[i + y] = jumps + 1;
                        Jump(nums, i + y, jumps + 1, d);
                    }
                    else
                    {
                        return;
                    }
                }
            }
        }
    }
}
