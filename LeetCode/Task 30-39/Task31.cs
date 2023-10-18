using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Task_30_39
{
    internal class Task31
    {
        public void Check2(int[] nums)
        {
            
        }
        public void NextPermutation(int[] nums)
        {
            Check(nums);
        }

        public void Check(int[] nums)
        {
            int[] first = nums.ToArray();
            Array.Sort(first);
            int[] last = first.ToArray();
            Array.Reverse(last);

            if (nums.SequenceEqual(last))
            {
                nums = first.ToArray();
            }
            else
            {
                Check2(nums);
            }
        }

        
    }
}
