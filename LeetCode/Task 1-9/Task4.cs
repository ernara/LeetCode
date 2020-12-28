using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    class Task4
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int i = 0;
            int y = 0;
            List<int> list = new List<int>();

            while (i<nums1.Length && y<nums2.Length)
            {
                if (nums1[i]<nums2[y])
                {
                    list.Add(nums1[i]);
                    i++;
                }
                else
                {
                    list.Add(nums2[y]);
                    y++;
                }
            }

            while (i < nums1.Length)
            {
                list.Add(nums1[i]);
                i++;
            }

            while (y < nums2.Length)
            {
                list.Add(nums2[y]);
                y++;
            }

            if (list.Count == 0)
            {
                return 0;
            }
            else if (list.Count % 2 == 0)
            {
                return (double)(list[list.Count / 2] + list[list.Count / 2 - 1]) / 2;
            }
            return list[list.Count/2];
        }
    }
}
