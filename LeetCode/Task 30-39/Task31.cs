using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace LeetCode.Task_30_39
{
    internal class Task31
    {
        public void Check2(int[] nums)
        {
            for (int i = nums.Length-2; i >= 0; i--)
            {
                for(int y = nums.Length - 1; y > i; y--)
                {
                    if (nums[y] > nums[i])
                    {
                        (nums[y], nums[i]) = (nums[i], nums[y]);
                        SortTheRest(i+1, nums);
                        goto exitLoops;
                    }
                }
            }
        exitLoops:;
        }

        public void SortTheRest(int i, int[] nums)
        {
            int[] newArray = nums.Skip(i).ToArray();
            Array.Sort( newArray );

            int y = i;
            for(;i<nums.Length;i++)
            {
                nums[i] = newArray[i-y];
            }
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
                for (int i = 0; i<nums.Length; i++)
                {
                    nums[i] = first[i];
                }
            }
            else
            {
                Check2(nums);
            }
        }

        
    }
}
