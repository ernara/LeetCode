using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    /*Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
    You may assume that each input would have exactly one solution, and you may not use the same element twice.
    You can return the answer in any order.

    Constraints:

    2 <= nums.length <= 105
    -109 <= nums[i] <= 109
    -109 <= target <= 109
    Only one valid answer exists.*/
    class Task1
    {
        public int[] TwoSum(int[] nums, int target)
        {
            //with Dictionary you can check if needed value exists 
            var dict = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (dict.ContainsKey(target - nums[i]))
                {
                    return new int[] { dict[target - nums[i]], i };
                }
                //if because of duplicate problem. New added value to check if needed value exists for future loops
                if (!dict.ContainsKey(nums[i]))
                {
                    dict.Add(nums[i], i);
                }
            }

            return null;
        }


    }
}
