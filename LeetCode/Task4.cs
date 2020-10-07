using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    class Task4
    {
        /*Given two sorted arrays nums1 and nums2 of size m and n respectively, return the median of the two sorted arrays.
        Follow up: The overall run time complexity should be O(log (m+n)).

        Constraints:

        nums1.length == m
        nums2.length == n
        0 <= m <= 1000
        0 <= n <= 1000
        1 <= m + n <= 2000
        -106 <= nums1[i], nums2[i] <= 106*/

        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int i = 0;
            int y = 0;
            List<int> list = new List<int>();

            //go threw both arrays and add values to list until we go to one of the index end 
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

            //if we still did not finish one of the lists we can do it now
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
