using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Task_30_39
{
    internal class Task34
    {
        public int[] SearchRange(int[] nums, int target)
        {
            if (nums.Length == 0) { return new int[] { -1, -1 }; }
            if (nums.Length == 1) 
            {
                if (nums[0]==target)
                {
                    return new int[] { 0, 0 };
                }
                return new int[] { -1, -1 }; 
            }
            int[] numbers = SearchNumber(nums, target, new int[] { 0, nums.Length - 1 });
            if (nums[numbers[0]] == target && nums[numbers[1]] == target)
            {
                return numbers;
            }
            return new int[] { -1, -1 };

        }

        private int[] SearchNumber(int[] nums, int target, int[] arrows)
        {
            int arrow = (arrows[0] + arrows[1]) / 2;

            if (nums[arrows[0]] == target && nums[arrows[1]] == target)
            {
                return arrows;
            }

            else if (arrows[0] == arrows[1])
            {
                return new int[] { -1, -1 };
            }

            if (arrow != arrows[0] && nums[arrow] < target)
            {
                arrows[0] = arrow;
                SearchNumber(nums, target, arrows);
            }
            else if (arrow != arrows[1] && nums[arrow] > target)
            {
                arrows[1] = arrow;
                SearchNumber(nums, target, arrows);
            }

            else if (nums[arrows[0]] < target)
            {
                arrows[0]++;
                SearchNumber(nums, target, arrows);
            }
            else if (nums[arrows[1]] > target)
            {
                arrows[1]--;
                SearchNumber(nums, target, arrows);
            }

            return arrows;

        }
    }
}
