using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Task11
    {
        public int MaxArea(int[] height)
        {
            int max = 0;

            for (int i = 0; i < height.Length - 1; i++)
            {
                for (int y = i + 1; y < height.Length; y++)
                {
                    int result = height[i] < height[y] ? height[i] : height[y];
                    result *=  (y-i);
                    max = max < result ? result : max;
                }
            }

            return max;
        }
    }
}
